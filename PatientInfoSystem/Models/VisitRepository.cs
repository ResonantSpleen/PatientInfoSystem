using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public class VisitRepository: IVisitRepository
    {
        private readonly AppDbContext _appDbContext;
        public VisitRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddVisit(Visit visit)
        {
            _appDbContext.Visits.Add(visit);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Visit> GetAllVisitsForPatient(int patientId)
        {
            return _appDbContext.Visits.Where(v => v.PatientId == patientId);
        }

        public Visit GetVisitById(int visitId)
        {
            return _appDbContext.Visits.FirstOrDefault(v => v.VisitId == visitId);
        }
    }
}
