﻿using Eve_Assets.Mapping;
using Eve_Assets.Models.Domain;
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
            var ores = OreMapper.GetAllOres();
            return ores;
        }
    }
}