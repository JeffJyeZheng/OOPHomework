using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class ConfigManager
    {
        [JsonProperty(PropertyName = "configs")]
        public List<Config> Configs { get; set; }
    }
}
