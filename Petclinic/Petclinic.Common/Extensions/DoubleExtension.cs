using System;
using System.Globalization;

namespace Petclinic.Common.Extensions
{
    public static class DoubleExtension
    {
        public static int GetWholePart(this double? decimalNumber)
        {
            if (decimalNumber == null) return 0;
            return (int)Math.Truncate(decimalNumber.Value);
        }

        public static int GetDecimalPart(this double? decimalNumber)
        {
            if (decimalNumber == null) return 0;

            var partsArray = decimalNumber.Value.ToString(CultureInfo.InvariantCulture).Split('.');
            return partsArray.Length == 2 ? int.Parse(partsArray[1]) : 0;
        }
    }
}