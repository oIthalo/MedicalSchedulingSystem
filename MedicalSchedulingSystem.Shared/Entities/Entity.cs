using Flunt.Notifications;

namespace MedicalSchedulingSystem.Shared.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        public Entity()
        {
            Guid Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
