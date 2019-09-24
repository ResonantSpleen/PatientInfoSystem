using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public class Study
    {   
        [Key]
        public int StudyId { get; set; }
        public string StudyName { get; set; }
    }
}
