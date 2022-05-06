﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
   
            Models.Product p = new Models.Product();

            //pass a list of products to the view
            return View(p.GetProducts());
        }
    }
}