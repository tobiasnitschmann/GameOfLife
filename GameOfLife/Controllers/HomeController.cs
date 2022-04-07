﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameOfLife.Models;
using System.Text.Json;
using Newtonsoft.Json;

namespace GameOfLife.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var x = HttpContext.Session.GetString("Board");
        Board b;
        if (HttpContext.Session.GetString("Board")!=null)
        {
            b = JsonConvert.DeserializeObject<Board>(HttpContext.Session.GetString("Board"));
            b.NextGeneration();
            HttpContext.Session.SetString("Board", JsonConvert.SerializeObject(b));
        }
        else
        {
            b = new Board(15, 35);
            b.init();
            HttpContext.Session.SetString("Board", JsonConvert.SerializeObject(b));
        }
        
        return View(b);
    }

    public IActionResult NextGen()
    {
        return RedirectToAction("Index");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

