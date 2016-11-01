using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Models.Enterprise
{
    public class Ore
    {
        public int OreId { get; set; }

        public string Name { get; set; }

        public int RefineAmount { get; set; }

        public int MineralRefineId { get; set; }
    }
}