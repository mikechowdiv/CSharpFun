using System;

namespace SimpleCalculater
{
   public class InputConverter
    {
        public double ConvertInputToNumeric(string argTestInput)
        {
            double convertedNumber;
            if(!double.TryParse(argTestInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }
            return convertedNumber;
        }
    }
}