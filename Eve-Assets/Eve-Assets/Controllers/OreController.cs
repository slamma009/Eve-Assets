using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Eve_Assets.Controllers
{
    public class OreController : ApiController
    {
        [HttpGet, Route("api/ore/getAllOres")]
        public IEnumerable<Ore> GetAllOres()
        {
            List<Ore> ores = new List<Ore>();
            var ore = new Ore();
            ore.Name = "Veldspar";
            ores.Add(ore);

            ore = new Ore();
            ore.Name = "Pyroxeres";
            ores.Add(ore);

            ore = new Ore();
            ore.Name = "Scordite";
            ores.Add(ore);

            ores = OreRepository.GetAllOres();
            return ores;
        }
    }
}