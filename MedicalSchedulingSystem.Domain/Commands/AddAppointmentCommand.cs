using MedicalSchedulingSystem.Domain.Entities;
using MedicalSchedulingSystem.Domain.ValueObjects;
namespace MedicalSchedulingSystem.Domain.Commands;

public class AddAppointmentCommand
{
    public Name PatientName { get; set; }
    public DateTime BirthDate { get; set; }
    public Document Document { get; set; }
    public ContactNumber PhoneNumber { get; set; }
    public Email Email { get; set; }

    public Name DoctorName { get; set; }
    public List<Specialty> Specialties { get; set; }

    public AppointmentDate AppointmentDate { get; set; }
}