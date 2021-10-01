using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test title", "test description", "test date", 0, true);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetMethods_ReturnsTitleDescriptionDatePriceAndPriority_StringIntBool()
    {
      string title = "Wheat Flour";
      string description = "100 lbs of whole wheat flour.";
      string date = "10/1/2021";
      int price = 200;
      bool priority = false;
      Order newOrder = new Order(title, description, date, price, priority);
      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(date, newOrder.Date);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(priority, newOrder.Priority);
    }

    [TestMethod]
    public void GetId_ReturnsInt_Int()
    {
      string title = "Wheat Flour";
      string description = "100 lbs of whole wheat flour.";
      string date = "10/1/2021";
      int price = 200;
      bool priority = false;
      Order newOrder = new Order(title, description, date, price, priority);
      Assert.AreEqual(1, newOrder.Id);
    }
  }
}