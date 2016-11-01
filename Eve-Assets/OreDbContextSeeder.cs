using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets
{
    public class OreD
    {
        public static List<Ore> GetAllOres()
        {
            OreDbContext db = new OreDbContext();

            return db.Ores.ToList<Ore>();
        }
    }
}