using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int StudyId { get; set; }
        public Study Study { get; set; }
        public int VisitNumber { get; set; }
        public DateTime VisitDate { get; set; }         
    }
}
