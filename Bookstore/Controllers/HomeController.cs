using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository temp)
        {
            repo = temp;
        }

        // index controller that returns view with data from the model
        // don't name it page 
        public IActionResult Index(int pageNum = 1)
        {
            // gives different pages

            int pageSize = 10;

            var blah = repo.Books
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize);

            return View(blah);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}

