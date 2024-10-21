using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities;

public abstract class Contact : Entity
{
    public Contact(Name name)
    {
        Name = name;

        AddNotifications(name);
    }

    public Name Name { get; private set; }
}
