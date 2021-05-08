﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharacterCreator.WebAPI.Controllers
{
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
    }
}