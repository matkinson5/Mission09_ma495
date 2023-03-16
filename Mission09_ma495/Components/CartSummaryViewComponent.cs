using Microsoft.AspNetCore.Mvc;
using Mission09_ma495.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_ma495.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket b)
        {
             basket = b;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
