using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_measurement
{
    public class Measurement
    {
        private UnitConverter quantity;
        private double value;

        public Measurement(UnitConverter quantity, double value) 
        {
            this.quantity = quantity;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) 
                return true;
            if(obj == null || !this.GetType().Equals(obj.GetType()) )
                return false;
            Measurement measurement = (Measurement)obj; //Type casting to measurement obj.
             return Double.Equals(measurement.quantity.ConvertQuantity(measurement.value), this.quantity.ConvertQuantity(this.value));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantity1"></param>
        /// <param name="quantity2"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public Measurement Add(Measurement quantity1,Measurement quantity2, UnitConverter unit)
        {
            
            return new Measurement(unit, (quantity1.quantity.ConvertQuantity(quantity1.value)) 
                + (quantity2.quantity.ConvertQuantity(quantity2.value)));

        }

        public bool Compare(Measurement quantity1, Measurement quantity2)
        {
                if (quantity1.quantity == null || quantity2.quantity == null)
                    throw new CustomException(CustomException.ExceptionType.NullValueException, "Value passed is null");
                return quantity1.Equals(quantity2);
           
        }
    }
}
