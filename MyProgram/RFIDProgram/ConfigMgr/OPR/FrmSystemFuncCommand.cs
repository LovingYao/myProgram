using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TelerikWinformBase;
using AutoMapper;


namespace RFIDProgram
{
    //功能命令管理
    /// <summary>
    /// 功能命令管理
    /// </summary>
    public partial class FrmSystemFuncCommand : FrmSimpleBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemFuncCommand()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemFuncCommand _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemFuncCommand Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemFuncCommand();
                }
                return _window;
            }
        }
        #endregion

        #region 私有方法

        //注册事件
        /// <summary>
        /// 注册事件
        /// </summary>
        private void RegistEvents()
        {
            FormClosed += FrmSystemFuncCommand_FormClosed;
            Shown += FrmSystemFuncCommand_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary
        private void QueryData()
        {
            Commands =
                DictionaryItemBll.QueryDictionaryItem(new QueryCondition
                                                          {
                                                              Code = DataDictionary.FunctionCommand.ToString(),
                                                              ReasonCategory = DictionaryCategory.Dictionary.ToString()
                                                          });
            gridViewCommand.DataSource = Commands;

            Functions = RightFunctionBll.QueryAll();
            IsCheckNeedSave = false;
            gridViewFunc.DataSource = Functions;
            IsCheckNeedSave = true;
        }

        //初始化功能命令关系
        /// <summary>
        /// 初始化功能命令关系
        /// </summary>
        private void InitFuncCommands(RightFunction rightFunction)
        {
            if (rightFunction == null)
                return;

            var list =
                RightLkFunctionCommandBll.QueryRightLkFunctionCommand(new QueryCondition { Resv01 = rightFunction.Sysid });
            gridViewCommand.ValueChanging -= gridViewCommand_ValueChanging;

            _commandsInDb = new List<DictionaryItem>();
            foreach (var row in gridViewCommand.Rows)
            {
                var command = row.DataBoundItem as DictionaryItem;
                if (command == null)
                    continue;

                var isChecked = list.FindAll(p => p.CommandSysid == command.Sysid).Count > 0;
                if (isChecked)
                {
                    var copiedCommand = Mapper.Map<DictionaryItem, DictionaryItem>(command);
                    _commandsInDb.Add(copiedCommand);
                }
                row.Cells[0].Value = isChecked;
            }

            gridViewCommand.ValueChanging += gridViewCommand_ValueChanging;
        }

        //用编辑框数据填充实体
        /// <summary>
        /// 用编辑框数据填充实体
        /// </summary>
        private List<RightLkFunctionCommand> BuildEntity(out List<RightLkFunctionCommand> deleteList)
        {
            var insertlist = new List<RightLkFunctionCommand>();
            deleteList = new List<RightLkFunctionCommand>();
            var rightFunction = gridViewFunc.SelectedRows[0].DataBoundItem as RightFunction;
            if (rightFunction == null)
                return insertlist;

            foreach (var row in gridViewCommand.Rows)
            {
                var command = row.DataBoundItem as DictionaryItem;
                if (command == null)
                    continue;

                var rightLkFunctionCommand = new RightLkFunctionCommand
                                                 {
                                                     CommandSysid = command.Sysid,
                                                     FunctionSysid = rightFunction.Sysid
                                                 };
                var isInDbChecked = _commandsInDb.FindAll(p => p.Sysid == command.Sysid).Count > 0;
                var value = row.Cells[0].Value;
                if (value == null || value.ToString().ToLower() == "false")
                {
                    if (isInDbChecked)
                        deleteList.Add(rightLkFunctionCommand);
                    continue;
                }
                if (!isInDbChecked)
                    insertlist.Add(rightLkFunctionCommand);
            }
            return insertlist;
        }

        #endregion

        #region 属性

        //上一次选中的功能的索引
        /// <summary>
        /// 上一次选中的功能的索引
        /// </summary>
        private int LastSelectedFuncIndex { get; set; }

        private bool IsCheckNeedSave { get; set; }

        //功能列表
        /// <summary>
        /// 功能列表
        /// </summary>
        private List<RightFunction> Functions { get; set; }

        //命令列表
        /// <summary>
        /// 命令列表
        /// </summary>
        private List<DictionaryItem> Commands { get; set; }

        //已选择的命令列表
        /// <summary>
        /// 已选择的命令列表
        /// </summary>
        private List<DictionaryItem> _commandsInDb;

        #endregion

        #region 窗体事件

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFuncCommand_Shown(object sender, EventArgs e)
        {
            Text = "功能命令设置";
            LastSelectedFuncIndex = -1;
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFuncCommand_FormClosed(object sender, FormClosedEventArgs e)
        {
            _window = null;
        }

        #endregion

        #region 其他事件

        //功能选中
        /// <summary>
        /// 功能选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewFunc_SelectionChanged(object sender, EventArgs e)
        {
            if (LastSelectedFuncIndex == -1)
                LastSelectedFuncIndex = gridViewFunc.SelectedRows[0].Index;

            if (IsCheckNeedSave && CurrentOperationStatus != OperationStatus.Default &&
                !UI.Confirm("有数据未保存，继续将丢失，是否继续？"))
            {
                gridViewFunc.SelectionChanged -= gridViewFunc_SelectionChanged;
                gridViewFunc.Rows[LastSelectedFuncIndex].IsCurrent = true;
                gridViewFunc.SelectionChanged += gridViewFunc_SelectionChanged;
                return;
            }
            InitFuncCommands(gridViewFunc.SelectedRows[0].DataBoundItem as RightFunction);
            LastSelectedFuncIndex = gridViewFunc.SelectedRows[0].Index;
            CurrentOperationStatus = OperationStatus.Default;
        }

        //命令选中
        /// <summary>
        /// 命令选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewCommand_ValueChanging(object sender, ValueChangingEventArgs e)
        {
            CurrentOperationStatus = OperationStatus.Edit;
        }

        #endregion

        #region CommandBar 事件

        //保存数据
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        internal override bool Submit()
        {
            if (CurrentOperationStatus == OperationStatus.Default)
                return false;

            List<RightLkFunctionCommand> deleteList;
            var insertlist = BuildEntity(out deleteList);
            var rightFunction = gridViewFunc.SelectedRows[0].DataBoundItem as RightFunction;
            if (rightFunction == null)
                return false;

            var result = RightLkFunctionCommandBll.Save(insertlist, deleteList);

            string msg;
            if (result)
            {
                msg = "保存成功";
                CurrentOperationStatus = OperationStatus.Default;
            }
            else
            {
                msg = "保存失败";
                CurrentOperationStatus = OperationStatus.Edit;
            }
            UI.ShowInfo(msg);
            return result;
        }

        //查询数据
        /// <summary>
        /// 查询数据
        /// </summary>
        internal override bool Query()
        {
            if (CurrentOperationStatus != OperationStatus.Default &&
                !UI.Confirm("有数据未保存，继续查询将丢失，是否继续？"))
                return false;

            QueryData();
            return true;
        }

        #endregion
    }
}