using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Models.Domain
{
    public class Ore
    {
        public int OreId { get; set; }

        public string Name { get; set; }

        public int RefineAmount { get; set; }

        public Mineral[] Minerals { get; set; }

        public Ore()
        {

        }

        public Ore(Eve_Assets.Models.Enterprise.Ore ore)
        {
            this.OreId = ore.OreId;
            this.Name = ore.Name;
            this.RefineAmount = ore.RefineAmount;
        }
    }
}