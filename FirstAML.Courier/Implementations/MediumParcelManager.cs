using FirstAML.Courier.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class MediumParcelManager : IParcelManager
    {
        public decimal ParcelCost(decimal parcelSize, decimal ParcelWeight)
        {
            decimal regularRate = 8;
            if (ParcelWeight > 3)
                return regularRate + (ParcelWeight - 3) * 2;
            return regularRate;
        }

        public char ParcelType(decimal parcelSize)
        {
            return 'M';
        }
    }
}
