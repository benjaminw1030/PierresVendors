using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.Models;
using System.Collections.Generic;
using System;

namespace Template.Tests
{
  [TestClass]
  public class ModelTests : IDisposable
  {
    public void Dispose()
    {
      Model.ClearAll();
    }

    [TestMethod]
    public void ModelConstructor_CreatesInstanceOfModel_Model()
    {

    }
  }
}