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
    public void Venue_Save_SavesVenueToDatabase()
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
    [Fact]
    public void Venue_Find_FindsVenueInDatabase()
    {
      //Arrange
      Venue testVenue = new Venue("Name");
      testVenue.Save();

      //Act
      Venue foundVenue = Venue.Find(testVenue.GetId());

      //Assert
      Assert.Equal(testVenue, foundVenue);
    }
    [Fact]
    public void Venue_Delete_DeletesVenueFromDatabase()
    {
      //Arrange
      string name1 = "Name";
      Venue testVenue1 = new Venue(name1);
      testVenue1.Save();

      string name2 = "Other name";
      Venue testVenue2 = new Venue(name2);
      testVenue2.Save();

      //Act
      testVenue1.Delete();
      List<Venue> resultVenues = Venue.GetAll();
      List<Venue> testVenueList = new List<Venue> {testVenue2};

      //Assert
      Assert.Equal(testVenueList, resultVenues);
    }
    [Fact]
    public void Venue_Update_UpdatesInDb()
    {
      Venue testVenue = new Venue("Name");
      testVenue.Save();
      testVenue.Update("new Name");

      Venue newVenue = new Venue("new Name", testVenue.GetId());

      Assert.Equal(testVenue, newVenue);
    }
    // [Fact]
    // public void Venue_AddBand_AddsBandToVenue()
    // {
    //  //Arrange
    //   Venue testVenue = new Venue("Name");
    //   testVenue.Save();
    //
    //   Band testBand = new Band("Band name");
    //   testBand.Save();
    //
    //   Band testBand2 = new Band("Other band name");
    //   testBand2.Save();
    //
    //  //Act
    //   testVenue.AddBand(testBand);
    //   testVenue.AddBand(testBand2);
    //
    //   List<Band> result = testVenue.GetBands();
    //   List<Band> testList = new List<Band>{testBand, testBand2};
    //
    //  //Assert
    //   Assert.Equal(testList, result);
    // }
  }
}
