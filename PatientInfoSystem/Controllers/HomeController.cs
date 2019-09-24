using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientInfoSystem.Models;
using PatientInfoSystem.ViewModels;

namespace PatientInfoSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        public HomeController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IActionResult Index()
        {
            var patients = _patientRepository.GetAllPatients().OrderBy(p => p.LastName);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Patient Overview",
                Patients = patients.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult PatientDetails(int id)
        {
            var patient = _patientRepository.GetPatientById(id);
            if (patient == null)
                return NotFound();

            return View(patient);
        }
    }
}