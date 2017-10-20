using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Schedules
    {
        [JsonProperty(PropertyName = "schedules")]
        public List<Schedule> ScheduleList { get; set; }
    }
}
