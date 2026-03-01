using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class Customer : Entity, IAggregateRoot
    {
        public string FullName { get; set; } = string.Empty; 
        public DateTime BirthDate { get; set; }            
        public decimal LoyaltyDiscount { get; set; }        

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
