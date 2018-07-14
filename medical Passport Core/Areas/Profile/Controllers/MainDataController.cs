using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace medical_Passport_Core.Areas.Profile.Controllers
{
    [Area("profile")]
    public class MainDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetBasicData()
        {
            return PartialView("_BasicData");
        }

        public IActionResult GetFamilyData()
        {
            return PartialView("_FamilyData");
        }
    }
}