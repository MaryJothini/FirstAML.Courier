using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class SmallParcelManager : IParcelManager
    {
        public decimal ParcelCost(decimal parcelSize, decimal ParcelWeight)
        {
            decimal regularRate = 3;
            if (ParcelWeight > 1)
                 return regularRate + (ParcelWeight - 1) * 2;
            return regularRate;
        }

        public char ParcelType(decimal parcelSize)
        {
            return 'S';
        }
    }
}
