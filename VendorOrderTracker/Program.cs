using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace VendorOrderTracker
{
  public class Program
  {
    public static void Main(string[] args)
    {
      new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build()
        .Run();

      
    }
  }
}