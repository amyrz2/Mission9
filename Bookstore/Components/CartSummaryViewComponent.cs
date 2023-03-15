using System;
using System.Linq;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket { get; }

        public CartSummaryViewComponent (Basket b)
        {
            basket = b;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}

