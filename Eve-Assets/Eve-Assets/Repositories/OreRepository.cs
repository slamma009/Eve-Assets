using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets
{
    public class OreRepository
    {
        public static List<Ore> GetAllOres()
        {
            DbContext db = new DbContext();
            var results = db.Ores
                .Include("Minerals.Mineral")
                .ToList<Ore>();
            return results;
        }
    }
}