using OOP.Models;
using System.Linq;

namespace OOP.Services
{
    /// <summary>
    /// 應用程式
    /// </summary>
    public class Application : IApplication
    {
        /// <summary>
        /// 應用程式開始
        /// </summary>
        public void Start()
        {
            var configManager = new ConfigManager();
            configManager.ProcessConfigs();

            var scheduleManager = new ScheduleManager();
            scheduleManager.PrecessSchedule();
        }
    }
}