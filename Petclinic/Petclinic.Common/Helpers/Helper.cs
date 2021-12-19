namespace Petclinic.Common.Helpers
{
    public static class Helper
    {
        public static double GetDoubleFromIntegers(int wholePart, int decimalPart)
        {
            var decimalString = $"{wholePart},{decimalPart}";
            return double.Parse(decimalString);
        }
    }
}