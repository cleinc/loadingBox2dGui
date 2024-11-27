using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class CameraParameter
    {
        [MinMaxIntervalAdjustmentValidatorInt(0, 360, 1)]
        public int Gain { get; set; } = 1; 
        [MinMaxIntervalAdjustmentValidatorFloat(24f, 130000, 1)]
        public float ExposureTimeMicroSeconds { get; set; } = 25000f; 
        [MinMaxIntervalAdjustmentValidatorInt(0, 16, 2)]
        public int RoiX { get; set; }
        [MinMaxIntervalAdjustmentValidatorInt(0, 8, 2)]
        public int RoiY { get; set; }
        [MinMaxIntervalAdjustmentValidatorInt(2, 2456, 2)]
        public int RoiWidth { get; set; }
        [MinMaxIntervalAdjustmentValidatorInt(2, 2052, 2)]
        public int RoiHeight { get; set; }
        public string IpAddress { get; set; }

        public CameraParameter(Dictionary<Camera2DAttribute, string> camParameterDict)
        {
            Gain = int.Parse(camParameterDict[Camera2DAttribute.Gain]);
            ExposureTimeMicroSeconds = float.Parse(camParameterDict[Camera2DAttribute.Exposure]);
            RoiX = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiTopLeftX]);
            RoiY = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiTopLeftY]);
            RoiWidth = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiWidth]);
            RoiHeight = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiHeight]);
            IpAddress = camParameterDict[Camera2DAttribute.IPAdr];
        }

        public void AdjustCameraParameters(Dictionary<Camera2DAttribute, string> camParameterDict)
        {
            Gain = int.Parse(camParameterDict[Camera2DAttribute.Gain]);
            ExposureTimeMicroSeconds = float.Parse(camParameterDict[Camera2DAttribute.Exposure]);
            RoiX = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiTopLeftX]);
            RoiY = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiTopLeftY]);
            RoiWidth = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiWidth]);
            RoiHeight = int.Parse(camParameterDict[Camera2DAttribute.CameraResolutionRoiHeight]);
            IpAddress = camParameterDict[Camera2DAttribute.IPAdr];
        }
        public ValidityCheckResult ValidateCamParameterFromInstance(string input, Camera2DAttribute camera2DAttribute, out object output)
        {
            MinMaxIntervalAdjustmentValidator validator = null;
            // Match Camera2DAttribute to the corresponding property
            object inputValue = null;
            switch (camera2DAttribute)
            {
                case Camera2DAttribute.Gain:

                    validator = GetValidator(this, nameof(Gain));
                    inputValue = input;
                    if (float.TryParse(input, out float gainValue))
                    {
                        inputValue = gainValue;
                    }
                    break;

                case Camera2DAttribute.Exposure:
                    validator = GetValidator(this, nameof(ExposureTimeMicroSeconds));
                    inputValue = input;
                    if (float.TryParse(input, out float exposureValue))
                    {
                        inputValue = exposureValue;
                    }
                    break;

                case Camera2DAttribute.CameraResolutionRoiTopLeftX:
                    validator = GetValidator(this, nameof(RoiX));
                    inputValue = input;
                    if (int.TryParse(input, out int roiX))
                    {
                        inputValue = roiX;
                    }
                    break;

                case Camera2DAttribute.CameraResolutionRoiTopLeftY:
                    validator = GetValidator(this, nameof(RoiY));
                    inputValue = input;
                    if (int.TryParse(input, out int roiY))
                    {
                        inputValue = roiY;
                    }
                    break;

                case Camera2DAttribute.CameraResolutionRoiWidth:
                    validator = GetValidator(this, nameof(RoiWidth));
                    inputValue = input;
                    if (int.TryParse(input, out int roiWidth))
                    {
                        inputValue = roiWidth;
                    }
                    break;

                case Camera2DAttribute.CameraResolutionRoiHeight:
                    validator = GetValidator(this, nameof(RoiHeight));
                    inputValue = input;
                    if (int.TryParse(input, out int roiHeight))
                    {
                        inputValue = roiHeight;
                    }
                    break;

                case Camera2DAttribute.IPAdr:
                    output = input; 
                    return ValidityCheckResult.Pass;

                default: // passing back camera2dattributes that does not have implementations
                    output = input;
                    return ValidityCheckResult.Pass;
            }

            var (validityCheckResult, message, adjustedValue) = validator.ValidateValueFromInstance(this, inputValue);
            output = adjustedValue;
            return validityCheckResult;
        }
        public static MinMaxIntervalAdjustmentValidator GetValidator(object instance, string propertyName)
        {
            var propertyInfo = instance.GetType().GetProperty(propertyName);
            MinMaxIntervalAdjustmentValidator validator = propertyInfo.GetCustomAttribute(typeof(MinMaxIntervalAdjustmentValidator)) as MinMaxIntervalAdjustmentValidator;
            if (validator == null)
            {
                throw new InvalidOperationException($"{nameof(MinMaxIntervalAdjustmentValidator)} not found on the given instance {nameof(instance)}");
            }
            return validator;
        }
    }
}
