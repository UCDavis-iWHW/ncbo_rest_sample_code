﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ncbo.DataTypes
{
    public class PageLinks
    {
        [JsonProperty("nextPage")]
        public string NextPageUrl { get; set; }
        [JsonProperty("prevPage")]
        public string PrevPageUrl { get; set; }
    }
}
