using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Interfaces
{
    public interface IParcelManager
    {
        char ParcelType(decimal parcelSize);

        decimal ParcelCost(decimal parcelSize, decimal ParcelWeight);

    }
}
