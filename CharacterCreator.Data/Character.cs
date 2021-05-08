using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        // [ForeignKey(nameof(PhysicalAttributes))]
        //public int PhysicalAttributesId {get; set;}
        //public virtual PhysicalAttribute PhysicalAttributes {get; set;}

        //[ForeignKey(nameof(Skills))]
        //public int SkillsId {get; set}
        //public virtual Skill Skills {get; set;}

        //public enum Race TypeOfRace {get; set}
        //public enum Skill TypeOfSkill {get;set;}
        
        [Required]
        public string History { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
