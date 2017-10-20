using Newtonsoft.Json;
using OOP.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using OOP.Models;

namespace OOP
{
    public class ConfigManager
    {
        public List<Config> Configs { get; set; }

        public int Count { get; set; }

        public void ProcessConfigs()
        {
            var path = GlobalConstant.SourcePath + "\\config.json";
            var json = FileHelper.Read(path);
            var configs = JsonConvert.DeserializeObject<Configs>(json);

            this.Configs = configs.ConfigList;
            this.Count = Configs.Count;
        }

    }
}
