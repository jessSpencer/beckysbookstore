using beckysbookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beckysbookstore.Components
{
    public class CategorysViewComponent: ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public CategorysViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCat"];
            var categorys = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categorys);
        }
    }
}
