using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
            }
            catch 
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void AddOrderNullTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                os1.AddOrder(null);
            }
            catch 
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void AddOrderJudgeTest()
        {
            int oid1 = 1, oid2 = 2;
            Customer c = new Customer();
            Order od1 = new Order(oid1, c);
            Order od2 = new Order(oid2, c);
            OrderService os1 = new OrderService();
            os1.AddOrder(od1);
            os1.AddOrder(od2);
            OrderService os2 = new OrderService();
            os2.AddOrder(od1);
            os2.AddOrder(od2);
            Assert.AreNotEqual(os1, os2);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                od1.AddDetails(new OrderDetail());
                os1.Update(od1);
                Assert.IsNotNull(os1);
            }
            catch 
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void GetByIdTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                Assert.AreEqual(os1.GetById(oid1).Id,oid1);
                os1.RemoveOrder(od1.Id);
                Assert.IsNull(os1.GetById(od1.Id));
            }
            catch 
            {
                Assert.Fail();
            }
            
        }

        [TestMethod()]
        public void QuerryAllTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                Assert.AreEqual(os1.QueryAll()[0].Id, oid1); 
                Assert.AreNotEqual(os1.QueryAll()[0].Id, oid1+1);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                if(os1.QueryByGoodsName("1")!=null)
                    Assert.AreEqual(os1.QueryByGoodsName("1")[0].Id, oid1);
                Assert.AreNotEqual(os1.QueryByGoodsName("1"), os1.QueryByGoodsName("2"));

            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void QueryByTotalAmountTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                if (os1.QueryByTotalAmount(1) != null)
                    Assert.AreEqual(os1.QueryByTotalAmount(1)[0].Id, oid1);
                Assert.AreNotEqual(os1.QueryByTotalAmount(1), os1.QueryByTotalAmount(2));
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            try
            {
                int oid1 = 1;
                Customer c = new Customer(1, "1");
                Order od1 = new Order(oid1, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                if (os1.QueryByCustomerName("1") != null)
                    Assert.AreEqual(os1.QueryByCustomerName("1")[0].Id, oid1);
                Assert.AreNotEqual(os1.QueryByCustomerName("1"), os1.QueryByCustomerName("2"));

            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void SortTest()
        {
            try
            {
                int oid1 = 1, oid2 = 2;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                Order od2 = new Order(oid2, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "2", 2), 2));
                od2.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                os1.AddOrder(od2);

                os1.Sort(
                    (o1, o2) => o2.TotalAmount.CompareTo(o1.TotalAmount));
                Assert.AreEqual(os1.QueryAll()[0].Id, 1);
                Assert.AreEqual(os1.QueryAll()[1].Id, 2);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void ExportTest()
        {
            try
            {
                int oid1 = 1, oid2 = 2;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                Order od2 = new Order(oid2, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "2", 2), 2));
                od2.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                os1.AddOrder(od2);

                os1.Export("ExportTest.xml");
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void ImportTest()
        {
            try
            {
                int oid1 = 1, oid2 = 2;
                Customer c = new Customer();
                Order od1 = new Order(oid1, c);
                Order od2 = new Order(oid2, c);
                od1.AddDetails(new OrderDetail(new Goods(1, "2", 2), 2));
                od2.AddDetails(new OrderDetail(new Goods(1, "1", 1), 1));
                OrderService os1 = new OrderService();
                os1.AddOrder(od1);
                os1.AddOrder(od2);

                Assert.AreEqual(os1.Import("ExportTest.xml")[0],os1.QueryAll()[0]);
            }
            catch
            {
                Assert.Fail();
            }

        }

    }
}