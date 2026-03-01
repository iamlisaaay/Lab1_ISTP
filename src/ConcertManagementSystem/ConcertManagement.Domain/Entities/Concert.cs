using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class Concert : Entity, IAggregateRoot
    {
        public string Name { get; set; } = string.Empty; 
        public DateTime DateTime { get; set; }        

        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public virtual ICollection<ConcertGroup> ConcertGroups { get; set; } = new List<ConcertGroup>();
    }
}