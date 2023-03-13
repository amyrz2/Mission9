using System;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Buy buy;
        public CartSummaryViewComponent(Buy cartService)
        {
            buy = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(buy);
        }
    }
}

