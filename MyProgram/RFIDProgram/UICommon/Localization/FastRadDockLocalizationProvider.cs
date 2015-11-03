using Telerik.WinControls.UI.Localization;

namespace RFIDProgram
{
    //RadDock本地化
    /// <summary>
    /// RadDock本地化
    /// </summary>
    public class FastRadDockLocalizationProvider : RadDockLocalizationProvider
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
                case RadDockStringId.ContextMenuCancel:
                    return "取消";
                case RadDockStringId.ContextMenuFloating:
                    return "浮动";
                case RadDockStringId.ContextMenuDockable:
                    return "可停靠";
                case RadDockStringId.ContextMenuTabbedDocument:
                    return "选项卡式文档";
                case RadDockStringId.ContextMenuAutoHide:
                    return "自动隐藏";
                case RadDockStringId.ContextMenuHide:
                    return "隐藏";
                case RadDockStringId.ContextMenuClose:
                    return "关闭";
                case RadDockStringId.ContextMenuCloseAll:
                    return "关闭所有";
                case RadDockStringId.ContextMenuCloseAllButThis:
                    return "除此之外全部关闭";
                case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
                    return "移动到上一个选项卡组";
                case RadDockStringId.ContextMenuMoveToNextTabGroup:
                    return "移动到下一个选项卡组";
                case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                    return "新建水平选项卡组";
                case RadDockStringId.ContextMenuNewVerticalTabGroup:
                    return "新建垂直选项卡组";
                case RadDockStringId.ToolTabStripCloseButton:
                    return "关闭窗口";
                case RadDockStringId.ToolTabStripDockStateButton:
                    return "窗口状态";
                case RadDockStringId.ToolTabStripUnpinButton:
                    return "自动隐藏";
                case RadDockStringId.ToolTabStripPinButton:
                    return "停靠";
                case RadDockStringId.DocumentTabStripCloseButton:
                    return "关闭文档";
                case RadDockStringId.DocumentTabStripListButton:
                    return "激活文档";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}