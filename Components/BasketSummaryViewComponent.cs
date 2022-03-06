using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using beckysbookstore.Models;

namespace beckysbookstore.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
            private Basket basket;
            
            public BasketSummaryViewComponent(Basket basketService)
            {
                basket = basketService;
            }
            public IViewComponentResult Invoke()
            {
                return View(basket);
            }
     }
}
