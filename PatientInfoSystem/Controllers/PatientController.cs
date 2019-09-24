using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientInfoSystem.Models;

namespace PatientInfoSystem.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Patient patient)
        {
            if(ModelState.IsValid)
            {
                _patientRepository.AddPatient(patient);
                return RedirectToAction("PatientEntered");
            }
            return View(patient);
        }

        public IActionResult PatientEntered()
        {
            return View();
        }
    }
}