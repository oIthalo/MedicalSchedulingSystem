using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects;

public class BirthDate : ValueObject
{
    public BirthDate(DateTime birthDate)
    {
        Date = birthDate;

        AddNotifications(new Contract<BirthDate>()
            .Requires()
            .IsLowerThan(Date, DateTime.Now, "BirthDate.Date", "A data de nascimento deve ser anterior a data atual"));
    }

    public DateTime Date { get; private set; }
}
