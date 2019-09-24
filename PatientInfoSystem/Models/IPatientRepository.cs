using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientById(int patientId);
        void AddPatient(Patient patient);
    }
}
