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
        private IBuyRepository repo { get; set; }
        private Basket basket { get; set; }

        // set up a constructor
        public BuyController(IBuyRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Buy());
        }

        [HttpPost]
        public IActionResult Checkout(Buy buy)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty");
            }

            if (ModelState.IsValid)
            {
                buy.Lines = basket.Items.ToArray();
                repo.SaveBuy(buy);
                basket.ClearBasket();

                return RedirectToPage("/BuyCompleted");

            }
            else
            {
                return View();
            }
        }
    }
}