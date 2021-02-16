using FirstAML.Courier.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Interfaces
{
    public interface ICourierOrderService
    {
        public OrderCost GetOrderCost(List<Parcel> courierParcelList);
    }
}
