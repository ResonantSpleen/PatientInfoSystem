using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatientInfoSystem.Models
{
    public class PatientStudy
    {
        [Key]
        public int PatientStudyId { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int StudyId { get; set; }
        public Study Study { get; set; }
        public string Status { get; set; }

    }
}
