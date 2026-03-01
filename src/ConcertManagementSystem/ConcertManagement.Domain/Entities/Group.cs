using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertManagement.Domain.Entities
{

    public class Group : Entity, IAggregateRoot
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public string LogoUrl { get; set; } = string.Empty;
        public string BgVideoUrl { get; set; } = string.Empty;
        public string FanClubUrl { get; set; } = string.Empty;

        public virtual ICollection<GroupParticipant> GroupParticipants { get; set; } = new List<GroupParticipant>();
        public virtual ICollection<ConcertGroup> ConcertGroups { get; set; } = new List<ConcertGroup>();
    }
}