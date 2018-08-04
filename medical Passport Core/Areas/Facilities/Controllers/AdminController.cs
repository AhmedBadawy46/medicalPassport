using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace medical_Passport_Core.Areas.Facilities.Controllers
{
    [Area("Facilities")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}