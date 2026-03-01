using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class Member : Entity
    {
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public virtual ICollection<GroupParticipant> GroupParticipants { get; set; } = new List<GroupParticipant>();
    }
}