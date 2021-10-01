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

    [TestMethod]
    public void GetAll_ReturnsAllOrders_Order()
    {
      string name01 = "Wheat Flour";
      string description01 = "100 lbs of whole wheat flour.";
      string date01 = "10/1/2021";
      int price01 = 200;
      bool priority01 = false;
      string name02 = "Grade A Eggs";
      string description02 = "1 gross of cage-free grade A chicken eggs.";
      string date02 = "9/30/2021";
      int price02 = 300;
      bool priority02 = true;
      Order newOrder1 = new Order(name01, description01, date01, price01, priority01);
      Order newOrder2 = new Order(name02, description02, date02, price02, priority02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name01 = "Wheat Flour";
      string description01 = "100 lbs of whole wheat flour.";
      string date01 = "10/1/2021";
      int price01 = 200;
      bool priority01 = false;
      string name02 = "Grade A Eggs";
      string description02 = "1 gross of cage-free grade A chicken eggs.";
      string date02 = "9/30/2021";
      int price02 = 300;
      bool priority02 = true;
      Order newOrder1 = new Order(name01, description01, date01, price01, priority01);
      Order newOrder2 = new Order(name02, description02, date02, price02, priority02);
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder1, result);
    }
  }
}