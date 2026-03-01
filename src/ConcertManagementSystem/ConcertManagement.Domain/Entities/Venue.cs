using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{

    public class Venue : Entity, IAggregateRoot
    {
        public string Name { get; set; } = string.Empty;    
        public string Address { get; set; } = string.Empty; 
        public int Capacity { get; set; }                   
        public int TotalSeats { get; set; }                 
        public int TotalRows { get; set; }                  

        public virtual ICollection<Concert> Concerts { get; set; } = new List<Concert>();
    }
}