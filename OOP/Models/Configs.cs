using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Configs
    {
        [JsonProperty(PropertyName = "configs")]
        public List<Config> ConfigList { get; set; }
    }
}
