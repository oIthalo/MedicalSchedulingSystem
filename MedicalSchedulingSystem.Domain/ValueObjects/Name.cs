using Flunt.Validations;
using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                // first name validation
                .IsNotNullOrEmpty(FirstName, "Name.FirstName", "Nome não pode estar vazio")
                .IsGreaterOrEqualsThan(FirstName.Length, 3, "Name.FirstName", "O nome deve ter mais de 3 caracteres")
                // last name validation
                .IsNotNullOrEmpty(LastName, "Name.LastName", "O sobrenome não pode estar vazio")
                .IsGreaterOrEqualsThan(LastName.Length, 3, "Name.LastName", "O sobrenome deve ter pelo menos 3 caracteres"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
