using Nancy;
using System.Collections.Generic;

namespace BandTracker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      Get["/venues"] = _ => {
        List<Venue> allVenues = Venue.GetAll();
        return View["venues.cshtml", allVenues];
      };
      Get["/bands"] = _ => {
        List<Band> allbands = Band.GetAll();
        return View["bands.cshtml", allbands];
      };
      Get["/venues/new"] = _ => {
        return View["venue_form.cshtml"];
      };
      Post["/venues/new"] = _ => {
        Venue newVenue = new Venue(Request.Form["venue-name"]);
        newVenue.Save();
        return View["success.cshtml"];
      };
      Get["/bands/new"] = _ => {
        return View["band_form.cshtml"];
      };
      Post["/bands/new"] = _ => {
        Band newBand = new Band(Request.Form["band-name"]);
        newBand.Save();
        return View["success.cshtml"];
      };
      Get["venues/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Venue SelectedVenue = Venue.Find(parameters.id);
        List<Band> VenueBands = SelectedVenue.GetBands();
        List<Band> AllBands = Band.GetAll();
        model.Add("venue", SelectedVenue);
        model.Add("venueBands", VenueBands);
        model.Add("allBands", AllBands);
        return View["venue.cshtml", model];
      };
      Post["venue/add_band"] = _ => {
        Band band = Band.Find(Request.Form["band-id"]);
        Venue venue = Venue.Find(Request.Form["venue-id"]);
        venue.AddBand(band);
        return View["success.cshtml"];
      };
      Get["bands/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Band SelectedBand = Band.Find(parameters.id);
        List<Venue> BandVenues = SelectedBand.GetVenues();
        List<Venue> AllVenues = Venue.GetAll();
        model.Add("band", SelectedBand);
        model.Add("bandVenues", BandVenues);
        model.Add("allVenues", AllVenues);
        return View["band.cshtml", model];
      };
      Post["band/add_venue"] = _ => {
        Venue venue = Venue.Find(Request.Form["venue-id"]);
        Band band = Band.Find(Request.Form["band-id"]);
        band.AddVenue(venue);
        return View["success.cshtml"];
      };
      Get["venues/update/{id}"] = parameters =>{
       Venue foundVenue = Venue.Find(parameters.id);
       return View["venue_update.cshtml", foundVenue];
      };
      Patch["venues/update/{id}"] = parameters =>{
        Venue foundVenue = Venue.Find(parameters.id);
        foundVenue.Update(Request.Form["new-description"]);
        return View["success.cshtml"];
      };
      Get["bands/update/{id}"] = parameters =>{
       Band foundBand = Band.Find(parameters.id);
       return View["band_update.cshtml", foundBand];
      };
      Patch["bands/update/{id}"] = parameters =>{
        Band foundBand = Band.Find(parameters.id);
        foundBand.Update(Request.Form["new-description"]);
        return View["success.cshtml"];
      };
      Delete["venue/delete/{id}"] = parameters =>
      {
        Venue foundVenue = Venue.Find(parameters.id);
        foundVenue.Delete();
        return View["success.cshtml"];
      };
      Delete["band/delete/{id}"] = parameters =>
      {
        Band foundBand = Band.Find(parameters.id);
        foundBand.Delete();
        return View["success.cshtml"];
      };
    }
  }
}
