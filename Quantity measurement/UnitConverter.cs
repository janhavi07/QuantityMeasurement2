using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurement
{
    public class UnitConverter
    {
        public readonly static UnitConverter FEET = new UnitConverter(12.0);
        public readonly static UnitConverter INCH = new UnitConverter(1.0);
        public readonly static UnitConverter YARD = new UnitConverter(36.0);
        public readonly static UnitConverter CENTIMETER = new UnitConverter(0.4);

        public readonly static UnitConverter LITRE = new UnitConverter(1.0);
        public readonly static UnitConverter GALLON = new UnitConverter(3.78);
        public readonly static UnitConverter MILILITRE = new UnitConverter(0.001);

        public static readonly UnitConverter KILOGRAM = new UnitConverter(1.0);
        public static readonly UnitConverter GRAM = new UnitConverter(0.001);
        public static readonly UnitConverter TONNE = new UnitConverter(1000);

        public readonly static UnitConverter FAHRENHIET = new UnitConverter(1.0);
        public readonly static UnitConverter CELCIUS = new UnitConverter(2.12);

        private readonly double baseConvert;

        public UnitConverter(double baseConvert)
        {
            this.baseConvert = baseConvert;
        }

        public double ConvertQuantity(double value)
        {
            return this.baseConvert * value;
        }
    }

}
