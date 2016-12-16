using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BandTracker
{
  public class BandTest
  {
    public BandTest()
    {
      DBConfiguration.ConnectionString = "Data Source=DESKTOP-86RQO71;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Band_TestBandIsEmptyAtFirst()
    {
      //Arrange, Act
      int result = Band.GetAll().Count;

      Assert.Equal(0, result);
    }
    [Fact]
    public void Band_Equal_ReturnsTrueForSameName()
    {
      //Arrange, Act
      Band firstBand = new Band("Name");
      Band secondBand = new Band("Name");

      //Assert
      Assert.Equal(firstBand, secondBand);
    }
  }
}
