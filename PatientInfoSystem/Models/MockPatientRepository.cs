//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PatientInfoSystem.Models
//{
//    public class MockPatientRepository : IPatientRepository
//    {
//        private List<Patient> _patients;
//        public MockPatientRepository()
//        {
//            if (_patients == null)
//            {
//                InitializePatients();
//            }
//        }

//        private void InitializePatients()
//        {
//            _patients = new List<Patient>
//            {
//                new Patient
//                {
//                    PatientId = 1,
//                    FirstName = "Mary",
//                    LastName = "Smith",
//                    Gender = Enums.Gender.Female,
//                    DateOfBirth = new DateTime(1956, 1, 18),
//                    PhoneNumber = "7273850368",
//                    Email = "test@test.com",
//                    StreetAddress = "123 Cherry Street",
//                    City = "Gainesville",
//                    State = "Florida",
//                    Zipcode = "32611",
//                    AlsType = Enums.ALSType.bulbar
//                },
//                new Patient
//                {
//                    PatientId = 2,
//                    FirstName = "John",
//                    LastName = "Smith",
//                    Gender = Enums.Gender.Male,
//                    DateOfBirth = new DateTime(1967, 3, 25),
//                    PhoneNumber = "7278711299",
//                    Email = "test2@test.com",
//                    StreetAddress = "456 Cherry Street",
//                    City = "Atlanta",
//                    State = "Georgia",
//                    Zipcode = "30342",
//                    AlsType = Enums.ALSType.lateral
//                }
//            };         
//        }
//        public IEnumerable<Patient> GetAllPatients()
//        {
//            return _patients;
//        }

//        public Patient GetPatientById(int patientId)
//        {
//            return _patients.FirstOrDefault(p => p.PatientId == patientId);
//        }

//        public void AddPatient(Patient patient)
//        {
//            return _patients.;
//        }
//    }
//}
