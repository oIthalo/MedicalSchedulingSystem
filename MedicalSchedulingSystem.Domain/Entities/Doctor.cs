using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;
namespace MedicalSchedulingSystem.Domain.Entities;

public class Doctor : Entity
{
    private readonly IList<Specialty> _specialtys;

    public Doctor(Name name, IList<string> specialtys)
    {
        Name = name;
        _specialtys = new List<Specialty>();

        AddNotifications(name);
    }

    public Name Name { get; private set; }
    public IReadOnlyCollection<Specialty> Specialtys { get { return _specialtys.ToArray(); } }
}