using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class GroupParticipant : Entity
    {
        public int GroupId { get; set; }
        public virtual Group Group { get; set; } = null!;
        public int MemberId { get; set; }
        public virtual Member Member { get; set; } = null!;
    }
}
