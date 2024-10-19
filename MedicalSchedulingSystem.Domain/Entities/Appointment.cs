using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class Appointment : Entity
    {
        public Appointment(DateTime appointmentDate, Doctor doctor, Patient patient)
        {
            AppointmentDate = appointmentDate;
            Doctor = doctor;
            Patient = patient;
        }

        public DateTime AppointmentDate { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
    }
}
