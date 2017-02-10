using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class HomeController : Controller

{
    [Route("Home")]
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeController");
        //return View(); 
    }

    
}