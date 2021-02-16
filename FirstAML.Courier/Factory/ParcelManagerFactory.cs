using FirstAML.Courier.Service.Implementations;
using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Factory
{
     public class ParcelManagerFactory
    {
        public IParcelManager GetParcelManager(decimal ParcelSize, decimal parcelWeight)
        {
            IParcelManager returnVal = null;
            if (parcelWeight >= 50)
            {
                returnVal = new HeavyParcelManager();
            }
            else
            {
                if (0 < ParcelSize && ParcelSize <= 10) //Small
                {
                    returnVal = new SmallParcelManager();
                }
                else if (10 < ParcelSize && ParcelSize <= 50) //Medium
                {
                    returnVal = new MediumParcelManager();
                }
                else if (50 < ParcelSize && ParcelSize <= 100) //Large
                {
                    returnVal = new LargeParcelManager();
                }
                else  //XL
                {
                    returnVal = new ExtraLargeParcelManager();
                }
            }
            return returnVal;
        }
    }
}
