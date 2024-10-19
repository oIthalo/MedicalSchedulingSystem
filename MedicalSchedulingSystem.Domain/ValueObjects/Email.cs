namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Email
    {
        public Email(string email)
            => EmailAddress = email;

        public string EmailAddress { get; private set; }
    }
}
