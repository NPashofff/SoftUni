using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAtributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException("Not a Number");
            }

            int valueAsInt = (int)obj;
            bool isInRange = valueAsInt >= _minValue && valueAsInt <= _maxValue;

            if (isInRange)
            {
                return true;
            }

            return false;
        }
    }
}
