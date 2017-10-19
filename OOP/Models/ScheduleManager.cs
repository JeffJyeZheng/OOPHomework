using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class ScheduleManager
    {
        [JsonProperty(PropertyName = "schedules")]
        public List<Schedule> Schedules { get; set; }
    }
}
