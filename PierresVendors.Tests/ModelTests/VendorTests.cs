using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetMethods_ReturnsNameAndDescription_String()
    {
      string name = "Frank's Flour";
      string description = "Sells the best flour.";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void GetId_ReturnsInt_Int()
    {
      string name = "Frank's Flour";
      string description = "Sells the best flour.";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(1, newVendor.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_Vendor()
    {
      string name01 = "Frank's Flour";
      string description01 = "Sells the best flour.";
      string name02 = "Eve's Eggs";
      string description02 = "Sells the best eggs";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Frank's Flour";
      string description01 = "Sells the best flour.";
      string name02 = "Eve's Eggs";
      string description02 = "Sells the best eggs";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "Wheat Flour";
      string orderDescription = "100 lbs of whole wheat flour.";
      string orderDate = "10/1/2021";
      int orderPrice = 200;
      bool orderPriority = false;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice, orderPriority);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Frank's Flour";
      string vendorDescription = "Sells the best flour.";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}