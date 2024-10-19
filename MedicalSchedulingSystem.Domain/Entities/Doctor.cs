using MedicalSchedulingSystem.Shared.Entities;
namespace MedicalSchedulingSystem.Domain.Entities;

public class Doctor : Entity
{
    private readonly IList<string> _specialtys;

    public Doctor(string name, IList<string> specialtys)
    {
        Name = name;
        _specialtys = new List<string>();
    }

    public string Name { get; private set; }
    public IReadOnlyCollection<string> Specialtys { get { return _specialtys.ToArray(); } }
}