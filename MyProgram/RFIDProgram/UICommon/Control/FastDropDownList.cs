using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using Telerik.WinControls;
using TelerikWinformBase;
using AutoMapper;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FastDropDownList : RadDropDownList
    {
        public FastDropDownList()
        {
            InitializeComponent();
            InitCustom();
        }

        [Browsable(true)]
        [Description("用途【只有当ReferenceDropDownList为空的时候有效】")]
        [Category("Custom")]
        public FastDropDownListUsageFor UsageFor { get; set; }

        [Browsable(true)]
        [Description("是否包含空项目")]
        [Category("Custom")]
        public bool ContainEmptyItem { get; set; }

        [Browsable(true)]
        [Description("字典编号【只有当ReferenceDropDownList为空并且UsageFor为DictionaryItem时有效】")]
        [Category("Custom")]
        public DataDictionary DictionaryCode { get; set; }

        [Browsable(true)]
        [Description("引用数据源FastDropDownList")]
        [Category("Custom")]
        public FastDropDownList ReferenceDropDownList { get; set; }

        [Browsable(false)]
        public QueryCondition QueryCondition { get; set; }

        public T GetSelectedObject<T>()
        {
            if (SelectedItem == null)
                return default(T);

            return (T)SelectedItem.DataBoundItem;
        }

        private void InitCustom()
        {
            Size = new Size(180, Height);
            ThemeClassName = "Telerik.WinControls.UI.RadDropDownList";
            DropDownStyle = RadDropDownStyle.DropDownList;
        }

        //刷新数据源
        /// <summary>
        /// 刷新数据源
        /// </summary>
        public void RefreshDataSource()
        {
            var usageFor = UsageFor;
            if (ReferenceDropDownList != null)
                usageFor = ReferenceDropDownList.UsageFor;

            switch (usageFor)
            {
                case FastDropDownListUsageFor.DictionaryItem:
                    BindingDictionaryItem();
                    break;
                case FastDropDownListUsageFor.Dictionary:
                    BindingDictionary();
                    break;
                case FastDropDownListUsageFor.UserGroup:
                    BindingUserGroup();
                    break;
                case FastDropDownListUsageFor.FunctionGroup:
                    BindingFunctionGroup();
                    break;
                case FastDropDownListUsageFor.ReasonCategory:
                    BindingReasonCategory();
                    break;
                case FastDropDownListUsageFor.ReasonCode:
                    BindingReasonCode();
                    break;
                default:
                    break;
            }
        }

        private void BindingDictionaryItem()
        {
            List<DictionaryItem> list;

            if (QueryCondition == null)
                QueryCondition = new QueryCondition();
            QueryCondition.Code = DictionaryCode.ToString();
            QueryCondition.ReasonCategory = DictionaryCategory.Dictionary.ToString();

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<DictionaryItem>, List<DictionaryItem>>
                    ((List<DictionaryItem>)ReferenceDropDownList.DataSource);
            else
                list = DictionaryItemBll.QueryDictionaryItem(QueryCondition);

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new DictionaryItem { Code = "", Name = "" });
            }

            UI.BindingDropDownList(this, list, "Name", "Code");
        }

        private void BindingDictionary()
        {
            List<DictionaryInfo> list;

            const string owner = "";//TODO:正式上线后，这里改为 “owner = "U";”

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<DictionaryInfo>, List<DictionaryInfo>>
                    ((List<DictionaryInfo>)ReferenceDropDownList.DataSource);
            else
                list = DictionaryInfoBll.QueryAll(DictionaryCategory.Dictionary, owner);

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new DictionaryInfo { Code = "", Name = "" });
            }

            UI.BindingDropDownList(this, list, "Name", "Code");
        }

        private void BindingReasonCode()
        {
            List<DictionaryItem> list;

            if (QueryCondition == null)
                QueryCondition = new QueryCondition();
            QueryCondition.ReasonCategory = DictionaryCategory.ReasonCode.ToString();

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<DictionaryItem>, List<DictionaryItem>>
                    ((List<DictionaryItem>)ReferenceDropDownList.DataSource);
            else
                list = DictionaryItemBll.QueryDictionaryItem(QueryCondition);

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new DictionaryItem { Code = "", Name = "" });
            }

            UI.BindingDropDownList(this, list, "Name", "Code");
        }

        private void BindingReasonCategory()
        {
            List<DictionaryInfo> list;

            const string owner = "U";

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<DictionaryInfo>, List<DictionaryInfo>>
                    ((List<DictionaryInfo>)ReferenceDropDownList.DataSource);
            else
                list = DictionaryInfoBll.QueryAll(DictionaryCategory.ReasonCode, owner);

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new DictionaryInfo { Code = "", Name = "" });
            }

            UI.BindingDropDownList(this, list, "Name", "Code");
        }

        private void BindingFunctionGroup()
        {
            List<RightFunctionGroup> list;

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<RightFunctionGroup>, List<RightFunctionGroup>>
                    ((List<RightFunctionGroup>)ReferenceDropDownList.DataSource);
            else
                list = RightFunctionGroupBll.QueryAll();

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new RightFunctionGroup { GroupName = "", Sysid = "" });
            }

            UI.BindingDropDownList(this, list, "GroupName", "Sysid");
        }

        private void BindingUserGroup()
        {
            List<RightUserGroup> list;

            if (ReferenceDropDownList != null)
                list = Mapper.Map<List<RightUserGroup>, List<RightUserGroup>>
                    ((List<RightUserGroup>)ReferenceDropDownList.DataSource);
            else
                list = RightUserGroupBll.QueryAll();

            if (ContainEmptyItem)
            {
                if (ReferenceDropDownList == null ||
                    (ReferenceDropDownList != null && !ReferenceDropDownList.ContainEmptyItem))
                    list.Insert(0, new RightUserGroup { GroupName = "", Sysid = "" });
            }

            UI.BindingDropDownList(this, list, "GroupName", "Sysid");
        }
    }
}