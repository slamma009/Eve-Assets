﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eve_Assets.Models
{
    public class Character
    {
        public string CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string CorpName { get; set; }
        public string ApiKey { get; set; }
        public string ApiCode { get; set; }
    }
}