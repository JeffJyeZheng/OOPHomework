using Newtonsoft.Json;
using OOP.Helper;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Services
{
    public class ScheduleManager
    {
        public List<Schedule> Schedules { get; set; }

        public int Count { get; set; }

        public void PrecessSchedule()
        {
            var path = GlobalConstant.SourcePath + "\\schedule.json";
            var json = FileHelper.Read(path);
            var configs = JsonConvert.DeserializeObject<Schedules>(json);

            this.Schedules = configs.ScheduleList;
            this.Count = this.Schedules.Count;
        }
    }
}
