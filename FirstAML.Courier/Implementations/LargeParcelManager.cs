using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class LargeParcelManager : IParcelManager
    {
        public decimal ParcelCost(decimal parcelSize, decimal ParcelWeight)
        {
            decimal regularRate = 15;
            if (ParcelWeight > 6)
                return regularRate + (ParcelWeight - 6) * 2;
            return regularRate;
        }

        public char ParcelType(decimal parcelSize)
        {
            return 'L';
        }
    }
}
