using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    interface IVisitRepository
    {
        IEnumerable<Visit> GetAllVisitsForPatient(int patientId);
        Visit GetVisitById(int visitId);
        void AddVisit(Visit visit);
    }
}
