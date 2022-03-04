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
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order("title", "description", 30, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_ReturnTitle_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
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
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

      [TestMethod]
    public void SetDescription_ReturnDescription_String()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
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
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetPrice_ReturnPrice_Int()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      int updatedPrice = 40;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_DateTime()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      DateTime result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_ReturnDate_DateTime()
    {
      string title = "title";
      string description = "description";
      int price = 30;
      DateTime date = new DateTime(2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      DateTime updatedDate = new DateTime (2022, 03, 05);
      newOrder.Date = updatedDate;
      DateTime result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "Title1";
      string title02 = "Title2";
      string description01 = "Description1";
      string description02 = "Description2";
      int price01 = 25;
      int price02 = 30;
      DateTime date01 = new DateTime (2022, 03, 04);
      DateTime date02 = new DateTime (2022, 03, 05);
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithIdAndGetterReturns_Int()
    {
      string title = "Title1";
      string description = "Description1";
      int price = 25;
      DateTime date = new DateTime (2022, 03, 04);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Title1";
      string title02 = "Title2";
      string description01 = "Description1";
      string description02 = "Description2";
      int price01 = 25;
      int price02 = 30;
      DateTime date01 = new DateTime (2022, 03, 04);
      DateTime date02 = new DateTime (2022, 03, 05);
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}

