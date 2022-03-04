using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
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
      Order newOrder = new Order("title", "description", 30);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_ReturnTitle_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      String updatedTitle = "Sally's Bake Shop Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

      [TestMethod]
    public void SetDescription_ReturnDescription_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      String updatedDescription = "newDescription";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    public void SetPrice_ReturnPrice_Int()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      Order newOrder = new Order(title, description, price);
      int updatedPrice = 40;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }
  }
}

