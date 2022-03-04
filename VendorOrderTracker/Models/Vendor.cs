using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id {}
    public List<Order> Orders { get; set; }
    

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Orders = new List<Order>{};
    }
  }
}