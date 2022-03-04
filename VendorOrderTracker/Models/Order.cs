using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { }
    public Order(string title)
    {
      Title = title;
    }
  }
}