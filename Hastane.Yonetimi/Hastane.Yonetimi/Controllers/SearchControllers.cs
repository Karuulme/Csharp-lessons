using Hastane.Yonetimi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Hastane.Yonetimi.Controllers
{
    public class SearchControllers : Controller
    {
        // GET: Friend/Create  
        public ActionResult Create()
        {
          
            return View();
        }
        // POST: Friend/AddFriend  
        [HttpPost]
        public JsonResult OgrenciBilgisi(SearchModel o)
        {
            return Json("Öğreci başarıyla POST edilmiştir.");
        }
    }
}