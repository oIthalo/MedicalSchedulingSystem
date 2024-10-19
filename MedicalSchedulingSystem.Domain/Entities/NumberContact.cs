using MedicalSchedulingSystem.Domain.ValueObjects;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class NumberContact : Contact
    {
        public NumberContact(Number number, Name name)
            : base (name)
        {
            Number = number;
        }

        public Number Number { get; private set; }
    }
}
