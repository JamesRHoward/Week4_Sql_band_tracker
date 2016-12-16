using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BandTracker
{
  public class VenueTest : IDisposable
  {
    public VenueTest()
    {
      DBConfiguration.ConnectionString = "Data Source=DESKTOP-86RQO71;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Venue.DeleteAll();
    }

    [Fact]
    public void Venue_TestVenueIsEmptyAtFirst()
    {
      //Arrange, Act
      int result = Venue.GetAll().Count;

      Assert.Equal(0, result);
    }
    [Fact]
    public void Venue_Equal_ReturnsTrueForSameName()
    {
      //Arrange, Act
      Venue firstVenue = new Venue("Name");
      Venue secondVenue = new Venue("Name");

      //Assert
      Assert.Equal(firstVenue, secondVenue);
    }
    [Fact]
    public void Test_Save_SavesObject1ToDatabase()
    {
      //Arrange
      Venue testVenue = new Venue("Name");
      testVenue.Save();

      //Act
      List<Venue> result = Venue.GetAll();
      List<Venue> testList = new List<Venue>{testVenue};

      //Assert
      Assert.Equal(testList, result);
    }
  }
}
