using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PingPong.Models;

namespace PingPong.Controllers
{
  public class PingPongController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult Display()
    {

      return View();
    }

  }
}
