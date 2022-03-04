using beckysbookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beckysbookstore.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }
        //private IPurchaseRepository repo { get; set; }
        //private Basket basket { get; set; }
        //public PurchaseController (IPurchaseRepository temp, Basket b)
        //{
        //    repo = temp;
        //    basket = b;
        //}
        //public IActionResult Index()
        //{
        //    return View(new Purchase());
        //}
        //[HttpPost]
        //public IActionResult Checkout(Purchase purchase)
        //{
        //    if (basket.Items.Count() == 0)
        //    {
        //        ModelState.AddModelError("", "Sorry");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        purchase.Lines = basket.Items.ToArray();
        //        repo.SavePurchase(purchase);
        //        basket.ClearBasket();

        //        return View();
        //    }
        //}
    }
}
