using Telerik.WinControls;

namespace RFIDProgram
{
    //RadMessageBox本地化
    /// <summary>
    /// RadMessageBox本地化
    /// </summary>
    public class FastRadMessageLocalizationProvider : RadMessageLocalizationProvider
    {
        //显示本地化文字
        /// <summary>
        /// 显示本地化文字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton:
                    return "终止";
                case RadMessageStringID.CancelButton:
                    return "取消";
                case RadMessageStringID.IgnoreButton:
                    return "忽略";
                case RadMessageStringID.NoButton:
                    return "否";
                case RadMessageStringID.OKButton:
                    return "确定";
                case RadMessageStringID.RetryButton:
                    return "重试";
                case RadMessageStringID.YesButton:
                    return "是";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}