using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientInfoSystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get { return (DateTime.Now - DateOfBirth).Days / 365; }
        }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public List<PatientStudy> Studies { get; set; }
        public List<Visit> Visits { get; set; }
        public string Comments { get; set; }
        
    }
}
