﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Models
{
    public class MineralsRefined
    {
        public int Id { get; set; }

        public Mineral Mineral { get; set; }

        public int Amount { get; set; }

        public Ore Source { get; set; }
    }
}