using MedicalSchedulingSystem.Shared.ValueObjects;

namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Especialty : ValueObject
    {
        public Especialty(Name name)
            =>  Name = name;

        public Name Name { get; private set; }
    }
}