namespace MedicalSchedulingSystem.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Guid Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
