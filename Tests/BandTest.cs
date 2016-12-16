using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BandTracker
{
  public class BandTest : IDisposable
  {
    public BandTest()
    {
      DBConfiguration.ConnectionString = "Data Source=DESKTOP-86RQO71;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Band.DeleteAll();
      Venue.DeleteAll();
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
    [Fact]
    public void Band_Save_SavesBandToDatabase()
    {
      //Arrange
      Band testBand = new Band("Name");
      testBand.Save();

      //Act
      List<Band> result = Band.GetAll();
      List<Band> testList = new List<Band>{testBand};

      //Assert
      Assert.Equal(testList, result);
    }
    [Fact]
    public void Band_Find_FindsBandInDatabase()
    {
      //Arrange
      Band testBand = new Band("Name");
      testBand.Save();

      //Act
      Band foundBand = Band.Find(testBand.GetId());

      //Assert
      Assert.Equal(testBand, foundBand);
    }
    [Fact]
    public void Band_Delete_DeletesBandFromDatabase()
    {
      //Arrange
      string name1 = "Name";
      Band testBand1 = new Band(name1);
      testBand1.Save();

      string name2 = "Other name";
      Band testBand2 = new Band(name2);
      testBand2.Save();

      //Act
      testBand1.Delete();
      List<Band> resultBands = Band.GetAll();
      List<Band> testBandList = new List<Band> {testBand2};

      //Assert
      Assert.Equal(testBandList, resultBands);
    }
    [Fact]
    public void Band_Update_UpdatesInDb()
    {
      Band testBand = new Band("Name");
      testBand.Save();
      testBand.Update("new Name");

      Band newBand = new Band("new Name", testBand.GetId());

      Assert.Equal(testBand, newBand);
    }
    [Fact]
    public void Band_AddVenue_AddsVenueToBand()
    {
     //Arrange
      Band testBand = new Band("Name");
      testBand.Save();

      Venue testVenue = new Venue("Venue name");
      testVenue.Save();


     //Act
      testBand.AddVenue(testVenue);

      List<Venue> result = testBand.GetVenues();
      List<Venue> testList = new List<Venue>{testVenue};

     //Assert
      Assert.Equal(testList, result);
    }
    [Fact]
    public void Band_Delete_DeletesVenueAssociationsFromDatabase()
    {
      //Arrange
      Band testBand = new Band("Band name");
      testBand.Save();

      string testName = "Name";
      Venue testVenue = new Venue(testName);
      testVenue.Save();

      //Act
      testVenue.AddBand(testBand);
      testVenue.Delete();

      List<Venue> resultBandVenues = testBand.GetVenues();
      List<Venue> testBandVenues = new List<Venue> {};

      //Assert
      Assert.Equal(testBandVenues, resultBandVenues);
    }
  }
}
