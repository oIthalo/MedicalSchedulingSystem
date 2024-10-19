namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class BirthDate
    {
        public BirthDate(DateTime birthDate_)
            =>   BirthDate_ = birthDate_;

        public DateTime BirthDate_ { get; private set; }
    }
}
