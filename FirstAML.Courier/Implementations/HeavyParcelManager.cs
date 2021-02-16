using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class HeavyParcelManager : IParcelManager
    {
        public decimal ParcelCost(decimal parcelSize, decimal ParcelWeight)
        {
            decimal regularRate = 50;
            if (ParcelWeight < 50)
                return regularRate + (ParcelWeight - 50) * 1;
            return regularRate;
        }

        public char ParcelType(decimal parcelSize)
        {
            return 'H';
        }
    }
}
