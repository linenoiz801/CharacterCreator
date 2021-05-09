using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class CharacterAttributesCreate
    {
        public int Id { get; set; }
        public string Attribute { get; set; }        
        public string Value { get; set; }        
        public bool IsPhysical { get; set; }
    }
}
