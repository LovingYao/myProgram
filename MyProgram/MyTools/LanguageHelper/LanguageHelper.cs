using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTools.LanguageHelper
{
    public class LanguageHelper
    {

        /// <summary>
        /// 从config.xml 获取默认语言
        /// </summary>
        private static string _Language;

        /// <summary>
        /// 从config.xml 获取集中数据库连接字符串
        /// </summary>
        private static string Language
        {
            get
            {
                if (string.IsNullOrEmpty(_Language))
                    _Language = "En"; //ToolsClass.getConfig("Language", false, "", "config.xml");
                return _Language;
            }
        }

        /// <summary>
        /// 获取form所有信息
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private static List<LanguageItemModel> getLanguageItem(string formName)
        {
            string strSQL = string.Format("SELECT FORM_NAME,CONTROLS_NAME,TYPE,ITEM_FOR,LANGUAGE_CH,LANGUAGE_EN,LANGUAGE_OTHER FROM Language_Items NOLOCK WHERE FORM_NAME='{0}'", formName);

            var reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringLocalTransaction, CommandType.Text, strSQL);

            return DataUtils.ReaderToList<LanguageItemModel>(reader);
        }


        /// <summary>
        /// 获取控件的名称
        /// </summary>
        /// <param name="form"></param>
        public static void getNames(Form form)
        {
            LanguageItemModel lm = new LanguageItemModel();
            List<LanguageItemModel> lmList = getLanguageItem(form.Name.ToString());


            Control.ControlCollection controlNames = form.Controls;

            try
            {
                foreach (Control control in controlNames)
                {
                    
                    if (control.GetType() == typeof(System.Windows.Forms.Panel))
                        GetSubControls(control.Controls, lmList);

                    if (control.GetType() == typeof(System.Windows.Forms.GroupBox))
                        GetSubControls(control.Controls, lmList);

                    if (control.GetType() == typeof(System.Windows.Forms.SplitContainer))
                        GetSubControls(control.Controls, lmList);

                    if (control.GetType() == typeof(System.Windows.Forms.SplitterPanel))
                        GetSubControls(control.Controls, lmList);

                    if (control.GetType() == typeof(System.Windows.Forms.DataGridView))
                        GetDataGridView(control, lmList);

                   
                    lm = lmList.Where(p => p.CONTROLS_NAME == control.Name).FirstOrDefault();
                    if (lm != null)
                    {
                        control.Text = Language == "EN" ? lm.LANGUAGE_EN : lm.LANGUAGE_CH;
                    }


                }

                //窗体的名称
                lm = lmList.Where(p => p.CONTROLS_NAME == form.Name.ToString()).FirstOrDefault();
                if (lm != null)
                {
                    form.Text = Language == "EN" ? lm.LANGUAGE_EN : lm.LANGUAGE_CH;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        


        /// <summary>
        /// 获得子控件的显示名
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="table"></param>
        private static void GetSubControls(Control.ControlCollection controls, List<LanguageItemModel> lmList)
        {
            LanguageItemModel lm = new LanguageItemModel();
            foreach (Control control in controls)
            {
        
                if (control.GetType() == typeof(System.Windows.Forms.Panel))
                    GetSubControls(control.Controls, lmList);

                if (control.GetType() == typeof(System.Windows.Forms.GroupBox))
                    GetSubControls(control.Controls, lmList);

                if (control.GetType() == typeof(System.Windows.Forms.SplitContainer))
                    GetSubControls(control.Controls, lmList);

                if (control.GetType() == typeof(System.Windows.Forms.SplitterPanel))
                    GetSubControls(control.Controls, lmList);

                if (control.GetType() == typeof(System.Windows.Forms.DataGridView))
                    GetDataGridView(control, lmList);

                lm = lmList.Where(p => p.CONTROLS_NAME == control.Name).FirstOrDefault();
                if (lm != null)
                {
                    control.Text = Language == "EN" ? lm.LANGUAGE_EN : lm.LANGUAGE_CH;
                }
            }
        }

        private static void GetDataGridView(Control control, List<LanguageItemModel> lmList)
        {
            LanguageItemModel lm = new LanguageItemModel();
            DataGridView dgv=(DataGridView)control;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                lm = lmList.Where(p => p.ITEM_FOR == control.Name && p.CONTROLS_NAME == dgv.Columns[i].Name).FirstOrDefault();
                if (lm != null)
                {
                    dgv.Columns[i].HeaderText = Language == "EN" ? lm.LANGUAGE_EN : lm.LANGUAGE_CH;
                }
            }
        }
    }
}
