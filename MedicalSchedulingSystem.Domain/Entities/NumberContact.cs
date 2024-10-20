﻿using MedicalSchedulingSystem.Domain.ValueObjects;

namespace MedicalSchedulingSystem.Domain.Entities
{
    public class NumberContact : Contact
    {
        public NumberContact(ContactNumber number, Name name)
            : base (name)
        {
            Number = number;
        }

        public ContactNumber Number { get; private set; }
    }
}
