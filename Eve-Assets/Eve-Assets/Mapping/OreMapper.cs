using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eve_Assets.Models.Domain;
using Eve_Assets.Accessors;

namespace Eve_Assets.Mapping
{
    public static class OreMapper
    {
        public static IEnumerable<Ore> GetAllOres()
        {

            var allEnterpriseOres = OreAccessor.GetAllOres();
            List<Ore> allOres = new List<Ore>();
            foreach (Eve_Assets.Models.Enterprise.Ore ore in allEnterpriseOres)
            {
                allOres.Add(new Ore(ore));
            }

            return allOres;
        }
    }
}