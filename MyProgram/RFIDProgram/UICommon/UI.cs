using System;
using System.Collections.Generic;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.UI.Export;
using TelerikWinformBase;


namespace RFIDProgram
{
    /// <summary>
    /// UI帮助类
    /// </summary>
    public class UI
    {
        //绑定下拉框
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ddl">Telerik RadDropDownList</param>
        /// <param name="source">数据源对象列表</param>
        /// <param name="displayMember">显示的属性名称</param>
        /// <param name="valueMember">值的属性名称</param>
        public static void BindingDropDownList<T>(RadDropDownList ddl, List<T> source,
            string displayMember, string valueMember)
        {
            if (ddl.Items.Count > 0)
                ddl.Items.Clear();

            ddl.DisplayMember = displayMember;
            ddl.ValueMember = valueMember;
            ddl.DataSource = source;

            if (ddl.Items.Count > 0)
                ddl.SelectedIndex = 0;
        }

        //导出GridView数据到Excel中
        /// <summary>
        /// 导出GridView数据到Excel中
        /// </summary>
        /// <param name="grid">Telerik的RadGridView</param>
        /// <param name="sheetName">sheet页名称</param>
        //public static void ExportToExcel(RadGridView grid, string sheetName)
        //{
        //    var saveDialog = new SaveFileDialog
        //                         {
        //                             DefaultExt = "xls",
        //                             Filter = "Excel 文件|*.xls",
        //                             FileName = sheetName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xls"
        //                         };

        //    if (saveDialog.ShowDialog() != DialogResult.OK)
        //        return;

        //    var fileName = saveDialog.FileName;

        //    if (string.IsNullOrEmpty(fileName))
        //        return;

        //    try
        //    {
        //        var exporter = new  ExportToExcelML(grid)
        //                           {
        //                               ExportVisualSettings = true,
        //                               SheetMaxRows = ExcelMaxRows._1048576,
        //                               SheetName = sheetName
        //                           };
        //        exporter.RunExport(fileName);
        //        ShowInfo("导出成功");
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowInfo("导出时发生异常");
        //        Logger.LogError("导出" + sheetName + "时发生异常", ex);
        //    }
        //}

        //清空指定容器中的控件
        /// <summary>
        /// 清空指定容器中的控件
        /// </summary>
        /// <param name="container"></param>
        public static void ClearUi(System.Windows.Forms.Control container)
        {
            foreach (RadControl ctrl in container.Controls)
            {
                if (ctrl is RadButton)
                    continue;

                ClearCtrl(ctrl);

                continue;
            }
        }

        //清空指定容器中的控件
        /// <summary>
        /// 清空指定容器中的控件
        /// </summary>
        /// <param name="container"></param>
        /// <param name="exceptNames">不清空的控件名称</param>
        public static void ClearUi(System.Windows.Forms.Control container, List<string> exceptNames)
        {
            for (var i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i] is Button)
                    continue;

                if (container.Controls[i] is RadButton)
                    continue;

                var ctrl = (RadControl)container.Controls[i];
                if (exceptNames != null && exceptNames.Count > 0 && 
                    exceptNames.Find(p => p == ctrl.Name) != null)
                    continue;

