using FirstAML.Courier.Service.Implementations;
using FirstAML.Courier.Service.Model;
using NUnit.Framework;
using System.Collections.Generic;

namespace FirstAML.Courier.Service.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Basic_Test_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 12;
            p.ParcelName = "Medium";
            pList.Add(p);

            Parcel p1 = new Parcel();
            p1.ParcelSize = 3;
            p1.ParcelName = "Small";
            pList.Add(p1);

            Parcel p2 = new Parcel();
            p2.ParcelSize = 57;
            p2.ParcelName = "Large";
            pList.Add(p2);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(26, x.TotalCost);
        }

        [Test]
        public void Test_Small_Only_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p1 = new Parcel();
            p1.ParcelSize = 3;
            p1.ParcelName = "Small";
            pList.Add(p1);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(3, x.TotalCost);
        }

        [Test]
        public void Test_Small_Only_Fail()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p1 = new Parcel();
            p1.ParcelSize = 3;
            p1.ParcelName = "Small";
            pList.Add(p1);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreNotEqual(13, x.TotalCost);
        }

        [Test]
        public void Test_Medium_Only_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 12;
            p.ParcelName = "Medium";
            pList.Add(p);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(8, x.TotalCost);
        }

        [Test]
        public void Test_XLarge_Only_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 120;
            p.ParcelName = "XLarge";
            pList.Add(p);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(25, x.TotalCost);
        }


        [Test]
        public void Test_Heavy_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 120;
            p.ParcelWeight = 50;
            p.ParcelName = "XLarge";
            pList.Add(p);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(50, x.TotalCost);
        }

        public void Test_HeavyPlus_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 120;
            p.ParcelWeight = 55;
            p.ParcelName = "XLarge";
            pList.Add(p);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(55, x.TotalCost);
        }
        [Test]
        public void Test_Weight_Pass()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 12;
            p.ParcelWeight = 4;
            p.ParcelName = "Medium";
            pList.Add(p);

            Parcel p1 = new Parcel();
            p1.ParcelSize = 3;
            p1.ParcelWeight = 2;
            p1.ParcelName = "Small";
            pList.Add(p1);

            Parcel p2 = new Parcel();
            p2.ParcelSize = 57;
            p2.ParcelWeight = 7;
            p2.ParcelName = "Large";
            pList.Add(p2);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreEqual(32, x.TotalCost);
        }

        [Test]
        public void Test_Weight_Fail()
        {
            List<Parcel> pList = new List<Parcel>();

            Parcel p = new Parcel();
            p.ParcelSize = 12;
            p.ParcelWeight = 4;
            p.ParcelName = "Medium";
            pList.Add(p);

            Parcel p1 = new Parcel();
            p1.ParcelSize = 3;
            p1.ParcelWeight = 2;
            p1.ParcelName = "Small";
            pList.Add(p1);

            Parcel p2 = new Parcel();
            p2.ParcelSize = 57;
            p2.ParcelWeight = 7;
            p2.ParcelName = "Large";
            pList.Add(p2);

            CourierOrderService service = new CourierOrderService();

            OrderCost x = service.GetOrderCost(pList);

            Assert.AreNotEqual(33, x.TotalCost);
        }
    }
}