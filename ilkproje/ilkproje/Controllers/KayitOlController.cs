using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkproje.Controllers
{
    public class KayitOlController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