                ClearCtrl(ctrl);
                continue;
            }
        }

        //清空控件
        /// <summary>
        /// 清空控件
        /// </summary>
        /// <param name="ctrl"></param>
        public static void ClearCtrl(RadControl ctrl)
        {
            if (ctrl is RadTextBox)
            {
                (ctrl as RadTextBox).Clear();
                return;
            }
            if (ctrl is RadDropDownList)
            {
                if ((ctrl as RadDropDownList).Items.Count > 0)
                {
                    (ctrl as RadDropDownList).SelectedIndex = 0;
                }
                return;
            }
            if (ctrl is RadMaskedEditBox)
            {
                if ((ctrl as RadMaskedEditBox).MaskType == MaskType.Numeric)
                {
                    (ctrl as RadMaskedEditBox).Value = "0";
                    return;
                }
                (ctrl as RadMaskedEditBox).Clear();
                return;
            }
        }

        //设置指定容器中控件只读
        /// <summary>
        /// 设置指定容器中控件只读
        /// </summary>
        /// <param name="container">容器</param>
        /// <param name="readOnly">是否只读</param>
        public static void ReadOnlyUi(System.Windows.Forms.Control container, bool readOnly)
        {
            foreach (RadControl ctrl in container.Controls)
            {
                if (!ctrl.Focusable)
                    continue;

                if (ctrl is RadTextBox)
                {
                    (ctrl as RadTextBox).ReadOnly = readOnly;
                    continue;
                }
                if (ctrl is RadDropDownList)
                {
                    (ctrl as RadDropDownList).Enabled = !readOnly;
                    continue;
                }
                if (ctrl is RadMaskedEditBox)
                {
                    (ctrl as RadMaskedEditBox).ReadOnly = readOnly;
                    continue;
                }
                if (ctrl is RadDateTimePicker)
                {
                    (ctrl as RadDateTimePicker).Enabled = !readOnly;
                    continue;
                }
                if (ctrl is RadCheckBox)
                {
                    (ctrl as RadCheckBox).Enabled = !readOnly;
                    continue;
                }
                if (ctrl is RadRadioButton)
                {
                    (ctrl as RadRadioButton).Enabled = !readOnly;
                    continue;
                }
                continue;
            }
        }

        public static void SetValue(RadControl ctrl, string value)
        {
            if (ctrl is RadTextBox)
            {
                (ctrl as RadTextBox).Text = value;
                return;
            }
            if (ctrl is RadMaskedEditBox)
            {
                (ctrl as RadMaskedEditBox).Value = value;
                return;
            }
            if (ctrl is RadDropDownList)
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim()))
                {
                    SetValueByText((ctrl as RadDropDownList), "");
                    return;
                }
                (ctrl as RadDropDownList).SelectedValue = value;
                return;
            }
            if (ctrl is RadCheckBox)
            {
                (ctrl as RadCheckBox).Checked = value == "1";
                return;
            }
            if (ctrl is RadDateTimePicker)
            {
                (ctrl as RadDateTimePicker).Value = Convert.ToDateTime(value);
                return;
            }
            return;
        }

        public static void SetValueByText(RadDropDownList ctrl, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                ctrl.Text = "";
                return;
            }
            foreach (RadListDataItem item in ctrl.Items)
            {
                if (item == null)
                    continue;

                if (item.Text == text)
                    item.Selected = true;
            }
        }

        public static string GetValue(RadControl ctrl)
        {
            if (ctrl is RadTextBox)
            {
                return (ctrl as RadTextBox).Text.Trim();
            }
            if (ctrl is RadMaskedEditBox)
            {
                return (ctrl as RadMaskedEditBox).Value == null
                           ? ""
                           : (ctrl as RadMaskedEditBox).Value.ToString().Trim();
            }
            if (ctrl is RadDropDownList)
            {
                return (ctrl as RadDropDownList).SelectedItem == null
                           ? ""
                           : (ctrl as RadDropDownList).SelectedValue.ToString().Trim();
            }
            if (ctrl is RadCheckBox)
            {
                return (ctrl as RadCheckBox).Checked ? "1" : "0";
            }
            return "";
        }

        public static string GetText(RadDropDownList ctrl)
        {
            return ctrl.Text.Trim();
        }

        //按指定格式读取日期
        /// <summary>
        /// 按指定格式读取日期
        /// </summary>
        /// <param name="dtp">RadDateTimePicker控件名</param>
        /// <param name="format">格式化字符串，为空时默认为yyyy-MM-dd HH:mm:ss</param>
        /// <returns></returns>
        public static string GetValue(RadDateTimePicker dtp, string format)
        {
            if (string.IsNullOrEmpty(format))
                format = "yyyy-MM-dd HH:mm:ss";

            return dtp.Value.ToString(format);
        }

        public static DateTime GetValue(RadDateTimePicker dtp)
        {
            return dtp.Value;
        }

        public static int GetInt(RadMaskedEditBox ctrl)
        {
            try
            {
                return int.Parse(ctrl.Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public static long GetLong(RadMaskedEditBox ctrl)
        {
            try
            {
                return long.Parse(ctrl.Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public static decimal GetDecimal(RadMaskedEditBox ctrl)
        {
            try
            {
                return decimal.Parse(ctrl.Value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        public static string GetUpperValue(RadControl ctrl)
        {
            return GetValue(ctrl).ToUpper();
        }

        public static string GetValue(System.Windows.Forms.Control container, string ctrlName)
        {
            foreach (RadControl ctrl in container.Controls)
            {
                if (ctrlName == ctrl.Name)
                    return GetValue(ctrl);
            }

            return "";
        }

        //判断指定控件的Text是否为空
        /// <summary>
        /// 判断指定控件的Text是否为空
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
        public static bool EmptyText(RadControl ctrl, string labelName)
        {
            if (ctrl is RadTextBox)
            {
                if (string.IsNullOrEmpty(ctrl.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(labelName))
                        ShowError(labelName + "不能为空");
                    ctrl.Focus();
                    return true;
                }
                return false;
            }
            if (ctrl is RadMaskedEditBox)
            {
                if ((ctrl as RadMaskedEditBox).MaskType == MaskType.Numeric)
                {
                    if (string.IsNullOrEmpty(GetValue(ctrl)) || Convert.ToDouble(GetValue(ctrl)) <= 0)
                    {
                        if (!string.IsNullOrEmpty(labelName))
                            ShowError(labelName + "不能为空");
                        ctrl.Focus();
                        return true;
                    }
                    return false;
                }
            }
            if (string.IsNullOrEmpty(ctrl.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(labelName))
                    ShowError(labelName + "不能为空");
                ctrl.Focus();
                return true;
            }

            return false;
        }

        //判断指定控件的值是否为0
        /// <summary>
        /// 判断指定控件的值是否为0
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="labelName"></param>
        /// <returns></returns>
        public static bool EqualsZero(RadMaskedEditBox ctrl, string labelName)
        {
            if (decimal.Parse(ctrl.Text.Trim()) == 0)
            {
                if (!string.IsNullOrEmpty(labelName))
                {
                    ShowError(labelName + "不能为零");
                }
                ctrl.Focus();
                return true;
            }

            return false;
        }

        //结束时间是否早于开始时间
        /// <summary>
        /// 结束时间是否早于开始时间
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="startLabelName"></param>
        /// <param name="endLabelName"></param>
        /// <returns></returns>
        public static bool EarlyTime(DateTime start, DateTime end,
            string startLabelName, string endLabelName)
        {
            if (end < start)
            {
                ShowError(endLabelName + "不能小于" + startLabelName);
                return true;
            }

            return false;
        }

        // 时间1不能比时间2大
        /// <summary>
        /// 时间1不能比时间2大
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="dt1Name"></param>
        /// <param name="dt2Name"></param>
        /// <returns></returns>
        public static bool LateTime(DateTime dt1, DateTime dt2,
            string dt1Name, string dt2Name)
        {
            if (dt1 > dt2)
            {
                ShowError(dt1Name + "不能大于" + dt2Name);
                return true;
            }

            return false;
        }

        //  第二个整数不能小于第一个整数
        /// <summary>
        /// 第二个整数不能小于第一个整数
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstLabel"></param>
        /// <param name="secondLabel"></param>
        /// <returns></returns>
        public static bool IntLessThan(int first, int second, string firstLabel, string secondLabel)
        {
            if (second < first)
            {
                ShowError(secondLabel + "不能小于" + firstLabel);
                return true;
            }
            return false;
        }

        //一般性消息提示框
        /// <summary>
        /// 一般性消息提示框
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool MsgBox(string text)
        {
            return RadMessageBox.Show(text, "系统提示") == DialogResult.OK;
        }

        //确认提示框
        /// <summary>
        /// 确认提示框
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool Confirm(string text)
        {
            return RadMessageBox.Show(text, "系统提示",
                MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes;
        }

        private static void ShowMessage(CustomMessage message)
        {
            if (Convert.ToString(message.Message).Trim().Equals(""))
                message.Message = "";
            else
                message.Message = DateTime.Now.ToString("HH:mm:ss") + " " + message.Message;
            FrmMainClient.Form.ShowMessage(message);
        }

        //清空当前消息
        /// <summary>
        /// 清空当前消息
        /// </summary>
        public static void ClearMessage()
        {
            FrmMainClient.Form.ClearMessage();
        }
        //普通消息：绿色
        /// <summary>
        /// 普通消息：绿色
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowInfo(string msg)
        {
            ShowMessage(new CustomMessage { Message = msg, Type = MessageType.Info });
        }
        //警告消息：红色
        /// <summary>
        /// 警告消息：红色
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowError(string msg)
        {
            ShowMessage(new CustomMessage { Message = msg, Type = MessageType.Error });
        }
        //错误消息：黄色
        /// <summary>
        /// 错误消息：黄色
        /// </summary>
        /// <param name="msg"></param>
        public static void ShowWarn(string msg)
        {
            ShowMessage(new CustomMessage { Message = msg, Type = MessageType.Warn });
        }

        public static void GenerateInitCode(System.Windows.Forms.Control container)
        {
            var code = new StringBuilder();

            foreach (RadControl ctrl in container.Controls)
            {
                if (ctrl is RadLabel)
                    continue;

                if (ctrl is RadTextBox ||
                    ctrl is RadMaskedEditBox ||
                    ctrl is RadDropDownList ||
                    ctrl is RadCheckBox)
                {
                    code.AppendLine(string.Format("EditEntity.{0} = UI.GetValue({1});",
                        GetFieldName(ctrl), ctrl.Name));
                    continue;
                }

                if (ctrl is RadDateTimePicker)
                {
                    code.AppendLine(string.Format("EditEntity.{0} = UI.GetValue({1}, \"yyyy-MM-dd\");",
                        GetFieldName(ctrl), ctrl.Name));
                    continue;
                }

                code.AppendLine(string.Format("EditEntity.{0} = {1}.Text.Trim();",
                    GetFieldName(ctrl), ctrl.Name));
                continue;
            }

            code.AppendLine("");

            foreach (RadControl ctrl in container.Controls)
            {
                if (ctrl is RadLabel)
                    continue;

                if (ctrl is RadTextBox ||
                    ctrl is RadMaskedEditBox ||
                    ctrl is RadDropDownList ||
                    ctrl is RadCheckBox ||
                    ctrl is RadDateTimePicker)
                {
                    code.AppendLine(string.Format("UI.SetValue({1}, EditEntity.{0});",
                        GetFieldName(ctrl), ctrl.Name));
                    continue;
                }

                code.AppendLine(string.Format("{1}.Text = EditEntity.{0};",
                    GetFieldName(ctrl), ctrl.Name));

                continue;
            }

            code.AppendLine("");

            foreach (RadControl ctrl in container.Controls)
            {
                if (ctrl is RadLabel)
                    continue;

                if (ctrl is RadTextBox ||
                    ctrl is RadMaskedEditBox ||
                    ctrl is RadDropDownList ||
                    ctrl is RadCheckBox ||
                    ctrl is RadDateTimePicker)
                {

                    code.AppendLine(string.Format("if (UI.EmptyText({0}, \"\")) return false;", ctrl.Name));
                    continue;
                }

                continue;
            }

            const string fileName = @"D:\uiCode.txt";
            File.WriteAllText(fileName, code.ToString());
            System.Threading.Thread.Sleep(1000);
            Process.Start(fileName);
        }

        private static string GetFieldName(System.Windows.Forms.Control ctrl)
        {
            var prefix = "";
            if (ctrl is RadTextBox)
            {
                prefix = "txt";
            }
            if (ctrl is RadDropDownList)
            {
                prefix = "ddl";
            }
            if (ctrl is RadMaskedEditBox)
            {
                prefix = "txt";
            }
            if (ctrl is RadDateTimePicker)
            {
                prefix = "dtp";
            }
            if (ctrl is RadCheckBox)
            {
                prefix = "chk";
            }
            if (ctrl is RadRadioButton)
            {
                prefix = "rrt";
            }

            return ctrl.Name.Replace(prefix, "");
        }

        public static void ResetGridColumnWidth(RadGridView gridView)
        {
            for (var i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].Width = 100;
            }
        }

        //生成调用手工Rule的方法
        /// <summary>
        /// 生成调用手工Rule的方法
        /// </summary>
        /// <param name="formName">窗体名称</param>
        /// <param name="eventName">事件名称</param>
        /// <param name="ruleMethodName">待调用的Rule方法名称</param>
        public static void GenerateBaseWIPRuleCode(string formName, string eventName, string ruleMethodName)
        {
            var code = @"
try
{
    var attr = new Dictionary<string, object>
               {
                   {#PageName#},
                   {#ActionName#},
                   //{#LotQty#},//需要传到Rule里面的参数
               };
    var req = new ClientFacade.WIP.BaseWIPRuleRequest
                  {
                      ActualTimeStamp = DateTime.Now,
                      Attributes = attr,
                      LotIds = new List<string> { lotId },//传到Rule中的LotId
                      #MethodName#,
                      #ReasonCode#,
                      UserName = GloableData.Instance.LoginUser
                  };
    var result = ClientFacade.WIP.WIP.ExecuteRule(req);
    UI.MsgBox(workFlowResult.Result);
    return true;
}
catch (Exception ex)
{
    UI.MsgBox(ex.Message);
    return false;
}
";
            code = code.Replace("#PageName#", "\"PageName\", \"" + formName + "\"")
                .Replace("#ActionName#", "\"ActionName\", \"" + eventName + "\"")
                .Replace("#LotQty#", "\"LotQty\", lotQty")
                .Replace("#MethodName#", "MethodName = \"" + ruleMethodName + "\"")
                .Replace("#ReasonCode#", "ReasonCode = \"" + ruleMethodName + "\"");

            const string fileName = @"D:\BaseWIPRuleCode.txt";
            File.WriteAllText(fileName, code);
            System.Threading.Thread.Sleep(1000);
            Process.Start(fileName);
        }

        //生成调用流程Rule的方法
        /// <summary>
        /// 生成调用流程Rule的方法
        /// </summary>
        /// <param name="formName">窗体名称</param>
        /// <param name="eventName">事件名称</param>
        /// <param name="ruleMethodName">待调用的Rule方法名称</param>
        public static void GenerateWorkFlowRuleCode(string formName, string eventName, string ruleMethodName)
        {
            var code = @"
try
{
    var attr = new Dictionary<string, object>
               {
                   {#PageName#},
                   {#ActionName#},
                   //{#LotQty#},//需要传到Rule里面的参数
               };
    var workFlowReq = new ClientFacade.WIP.WorkFlowRuleRequest
                          {
                              ActualTimeStamp = DateTime.Now,
                              Attributes = attr,
                              LotIds = new List<string> {lotId},//传到Rule中的LotId
                              #MethodName#,
                              #ReasonCode#,
                              UserName = GloableData.Instance.LoginUser,
                              Location = eqpId//过站设备名
                          };
    var workFlowResult = ClientFacade.WIP.WIP.ExecuteWorkFlowRule(workFlowReq);
    UI.MsgBox(workFlowResult.Result);
    return true;
}
catch (Exception ex)
{
    UI.MsgBox(ex.Message);
    return false;
}
";
            code = code.Replace("#PageName#", "\"PageName\", \"" + formName + "\"")
                .Replace("#ActionName#", "\"ActionName\", \"" + eventName + "\"")
                .Replace("#LotQty#", "\"LotQty\", lotQty")
                .Replace("#MethodName#", "MethodName = \"" + ruleMethodName + "\"")
                .Replace("#ReasonCode#", "ReasonCode = \"" + ruleMethodName + "\"");

            const string fileName = @"D:\WorkFlowRuleCode.txt";
            File.WriteAllText(fileName, code);
            System.Threading.Thread.Sleep(1000);
            Process.Start(fileName);
        }

        public static void GenerateMutilLanguageSQL(string formName,System.Windows.Forms.Control container)
        {
            var code = new StringBuilder();

            foreach (RadControl ctrl in container.Controls)
            {
                if (!(ctrl is RadLabel))
                    continue;

                code.AppendLine(
                    string.Format("INSERT INTO T_SYSTEM_LANGUAGE(SYSID,FORM_CODE,LABEL_NAME,TEXT_CN,TEXT_EN) VALUES(NEWID(),'{0}','{1}','{2}','{1}')",
                    formName, ctrl.Name, ctrl.Text));
                continue;
            }

            code.AppendLine("");

            const string fileName = @"D:\MutilLanguageSQL_Label.txt";
            File.WriteAllText(fileName, code.ToString());
            System.Threading.Thread.Sleep(1000);
            Process.Start(fileName);
        }
        public static void GenerateMutilLanguageSQL(string formName, RadGridView gridView)
        {
            var code = new StringBuilder();

            for (int i = 0; i < gridView.Columns.Count;i++ )
            {
                code.AppendLine(
                    string.Format("INSERT INTO T_SYSTEM_LANGUAGE(SYSID,FORM_CODE,LABEL_NAME,TEXT_CN,TEXT_EN) VALUES(NEWID(),'{0}','{1}','{2}','{1}')",
                    formName, gridView.Columns[i].Name, gridView.Columns[i].HeaderText));
                continue;
            }

            code.AppendLine("");

            const string fileName = @"D:\MutilLanguageSQL_GridView.txt";
            File.WriteAllText(fileName, code.ToString());
            System.Threading.Thread.Sleep(1000);
            Process.Start(fileName);
        }
    }
}