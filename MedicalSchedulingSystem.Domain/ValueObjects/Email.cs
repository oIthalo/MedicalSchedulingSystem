using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string email)
    {
        EmailAddress = email;

        AddNotifications(new Contract<Email>()
            .Requires()
            .IsNotNullOrEmpty(EmailAddress, "Email.EmailAdress", "Email não pode estar vazio")
            .IsEmail(EmailAddress, "Email.EmailAdress", "Email inválido"));
    }

    public string EmailAddress { get; private set; }
}
