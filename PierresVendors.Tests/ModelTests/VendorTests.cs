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
  }
}