﻿using MyDoctorAppointment.Domain.Entities;
using System.Xml.Serialization;

var doctor = new Doctor()
{
    ID = 232323,
    FirstName = "Bob",
    LastName = "Smith",
    DoctorType = "neurosurgeon",
    Experience = "12 years"
    Salary = 19000,
};
var serializer = new XmlSerializer(typeof(Patient));
using (var writer = new StreamWriter("doctor.xml"))
{
    serializer.Serialize(writer, doctor);
}