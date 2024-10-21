using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects;

public class ContactNumber : ValueObject
{
    public ContactNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;

        AddNotifications(new Contract<ContactNumber>()
            .Requires()
            .IsNotNullOrEmpty(PhoneNumber, "Number.PhoneNumber", "Número de contato inválido")
            .Matches(PhoneNumber, @"^\(?\d{2}\)?[\s-]?\d{4,5}[\s-]?\d{4}$", "Number.PhoneNumber", "Número de contato inválido"));
    }

    public string PhoneNumber { get; private set; }
}
