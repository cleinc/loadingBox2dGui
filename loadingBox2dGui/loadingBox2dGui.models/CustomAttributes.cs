using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace loadingBox2dGui.models
{
    public abstract class MinMaxIntervalAdjustmentValidator: ValidationAttribute
    {
        public abstract (ValidityCheckResult, string, object) ValidateValue (object value);
        public abstract (ValidityCheckResult, string, object) ValidateValueFromInstance (object instance, object value);
    }
    public class MinMaxIntervalAdjustmentValidatorInt: MinMaxIntervalAdjustmentValidator
    {
        private readonly int _min;
        private readonly int _max;
        private readonly int _interval;
        private readonly string _coordinateComponentPropertyName; 

        public MinMaxIntervalAdjustmentValidatorInt(int min, int max, int interval, string propertyName = null)
        {
            _min = min; 
            _max = max;
            _interval = interval;
            _coordinateComponentPropertyName = propertyName;
        }

        public override (ValidityCheckResult, string, object) ValidateValue (object value)
        {
            if (typeof(int) != value.GetType())
            {
                return (ValidityCheckResult.Error, $"Value type invalid, {value.GetType()}", -1);
            }
            ValidityCheckResult validityCheckResult;
            try
            {
                // Adjust value to the nearest interval
                int input = (int)value;
                int adjustedValue = input;
                int remainder = 0;
                string msg = "";

                remainder = (input - _min) % _interval;
                if (remainder != 0)
                {
                    if (remainder >= _interval / 2)
                    {
                        adjustedValue += (_interval - remainder);
                    }
                    else
                    {
                        adjustedValue -= remainder;
                    }
                }

                if (adjustedValue < _min)
                {
                    adjustedValue = _min;
                    msg = $"Value is below the minimum; adjusted to {_min}";
                }
                else if (adjustedValue > _max)
                {
                    adjustedValue = _max;
                    msg = $"Value is above the maximum; adjusted to {_max}";
                }

                validityCheckResult = (adjustedValue == input) ? ValidityCheckResult.Pass : ValidityCheckResult.Adjusted;
                return (validityCheckResult, msg, adjustedValue);
            }
            catch (Exception ex)
            {
                validityCheckResult = ValidityCheckResult.Error;
                return (validityCheckResult, $"Value is invalid. Error: {ex}", -1);
            }
        }
        public override (ValidityCheckResult, string, object) ValidateValueFromInstance(object instance, object value)
        {
            if (_coordinateComponentPropertyName == null)
            {
                return ValidateValue(value);
            }

            var propertyInfo = instance.GetType().GetProperty(_coordinateComponentPropertyName);

            int coordinateComponentValue = (int)propertyInfo.GetValue(instance);
            int input = (int)value;
            if (coordinateComponentValue + input > _max)
            {
                return (ValidityCheckResult.Adjusted, $"Value is over the Max Value. Given Value : {input}, Max: {_max}, Adjusting Value", _max - coordinateComponentValue);
            }
            else
            {
                return ValidateValue(value);
            }
        }
    }
    public class MinMaxIntervalAdjustmentValidatorDouble: MinMaxIntervalAdjustmentValidator
    {
        private readonly double _min;
        private readonly double _max;
        private readonly double _interval;

        public MinMaxIntervalAdjustmentValidatorDouble(double min, double max, double interval)
        {
            _min = min; 
            _max = max;
            _interval = interval;
        }

        public override (ValidityCheckResult, string, object) ValidateValue(object value)
        {
            if (typeof(double) != value.GetType())
            {
                return (ValidityCheckResult.Error, $"Value type invalid, {value.GetType()}", -1.0);
            }
            ValidityCheckResult validityCheckResult;
            try
            {
                // Adjust value to the nearest interval
                double input = (double)value;
                double adjustedValue = input;
                double remainder = (input - _min) % _interval;
                if (remainder != 0)
                {
                    if (remainder >= _interval / 2)
                    {
                        adjustedValue += (_interval - remainder);
                    }
                    else
                    {
                        adjustedValue -= remainder;
                    }
                }

                string msg = "";
                if (adjustedValue < _min)
                {
                    adjustedValue = _min;
                    msg = $"Value is below the minimum; adjusted to {_min}";
                }
                else if (adjustedValue > _max)
                {
                    adjustedValue = _max;
                    msg = $"Value is below the minimum; adjusted to {_max}";
                }

                validityCheckResult = (adjustedValue == input) ? ValidityCheckResult.Pass : ValidityCheckResult.Adjusted;
                return (validityCheckResult, msg, adjustedValue);
            }
            catch (Exception ex)
            {
                validityCheckResult = ValidityCheckResult.Error;
                return (validityCheckResult, $"Value is invalid. Error: {ex}", -1);
            }
        }
        public override (ValidityCheckResult, string, object) ValidateValueFromInstance(object instance, object value)
        {
            return ValidateValue(value);
        }
    }
    public class MinMaxIntervalAdjustmentValidatorFloat: MinMaxIntervalAdjustmentValidator
    {
        private readonly float _min;
        private readonly float _max;
        private readonly float _interval;

        public MinMaxIntervalAdjustmentValidatorFloat(float min, float max, float interval)
        {
            _min = min; 
            _max = max;
            _interval = interval;
        }

        public override (ValidityCheckResult, string, object) ValidateValue(object value)
        {
            if (typeof(float) != value.GetType())
            {
                return (ValidityCheckResult.Error, $"Value type invalid, {value.GetType()}", -1.0f);
            }
            ValidityCheckResult validityCheckResult = ValidityCheckResult.Adjusted;
            try
            {
                // Adjust value to the nearest interval
                float input = (float)value;
                float adjustedValue = input;
                float remainder = (input - _min) % _interval;
                if (remainder != 0)
                {
                    if (remainder >= _interval / 2)
                    {
                        adjustedValue += (_interval - remainder);
                    }
                    else
                    {
                        adjustedValue -= remainder;
                    }
                }

                string msg = "";
                if (adjustedValue < _min)
                {
                    adjustedValue = _min;
                    msg = $"Value is below the minimum; adjusted to {_min}";
                }
                else if (adjustedValue > _max)
                {
                    adjustedValue = _max;
                    msg = $"Value is above the maximum; adjusted to {_max}";
                }

                validityCheckResult = (adjustedValue == input) ? ValidityCheckResult.Pass : ValidityCheckResult.Adjusted;
                return (validityCheckResult, msg, adjustedValue);
            }
            catch (Exception ex)
            {
                validityCheckResult = ValidityCheckResult.Error;
                return (validityCheckResult, $"Value is invalid. Error: {ex}", -1);
            }
        }
        public override (ValidityCheckResult, string, object) ValidateValueFromInstance(object instance, object value)
        {
            return ValidateValue(value);
        }
    }
    public enum ValidityCheckResult
    {
        Pass,
        Adjusted, 
        Error
    }
    //public class RoiValidatorAttribute : MinMaxIntervalAdjustmentValidator
    //{
    //    private readonly int _originPoint;
    //    private readonly int _length;
    //    private readonly int _interval;

    //    public RoiValidatorAttribute(int originPoint, int length, int interval)
    //    {
    //        _originPoint = originPoint;
    //        _length = length;
    //        _interval = interval;
    //    }
    //    public override (bool, string, object) ValidateValue(object value)
    //    {
    //        if (typeof(int) != value.GetType())
    //        {
    //            throw new ArgumentException();
    //        }
    //        try
    //        {
                

    //            return (true, msg, adjustedValue);
    //        }
    //        catch (Exception ex)
    //        {
    //            return (false, $"Value is invalid. Error: {ex}", -1);
    //        }
    //    }
    //    //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    //{
    //    //    var xPropertyInfo = validationContext.ObjectType.GetProperty(_xProperty);
    //    //    var yPropertyInfo = validationContext.ObjectType.GetProperty(_yProperty);

    //    //    if (xPropertyInfo == null || yPropertyInfo == null)
    //    //    {
    //    //        return new ValidationResult($"Unknown property: {_xProperty} or {_yProperty}");
    //    //    }

    //    //    var xValue = (int)xPropertyInfo.GetValue(validationContext.ObjectInstance);
    //    //    var yValue = (int)yPropertyInfo.GetValue(validationContext.ObjectInstance);
    //    //    var roiValue = (int)value;

    //    //    // Calculate width or height based on x and y and adjust to the nearest interval
    //    //    var adjustedRoiValue = (int)Math.Round((double)(xValue + yValue) / _interval) * _interval;

    //    //    // Set the adjusted value back to the property
    //    //    var property = validationContext.ObjectType.GetProperty(validationContext.MemberName);
    //    //    if (property != null)
    //    //    {
    //    //        property.SetValue(validationContext.ObjectInstance, adjustedRoiValue);
    //    //    }

    //    //    return ValidationResult.Success;
    //    //}
    //}
}
