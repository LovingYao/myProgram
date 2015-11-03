using Telerik.WinControls;
using Telerik.WinControls.Localization;
using Telerik.WinControls.UI.Localization;

namespace RFIDProgram
{
    //本地化管理
    /// <summary>
    /// 本地化管理
    /// </summary>
    public static class LocalizationManager
    {
        //初始化本地化
        /// <summary>
        /// 初始化本地化
        /// </summary>
        public static void InitLocalization()
        {
            //RadMessageBox按钮文字中文化
            LocalizationProvider<RadMessageLocalizationProvider>.CurrentProvider =
                new FastRadMessageLocalizationProvider();
            //RadDock本地化
            LocalizationProvider<RadDockLocalizationProvider>.CurrentProvider =
                new FastRadDockLocalizationProvider();
            //RadGridView本地化
            LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider =
                new FastRadGridLocalizationProvider();
        }
    }
}