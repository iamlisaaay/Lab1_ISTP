using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class Ticket : Entity
    {
        public int SeatNumber { get; set; } 
        public int RowNumber { get; set; }  
        public decimal Price { get; set; } 
        public string Status { get; set; } = string.Empty;

        public int ConcertId { get; set; }
        public virtual Concert Concert { get; set; } = null!;

        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}