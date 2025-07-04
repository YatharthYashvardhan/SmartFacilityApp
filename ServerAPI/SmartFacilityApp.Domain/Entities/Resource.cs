using SmartFacilityApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SmartFacilityApp.Domain.Entities
{
    public class Resource
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }                // e.g. "Room A"
        public string? Description { get; set; }         // e.g. "Large meeting room"
        public ResourceTypes Type { get; set; }          // Enum: Room, Parking, etc.
        public int Capacity { get; set; }               // Optional: e.g. number of people
        public bool IsActive { get; set; }
    }
}
