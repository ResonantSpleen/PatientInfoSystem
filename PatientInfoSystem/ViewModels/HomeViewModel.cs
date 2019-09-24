using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientInfoSystem.Models;

namespace PatientInfoSystem.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
