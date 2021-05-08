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
    [Authorize]
    public class CharacterController : ApiController
    {
        public List<string> GetRaces()
        {
            List<string> result = new List<string>();
            result.Add("Human");
            result.Add("Orc");
            result.Add("Elf");
            result.Add("Halfling");
            result.Add("Goblin");
            result.Add("Dwarf");

            return result;
        }
        public List<string> GetSkills()
        {
            List<string> result = new List<string>();
            result.Add("Stregnth");
            result.Add("Dexterity");
            result.Add("Endurance");
            result.Add("Intellegence");
            result.Add("Agility");
            result.Add("");

            return result;
        }
        public List<string> GetPhysAttributes()
        {
            List<string> result = new List<string>();
            result.Add("Weight");
            result.Add("Height");
            result.Add("Hair Color");
            result.Add("Eye color");

            return result;
        }
        private CharacterService CreateCharacterService()
        {
            var characterService = new CharacterService();
            return characterService;
        }
        public IHttpActionResult Post(CharacterCreate character)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCharacterService();

            if (!service.CreateCharacter(character))
                return InternalServerError();

            return Ok();
        }
        public List<string> GetCharClasses()
        {
            List<string> result = new List<string>();
            result.Add("Fighter");
            result.Add("Mage");
            result.Add("Thief");
            result.Add("paladin");

            return result;
        }
    }
}
