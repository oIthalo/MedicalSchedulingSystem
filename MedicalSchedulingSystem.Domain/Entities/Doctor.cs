using MedicalSchedulingSystem.Domain.ValueObjects;
using MedicalSchedulingSystem.Shared.Entities;
namespace MedicalSchedulingSystem.Domain.Entities;

public class Doctor : Entity
{
    private readonly IList<Especialty> _specialtys;

    public Doctor(string name, IList<string> specialtys)
    {
        Name = name;
        _specialtys = new List<Especialty>();
    }

    public string Name { get; private set; }
    public IReadOnlyCollection<Especialty> Specialtys { get { return _specialtys.ToArray(); } }
}