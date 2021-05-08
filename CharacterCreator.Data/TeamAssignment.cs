using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public class TeamAssignment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        //[ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        //public virtual Character Character { get; set; }
    }
}
