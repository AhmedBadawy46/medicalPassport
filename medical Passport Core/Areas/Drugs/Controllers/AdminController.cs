using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace medical_Passport_Core.Areas.Drugs.Controllers
{
    [Area("Drugs")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewSubstance()
        {
            return View();
        }

        public IActionResult DrugsIndex()
        {
            return View();
        }

        public IActionResult DrugDetails()
        {
            return View();
        }


    }
}