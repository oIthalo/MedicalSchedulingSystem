using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class Especialty : Entity
    {
        public Especialty(Name name)
        {
            Name = name;

            AddNotifications(name);
        }

        public Name Name { get; private set; }
    }
}