using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Data;
using CharacterCreator.Models;

namespace CharacterCreator.Services
{
    public class TeamService
    {
        public bool CreateTeam(TeamCreate model)
        {
            var entity =
                new Team()
                {                    
                    TeamDescription = model.TeamDescription,
                    TeamName = model.TeamName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
