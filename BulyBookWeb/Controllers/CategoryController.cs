﻿using BulyBookWeb.Data;
using BulyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList= _db.Categories;
            return View(objCategoryList);
        }
    }
}
