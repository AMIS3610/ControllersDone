using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class ListingsController : Controller

{
    [Route("Listings")]
    public IActionResult Index()
    {
        return Ok("This is the index of the ListingsController");
        //return View(); 
    }

     [Route("Listings/CreateListing")] 
    public IActionResult CreateListing() 
    {
        return Ok("This is Listings/CreateListings");
    }
    
}