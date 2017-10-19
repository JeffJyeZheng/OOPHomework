namespace OOP.Services
{
    /// <summary>
    /// 應用程式
    /// </summary>
    public class Application : IApplication
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="settingServic">注入 SettingService</param>
        public Application(ISettingService settingServic)
        {
            this.SettingServic = settingServic;
        }

        /// <summary>
        /// 設定檔 service
        /// </summary>
        private ISettingService SettingServic { get; }

        /// <summary>
        /// 應用程式開始
        /// </summary>
        public void Start()
        {
            var config = this.SettingServic.GetConfig();
            var schedule = this.SettingServic.GetSchedule();
        }
    }
}