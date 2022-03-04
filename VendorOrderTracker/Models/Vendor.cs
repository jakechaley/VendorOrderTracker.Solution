using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description {}
    public List<Order> Orders;

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Orders = new List<Order>{};
    }
  }
}