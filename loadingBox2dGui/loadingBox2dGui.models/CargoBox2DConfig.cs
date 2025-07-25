using Basler.Pylon;
using CoPick.Robot;
using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    [Serializable]
    public class CargoBox2DConfig : ICustomTypeDescriptor
    {
        [NonSerialized]
        private PropertyDescriptorCollection _pdColl;
        [Browsable(false)]
        [LocalizedCategory("CategoryGeneral", 1, 4)]
        [LocalizedDescription("DescCarName")]
        [ReadOnly(true)]
        public string CarName { get; set; } = "Unknown";
        [LocalizedCategory("CategoryGeneral", 2, 4)]
        [LocalizedDescription("DescCameraGroupName")]
        [ReadOnly(true)]
        public string Camera { get; set; } = "Unknown";
        [LocalizedCategory("CategoryGeneral", 2, 4)]
        [LocalizedDescription("DescRobotName")]
        [ReadOnly(true)]
        public string Robot { get; set; } = "Unknown";
        [LocalizedCategory("CategoryMasterData", 3, 4)]
        [LocalizedDescription("DescModelPath")]
        [ReadOnly(true)]
        public string ShiftModelPath { get; set; } = "ShiftModel";
        [LocalizedCategory("CategoryMasterData", 3, 4)]
        [LocalizedDescription("DescMasterImageRootPath")]
        [ReadOnly(true)]
        public string MasterImageRootFolderPath { get; set; } = "MasterImage";
        [LocalizedCategory("CategoryMasterData", 3, 4)]
        [LocalizedDescription("DescCheckerBoardRootFolderPath")]
        [ReadOnly(true)]
        public string CheckerBoardRootFolderPath { get; set; } = "CheckerBoard";

        [LocalizedCategory("CategoryMasterData", 3, 4)]
        [LocalizedDescription("DescRobotPoseRootFolderPath")]
        [ReadOnly(true)]
        public string RobotPoseRootFolderPath { get; set; } = "RobotPose";

        [LocalizedCategory("CategoryShiftCalculationParameter", 4, 4)]
        [LocalizedDescription("DescMaxTranslationX")]
        //[ValidatorType(ValidatorType.Float, 5.0f, 1000.0f)]
        public float MaxTranslationX { get; set; } = 20.0f;

        [LocalizedCategory("CategoryShiftCalculationParameter", 4, 4)]
        [LocalizedDescription("DescMaxAbsTranslationY")]
        //[ValidatorType(ValidatorType.Float, 5.0f, 1000.0f)]
        public float MaxTranslationY { get; set; } = 20.0f;

        [LocalizedCategory("CategoryShiftCalculationParameter", 4, 4)]
        [LocalizedDescription("DescMaxAbsTranslationZ")]
        //[ValidatorType(ValidatorType.Float, 5.0f, 1000.0f)]
        public float MaxTranslationZ { get; set; } = 20.0f;

        [LocalizedCategory("CategoryShiftCalculationParameter", 4, 4)]
        [LocalizedDescription("DescMaxAbsRotationZ")]
        public float MaxRotationZ { get; set; } = 1f;

        [LocalizedCategory("CategoryShiftCalculationParameter")]
        [LocalizedDescription("DescEvaluateExceededShiftValueThreshold")]
        public bool DefaultIfExceeded { get; set; } = false;

        [LocalizedCategory("CategoryShiftCalculationParameter")]
        [LocalizedDescription("DescModelConfidenceThreshold")]
        [ValidatorType(ValidatorType.Float, 0f, 1f)]
        public float ConfidenceThreshold { get; set; } = .85f;

        [LocalizedCategory("CategoryShiftCalculationParameter")]
        [LocalizedDescription("DescSizeRatioDifferenceToSrcThreshold")]
        [ValidatorType(ValidatorType.Float, 0f, 5f)]
        public float SizeRatioDifferenceToSrcThreshold { get; set; } = .25f;
        public CargoBox2DConfig()
        {
            UpdatePropertyDescriptors();
        }

        public CargoBox2DConfig DeepClone()
        {
            return new CargoBox2DConfig()
            {
                CarName = CarName, 
                Camera = Camera,
                Robot = Robot,
                ShiftModelPath = ShiftModelPath,
                MasterImageRootFolderPath = MasterImageRootFolderPath,
                CheckerBoardRootFolderPath = CheckerBoardRootFolderPath,
                RobotPoseRootFolderPath = RobotPoseRootFolderPath,
                MaxTranslationX = MaxTranslationX,
                MaxTranslationY = MaxTranslationY,
                MaxTranslationZ = MaxTranslationZ,
                MaxRotationZ = MaxRotationZ,
                DefaultIfExceeded = DefaultIfExceeded,
                ConfidenceThreshold = ConfidenceThreshold,
                SizeRatioDifferenceToSrcThreshold = SizeRatioDifferenceToSrcThreshold
            }; 
        }

        public void UpdatePropertyDescriptors()
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(this);
            PropertyDescriptor[] propertyDescriptorArray = typeof(CargoBox2DConfig).GetProperties()
                .Select(m => new CargoBox2DConfigPropertyDescriptor(pdc[m.Name], m.GetCustomAttributes(false).Cast<Attribute>().ToArray()))
                .ToArray();
            _pdColl = new PropertyDescriptorCollection(propertyDescriptorArray);
        }

        public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);
        public string GetClassName() => TypeDescriptor.GetClassName(this, true);
        public string GetComponentName() => TypeDescriptor.GetComponentName(this, true);
        public TypeConverter GetConverter() => TypeDescriptor.GetConverter(this, true);
        public EventDescriptor GetDefaultEvent() => TypeDescriptor.GetDefaultEvent(this, true);
        public PropertyDescriptor GetDefaultProperty() => TypeDescriptor.GetDefaultProperty(this, true);
        public object GetEditor(Type editorBaseType) => TypeDescriptor.GetEditor(this, editorBaseType, true);
        public EventDescriptorCollection GetEvents() => TypeDescriptor.GetEvents(this, true);
        public EventDescriptorCollection GetEvents(Attribute[] attributes) => TypeDescriptor.GetEvents(this, attributes, true);
        public PropertyDescriptorCollection GetProperties() => _pdColl;
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => _pdColl;
        public object GetPropertyOwner(PropertyDescriptor pd) => this;
    }

    public class CargoBox2DConfigPropertyDescriptor : PropertyDescriptor
    {
        private PropertyDescriptor _originalPd;

        public CargoBox2DConfigPropertyDescriptor(PropertyDescriptor pd, Attribute[] attrs)
            : base(pd, attrs)
        {
            _originalPd = pd;
        }

        public override Type ComponentType
        {
            get => _originalPd.ComponentType;
        }
        public override bool IsReadOnly
        {
            get => _originalPd.IsReadOnly;
        }

        public override Type PropertyType
        {
            get => _originalPd.PropertyType;
        }

        public override bool CanResetValue(object component) => _originalPd.CanResetValue(component);
        public override object GetValue(object component) => _originalPd.GetValue(component);
        public override void ResetValue(object component) => _originalPd.ResetValue(component);
        public override void SetValue(object component, object value) => _originalPd.SetValue(component, value);
        public override bool ShouldSerializeValue(object component) => _originalPd.ShouldSerializeValue(component);
    }
}
