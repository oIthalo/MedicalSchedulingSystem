namespace MedicalSchedulingSystem.Domain.ValueObjects
{
    public class Number
    {
        public Number(string contactNumber)
            =>    ContactNumber = contactNumber;

        public string ContactNumber { get; private set; }
    }
}
