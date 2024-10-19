using MedicalSchedulingSystem.Domain.ValueObjects;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class EmailContact : Contact
    {
        public EmailContact(Email email, Name name)
            : base(name) 
        {
            Email = email;
        }

        public Email Email { get; private set; }
    }
}
