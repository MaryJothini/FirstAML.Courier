using FirstAML.Courier.Service.Factory;
using FirstAML.Courier.Service.Interfaces;
using FirstAML.Courier.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAML.Courier.Service.Implementations
{
    public class CourierOrderService : ICourierOrderService
    {

        public OrderCost GetOrderCost(List<Parcel> courierParcelList)
        {
            if (courierParcelList == null)
                return null; // worning message

            OrderCost orderCost = new OrderCost();
            decimal totalCost = 0;
            ParcelManagerFactory parcelManagerFactory = new ParcelManagerFactory();

            foreach (Parcel parcel in courierParcelList) // Assume parcel size is mandatory and validated at the UI layer 
            {
                IParcelManager parcelManager = parcelManagerFactory.GetParcelManager(parcel.ParcelSize, parcel.ParcelWeight);
                parcel.Cost = parcelManager.ParcelCost(parcel.ParcelSize, parcel.ParcelWeight);
                parcel.Type = parcelManager.ParcelType(parcel.ParcelSize);
                totalCost += parcel.Cost;
            }

            orderCost.Parcels = courierParcelList;
            orderCost.TotalCost = totalCost;
            orderCost.TotalDiscount = getDiscount(orderCost.Parcels);
            orderCost.SpeedyShippingCharge = calculateSpeedyShippingCharge(orderCost.TotalCost, orderCost.TotalDiscount);

            return orderCost;
        }

        private decimal getDiscount(List<Parcel> parcelList)
        {
            return 0;
        }

        private decimal calculateSpeedyShippingCharge(decimal totalCost, decimal totalDiscount)
        {
            return (totalCost - totalDiscount) * 2;
        }
    }
}
