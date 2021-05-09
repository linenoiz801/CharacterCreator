using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class CharacterCreate
    {
        public int PhysicalAttributesId {get; set;}
        public int SkillsId { get; set; }
        public string History { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public List<string> Race {get; set}
        //public List<string> Skill {get;set;}
    }
}
