using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Models
{
    public class Ore
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RefineAmount { get; set; }
        
        public ICollection<MineralsRefined> Minerals { get; set; }
    }
}