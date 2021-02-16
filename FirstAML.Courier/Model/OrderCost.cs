using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Model
{
    public class OrderCost
    {
        public List<Parcel> Parcels { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal SpeedyShippingCharge { get; set; }

    }
}
