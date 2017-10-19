using Newtonsoft.Json;
using OOP.Helper;
using OOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Services
{
    public class SettingService : ISettingService
    {
        /// <summary>
        /// 取得 config
        /// </summary>
        /// <returns></returns>
        public ConfigManager GetConfig()
        {
            var path = GlobalConstant.SourcePath + "\\config.json";
            var configs = this.ReadJsonFile<ConfigManager>(path);

            return configs;
        }

        /// <summary>
        /// 取得 schedule
        /// </summary>
        /// <returns></returns>
        public ScheduleManager GetSchedule()
        {
            var path = GlobalConstant.SourcePath + "\\schedule.json";
            var schedule = this.ReadJsonFile<ScheduleManager>(path);

            return schedule;
        }

        private T ReadJsonFile<T>(string path)
        {
            var json = FileHelper.Read(path);
            var configs = JsonConvert.DeserializeObject<T>(json);

            return configs;
        }

    }
}
