using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace medical_Passport_Core.Areas.Doctors.Controllers
{
    [Area("Doctors")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAgreementLicense()
        {
            return PartialView("_AgreementLicense");
        }

        public IActionResult GetBasicInfo()
        {
            return PartialView("_BasicInfo");
        }

        public IActionResult GetFacilityData()
        {
            return PartialView("_FacilityData");
        }

        public IActionResult GetScheduleData()
        {
            return PartialView("_ScheduleData");
        }
    }
}