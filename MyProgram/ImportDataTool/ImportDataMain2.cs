using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DBFactory;

namespace ImportDataTool
{
    public partial class ImportDataMain2 : Form
    {
        public ImportDataMain2()
        {
            InitializeComponent();
        }

        #region 参数
        /// <summary>
        /// 数据库操作类
        /// </summary>
        DBOperate dbo;
        
        /// <summary>
        /// 数据库model
        /// </summary>
        public List<DBNameModel> dbList;

        /// <summary>
        /// 数据源表中列集合
        /// </summary>
        private List<string> listColumnName;

        /// <summary>
        /// 目标表中列集合
        /// </summary>
        private List<string> listColumnGName;

        /// <summary>
        /// 是否进行唯一性检查
        /// </summary>
        private bool isUnique;

        /// <summary>
        /// 是否删除 
        /// </summary>
        private bool isDelete;

        /// <summary>
        /// 数据源获取sql
        /// </summary>
        private string strDataOriginSql;

        /// <summary>
        /// 目标库唯一性查询sql
        /// </summary>
        private string strGSelectSql;

        /// <summary>
        /// 目标库删除sql
        /// </summary>
        private string strGDeleteSql;

        /// <summary>
        /// 目标库插入数据sql
        /// </summary>
        private string strGInsertSql;

        #endregion



        private void ImportDataMain_Load(object sender, EventArgs e)
        {
           
            rdbContinue.Visible = false;
            rdbDelete.Visible = false;

            loadDBbase();
        }
      
        #region 数据源数据库类型change事件
        private void cbDBType_SelectedValueChanged(object sender, EventArgs e)
        {
            cbDBName.Items.Clear();
            cbDBTable.Items.Clear();
            foreach (var item in dbList.Where(r => r.DBType == cbDBType.SelectedItem.ToString()).ToList())
            {
                cbDBName.Items.Add(item.DBShowName);
            }            
        }
        #endregion

        #region 目标库数据库类型change事件
        private void cbDBTypeG_SelectedValueChanged(object sender, EventArgs e)
        {
            cbDBNameG.Items.Clear();
            cbDBTableG.Items.Clear();
            foreach (var item in dbList.Where(r => r.DBType == cbDBTypeG.SelectedItem.ToString()).ToList())
            {
                cbDBNameG.Items.Add(item.DBShowName);
            }
        }
        #endregion

        #region 数据源数据库名称change事件
        private void cbDBName_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = dbList.Where(r => r.DBShowName == cbDBName.SelectedItem.ToString()).FirstOrDefault();

            dbo = new DBOperate(item.DBType, item.DBUrl, item.DBName);

            cbDBTable.Items.Clear();

            cbDBTable.Items.Add("自定义SQL");

            foreach (var itemName in dbo.getTableName())
            {
                cbDBTable.Items.Add(itemName.ToString());
            }
        }
        #endregion

        #region 目标库数据库名称change事件
        private void cbDBNameG_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = dbList.Where(r => r.DBShowName == cbDBNameG.SelectedItem.ToString()).FirstOrDefault();

            dbo = new DBOperate(item.DBType, item.DBUrl, item.DBName);

            cbDBTableG.Items.Clear();

            foreach (var itemName in dbo.getTableName())
            {
                cbDBTableG.Items.Add(itemName.ToString());
            }
        }
        #endregion

        #region 数据源数据库表change事件
        private void cbDBTable_SelectedValueChanged(object sender, EventArgs e)
        {



            var item = dbList.Where(r => r.DBShowName == cbDBName.SelectedItem.ToString()).FirstOrDefault();

            dbo = new DBOperate(item.DBType, item.DBUrl, item.DBName);

            DataTable dt = dbo.getTableColumnName(cbDBTable.SelectedItem.ToString()).Tables["dbTable"];


            listColumnName.Clear();

            foreach (DataRow dr in dt.Rows)
            {

                listColumnName.Add(dr[0].ToString());
            }
        }
        #endregion

        #region 目标数据库表change事件
        private void cbDBTableG_SelectedValueChanged(object sender, EventArgs e)
        {
          
            var item = dbList.Where(r => r.DBShowName == cbDBNameG.SelectedItem.ToString()).FirstOrDefault();
            dbo = new DBOperate(item.DBType, item.DBUrl, item.DBName);
            DataTable dt = dbo.getTableColumnName(cbDBTableG.SelectedItem.ToString()).Tables["dbTable"];
          

            listColumnGName.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                listColumnGName.Add(dr[0].ToString());
            }
        }
        #endregion

        #region 是否唯一性检查change事件
        private void ckbColumn_CheckedChanged(object sender, EventArgs e)
        {
           
            rdbContinue.Visible = ckbColumn.Checked;
            rdbDelete.Visible = ckbColumn.Checked;

        }
        #endregion

        #region 导入历史项change事件
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

           

        }
        #endregion 

        #region 生成sql事件
        private void btImportMacth_Click(object sender, EventArgs e)
        {

        }
        #endregion

     

        #region 加载数据库xml
        private void loadDBbase()
        {
            dbList = XMLHelper.getDBxml("DBHelper.xml");

            List<string> DBTypeList = dbList.Select(r => r.DBType).Distinct().ToList();

            foreach (var item in dbList.Select(r => r.DBType).Distinct().ToList())
            {
                cbDBType.Items.Add(item.ToString());
                cbDBTypeG.Items.Add(item.ToString());
            }
        }
        #endregion

        #region 显示LOG信息
        public static void Log(string msg, string msgtype = "", ListView lstV = null)
        {
            if (lstV != null)
            {

                if (msgtype.Equals("NORMAL"))
                {

                    ListViewItem Item = new ListViewItem();
                    Item.SubItems.Clear();
                    Item.SubItems[0].Text = System.DateTime.Now.ToString() + "   " + msg;// i.ToString();
                    Item.SubItems[0].ForeColor = System.Drawing.Color.Blue;
                    lstV.Items.Add(Item);
                }
                else if (msgtype.Equals("ABNORMAL"))
                {

                    ListViewItem Item = new ListViewItem();
                    Item.SubItems.Clear();
                    Item.SubItems[0].Text = System.DateTime.Now.ToString() + "   " + msg;// i.ToString();
                    Item.SubItems[0].ForeColor = System.Drawing.Color.Red;
                    lstV.Items.Add(Item);
                }
                lstV.Items[lstV.Items.Count - 1].EnsureVisible();
                if (lstV.Items.Count > 2000)
                    lstV.Items.Clear();
            }
        }
        #endregion 

        #region 生成sql方法
        private void createSQL()
        {
            
        }
        #endregion 

        #region 检查必输项状态
       
        #endregion

        private void cbDBTypeG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
