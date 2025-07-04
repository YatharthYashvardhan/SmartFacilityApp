using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFacilityApp.Domain.Entities
{
    public class Bookings
    {
        public Guid Id { get; set; }

        // Foreign Key to User
        public Guid UserId { get; set; }
        public User? User { get; set; }

        // Foreign Key to Resource
        public Guid ResourceId { get; set; }
        public Resource? Resource { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public BookingStatus Status { get; set; }
    }
}
