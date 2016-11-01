using Eve_Assets.Models.Enterprise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Accessors
{
    public static class OreAccessor
    {
        public static IEnumerable<Ore> GetAllOres()
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
            return ores;
        }
    }
}