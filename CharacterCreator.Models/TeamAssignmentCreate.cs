using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class TeamAssignmentCreate
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int CharacterId { get; set; }
    }
}
