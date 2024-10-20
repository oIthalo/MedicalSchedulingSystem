using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class Patient : Entity
    {
        private readonly IList<Appointment> _appointments;

        public Patient(Name name, BirthDate birthDate, Contact contact, Document document, IList<Appointment> appointments)
        {
            Name = name;
            BirthDate = birthDate;
            Contact = contact;
            Document = document;
            _appointments = new List<Appointment>();
        }

        public Name Name { get; private set; }
        public BirthDate BirthDate { get; private set; }
        public Contact Contact { get; private set; }
        public Document Document { get; private set; }
        public IReadOnlyCollection<Appointment> Appointments { get { return _appointments.ToArray(); } }
    }
}