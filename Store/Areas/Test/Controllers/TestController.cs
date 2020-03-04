using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Areas.TestArea.Controllers
{
    public class TestController : Controller
    {
        [Area("Test")]
        public IActionResult Index()
        {
            return View();
        }
    }
}