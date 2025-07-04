using SmartFacilityApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFacilityApp.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }

        public RoleType Role { get; set; }

        public ICollection<Bookings>? Bookings { get; set; }
    }
}
