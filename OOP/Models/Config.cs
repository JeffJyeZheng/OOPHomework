using Newtonsoft.Json;
using OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace OOP.Models
{
    public class Config
    {
        [JsonProperty(PropertyName = "ext")]
        private string _Ext
        {
            set
            {
                var ext = value.ToLower();
                this.Ext = (FileType)Enum.Parse(typeof(FileType), ext);
            }
        }

        public FileType Ext { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "subDirectory")]
        public bool SubDirectory { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName = "remove")]
        public bool Remove { get; set; }

        [JsonProperty(PropertyName = "handler")]
        public string Handler { get; set; }

        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }

        [JsonProperty(PropertyName = "dir")]
        public string Dir { get; set; }

        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
    }
}
