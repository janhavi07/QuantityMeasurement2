using NUnit.Framework;
using Quantity_measurement;
using System;

namespace MeasurementTest
{
    public class Tests
    {
        [Test]
        
        public void GivenZeroInchAndZeroFeet_WhenCompared_ShouldReturnFalse()
        {
            Measurement quantity1 = new Measurement(UnitConverter.INCH, 0.0);
            Measurement quantity2 = new Measurement(UnitConverter.FEET, 0.0);
            Assert.AreEqual(quantity1, quantity2);
        }

        [Test]
         public void Given3Feet1Yard_WhenCompared_ShouldReturnTrue()
         {
            Measurement quantity1 = new Measurement(UnitConverter.FEET ,3.0) ;
            Measurement quantity2 = new Measurement(UnitConverter.YARD, 1.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
         }

        [Test]
        public void Given1feet12Inch_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.FEET, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.INCH, 12.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }

        [Test]
        public void Given1yardAnd36Inch_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.YARD, 1);
            Measurement quantity2 = new Measurement(UnitConverter.INCH, 36.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }


        [Test]
        public void Givennull_WhenCompared_ShouldReturnFalse()
        {
                Measurement quantity1 = new Measurement(UnitConverter.FEET, 1.0);
                Measurement quantity2 = null;
                bool result = quantity1.Equals(quantity2);
                Assert.IsFalse(result);
            
        }

        [Test]
        public void GivenNulValue_WhenCompared_ShouldThrowNullException()
        {
            try
            {
                Measurement quantity1 = new Measurement(UnitConverter.FEET, 1.0);
                Measurement quantity2 = new Measurement(null, 2.0);
                quantity2.Compare(quantity1,quantity2);
            }
            catch(CustomException e)
            {
                Assert.AreEqual("Value passed is null", e.Message);
            }
        }
        [Test]
        public void Given2InchAnd5centimeter_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.INCH, 2.0);
            Measurement quantity2 = new Measurement(UnitConverter.CENTIMETER, 5.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }
        [Test]
        public void Given2InchAnd2Inch_WhenAdded_ShouldReturn4Inch()
        {
            Measurement quantity1 = new Measurement(UnitConverter.INCH, 2.0);
            Measurement quantity2 = new Measurement(UnitConverter.INCH, 2.0);
            Measurement expected = new Measurement(UnitConverter.INCH, 4.0);
            Measurement measurement = quantity2.Add(quantity1, quantity2,UnitConverter.INCH);
            Assert.AreEqual(expected, measurement);
        }
        [Test]
        public void Given1feetAnd2Inch_WhenAdded_ShouldReturn14Inch()
        {
            Measurement quantity1 = new Measurement(UnitConverter.FEET, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.INCH, 2.0);
            Measurement expected = new Measurement(UnitConverter.INCH, 14.0);
            Measurement measurement = quantity2.Add(quantity1, quantity2,UnitConverter.INCH);
            Assert.AreEqual(expected, measurement);
        }

        [Test]
        public void Given2InchAnd25Centimeter_WhenAdded_ShouldReturn3Inch()
        {
            Measurement quantity1 = new Measurement(UnitConverter.INCH, 2.0);
            Measurement quantity2 = new Measurement(UnitConverter.CENTIMETER, 2.5);
            Measurement expected = new Measurement(UnitConverter.INCH, 3.0);
            Measurement measurement = quantity2.Add(quantity1, quantity2,UnitConverter.INCH);
            Assert.AreEqual(expected, measurement);

        }
        [Test]
        public void Given1GallonAnd378Lit_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.GALLON, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.LITRE, 3.78);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);

        }

        [Test]
        public void Given1LitreAnd100ML_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.MILILITRE, 1000.0);
            Measurement quantity2 = new Measurement(UnitConverter.LITRE, 1.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }

        [Test]
        public void Given1LiterAnd3point78lit_WhenAdded_ShouldReturn7point57Lit()
        {
            Measurement quantity1 = new Measurement(UnitConverter.GALLON, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.LITRE, 3.78);
            Measurement expected = new Measurement(UnitConverter.LITRE, 7.56);
            Measurement measurement = quantity2.Add(quantity1, quantity2, UnitConverter.LITRE);
            Assert.AreEqual(expected, measurement);

        }
        [Test]
        public void Given1kgAnd100gn_WHenCompared_SHouldRetunrTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.KILOGRAM, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.GRAM, 1000.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }
        [Test]
        public void Given1tonneAnd1000kgm_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.TONNE, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.KILOGRAM, 1000.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }

        [Test]
        public void Given1tonneAnd100GRMS_WhenAdded_ShouldRetur1001kg()
        {
            Measurement quantity1 = new Measurement(UnitConverter.TONNE, 1.0);
            Measurement quantity2 = new Measurement(UnitConverter.GRAM, 1000.0);
            Measurement expected = new Measurement(UnitConverter.KILOGRAM, 1001.0);
            Measurement measurement = quantity2.Add(quantity1, quantity2, UnitConverter.KILOGRAM);
            Assert.AreEqual(expected, measurement);
        }
        [Test]
        public void Given212FAND100Celcius_WhenCompared_ShouldReturnTrue()
        {
            Measurement quantity1 = new Measurement(UnitConverter.FAHRENHIET, 212.0);
            Measurement quantity2 = new Measurement(UnitConverter.CELCIUS, 100.0);
            bool check = quantity2.Compare(quantity1, quantity2);
            Assert.IsTrue(check);
        }


        
    }
}