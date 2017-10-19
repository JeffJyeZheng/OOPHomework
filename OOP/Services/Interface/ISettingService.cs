using OOP.Models;

namespace OOP.Services
{
    /// <summary>
    /// 設定檔 service
    /// </summary>
    public interface ISettingService
    {
        /// <summary>
        /// 取得 config
        /// </summary>
        /// <returns>ConfigManager</returns>
        ConfigManager GetConfig();

        /// <summary>
        /// 取得 schedule
        /// </summary>
        /// <returns>ScheduleManager</returns>
        ScheduleManager GetSchedule();
    }
}