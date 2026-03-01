using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{
    public class ConcertGroup : Entity
    {
        public int ConcertId { get; set; }
        public virtual Concert Concert { get; set; } = null!;
        public int GroupId { get; set; }
        public virtual Group Group { get; set; } = null!;
    }
}
