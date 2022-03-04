using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatsInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}