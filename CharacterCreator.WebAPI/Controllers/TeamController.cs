using CharacterCreator.Models;
using CharacterCreator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharacterCreator.WebAPI.Controllers
{
    public class TeamController : ApiController
    {
        private TeamService CreateTeamService()
        {
            var teamService = new TeamService();
            return teamService;
        }
        public IHttpActionResult Post(TeamCreate team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTeamService();

            if (!service.CreateTeam(team))
                return InternalServerError();

            return Ok();
        }
    }
}
