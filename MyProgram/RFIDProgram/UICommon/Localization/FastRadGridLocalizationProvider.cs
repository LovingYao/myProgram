using Telerik.WinControls.UI.Localization;

namespace RFIDProgram
{
    //RadGridView本地化
    /// <summary>
    /// RadGridView本地化
    /// </summary>
    public class FastRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        //返回本地化字符串
        /// <summary>
        /// 返回本地化字符串
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.GroupingPanelDefaultMessage:
                    return "拖动列到这里进行分组";//Drag a column here to group by this column.
                case RadGridStringId.NoDataText:
                    return "没有数据可显示";//No data to display
                case RadGridStringId.GroupingPanelHeader:
                    return "分组：";//Group by:
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}