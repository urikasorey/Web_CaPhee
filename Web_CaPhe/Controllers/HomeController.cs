﻿using Microsoft.AspNetCore.Mvc;
using Web_CaPhe.Models.Interface;
using Web_CaPhe;

public class HomeController : Controller
{
    private IProductRepository productRepository;

    public HomeController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public IActionResult Index()
    {
        return View(productRepository.GetTrendingProducts());
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Login()
    {
      
        return View();
    }
}
