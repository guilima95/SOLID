using SOLID.DIP.Before.ValueObjects;
using System;
namespace SOLID.DIP.Before.Models
{
    public class Client
    {
        public Guid Id => Guid.NewGuid();
        public string Name { get; set; } = null!;
        public Email? Email { get; set; }
        public DateTime Date { get; set; }

        public bool IsValid()
        {
            if (Email is null)
            {
                return false;
            }

            return Email.Valid();
        }
    }
}