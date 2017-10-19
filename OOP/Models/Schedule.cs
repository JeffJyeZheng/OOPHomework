using Newtonsoft.Json;
using OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Schedule
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

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "interval")]
        public string Interval { get; set; }
    }
}
