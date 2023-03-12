using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class BuyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View(new Buy());
        }
    }
}