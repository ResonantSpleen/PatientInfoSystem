using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public class PatientRepository: IPatientRepository
    {
        private readonly AppDbContext _appDbContext;
        public PatientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddPatient(Patient patient)
        {
            _appDbContext.Patients.Add(patient);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _appDbContext.Patients;
        }

        public Patient GetPatientById(int patientId)
        {
            return _appDbContext.Patients.FirstOrDefault(p => p.PatientId == patientId);
        }
    }
}
