using CharacterCreator.Data;
using CharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Services
{
    public class CharacterService
    {
        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {
                    Name = model.Name,
                    Age = model.Age,
                    History = model.History
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
