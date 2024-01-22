﻿using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() 
            { Name = "Sif", Age = 2 };
            return View(doggo);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "Pezza", Age = 1 };
            return View(doggo);
        }
    }
}
