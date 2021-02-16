using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class ExtraLargeParcelManager : IParcelManager
    {
        public decimal ParcelCost(decimal parcelSize, decimal ParcelWeight)
        {
            decimal regularRate = 25;
            if (ParcelWeight > 10)
                return regularRate + (ParcelWeight - 10) * 2;
            return regularRate;
        }

        public char ParcelType(decimal parcelSize)
        {
            return 'X';
        }
    }
}
