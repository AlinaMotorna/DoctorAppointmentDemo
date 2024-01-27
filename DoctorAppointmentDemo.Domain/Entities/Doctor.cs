using MyDoctorAppointment.Domain.Entities;
using MyDoctorAppointment.Domain.Enums;
using System.Xml.Serialization;

namespace MyDoctorAppointment.Domain.Entities
{
    public class Doctor : UserBase
    {
        public DoctorTypes DoctorType { get; set; }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Experience { get; set; }

        public int Salary { get; set; }
    }

}
