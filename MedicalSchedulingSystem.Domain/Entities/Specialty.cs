using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;

namespace MedicalSchedulingSystem.Domain.Entities;

public class Specialty : Entity
{
    public Specialty(Name name)
    {
        Name = name;

        AddNotifications(name);
    }

    public Name Name { get; private set; }
}