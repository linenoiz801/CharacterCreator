using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Data
{
    public class CharacterAttributes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Attribute { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public bool IsPhysical { get; set; }
    }
}
