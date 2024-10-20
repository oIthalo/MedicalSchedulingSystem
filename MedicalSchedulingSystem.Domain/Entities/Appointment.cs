using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class Appointment : Entity
    {
        public Appointment(AppointmentDate appointmentDate, Doctor doctor, Patient patient)
        {
            AppointmentDate = appointmentDate;
            Doctor = doctor;
            Patient = patient;

            AddNotifications(appointmentDate, doctor, patient);
        }

        public AppointmentDate AppointmentDate { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
    }
}
