using System.Collections.Generic;
using System.IO;
using Microsoft.AspNet.Builder;
using Nancy.Owin;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace Template
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      app.UseOwin(x => x.UseNancy());
    }
  }
  public static class BandTracker
  {
      //School Server
      // public static string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=template;Integrated Security=SSPI;";

      //Home Server
      public static string ConnectionString = "Data Source=DESKTOP-86RQO71;Initial Catalog=hair_salon;Integrated Security=SSPI;";
  }
}

  }
  public class CustomRootPathProvider : IRootPathProvider
  {
    public string GetRootPath()
    {
      return Directory.GetCurrentDirectory();
    }
  }
  public class RazorConfig : IRazorConfiguration
  {
    public IEnumerable<string> GetAssemblyNames()
    {
      return null;
    }

    public IEnumerable<string> GetDefaultNamespaces()
    {
      return null;
    }

    public bool AutoIncludeModelNamespace
    {
      get { return false; }
    }
  }
}
