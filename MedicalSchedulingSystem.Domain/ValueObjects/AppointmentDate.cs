using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class AppointmentDate : ValueObject
    {
        public AppointmentDate(DateTime appointmentDate)
        {
            Date = appointmentDate;

            AddNotifications(new Contract<AppointmentDate>()
                .Requires()
                .IsLowerThan(Date, DateTime.Now, "AppointmentDate.Date", "Você deve colocar uma data anterior a data de hoje"));
        }

        public DateTime Date { get; private set; }
    }
}
