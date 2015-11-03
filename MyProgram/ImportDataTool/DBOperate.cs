using DBFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDataTool
{
    public class DBOperate
    {
        public DbConnect myconnect;

        public string DBType;
        public string DBUrl;
        public string DBName;
        public string strSql;

        DataSet DS = new DataSet();

        DbFactory mydbfactory = new DbFactory();

        public DBOperate(string dbType, string dbUrl,string dbName)
        {
            this.DBType = dbType;
            this.DBUrl = dbUrl;
            this.DBName = dbName;
            myconnect = mydbfactory.CreatConnect(DBType, DBUrl); 
        }

        #region 临时导module_test使用
        public DataSet getModuleTest(string sql)
        {
            if (myconnect.FillDataset(sql, "dbTable", DS) == "ok")
            {
                return DS;
            }
            else
            {
                return null;
            }
        }

        public bool insertModuleTest(string sql)
        {

            if (myconnect.InsertBySql(sql) == "ok")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 

        public DataSet getTableColumnName(string TableName)
        {
            if (DBType.ToLower().Equals("sqlserver"))
            {
                strSql = string.Format(ConfigurationManager.AppSettings["SqlserverForGetColumnName"].Trim(),TableName);
            }
            else if (DBType.ToLower().Equals("mysql"))
            {
                strSql = string.Format(ConfigurationManager.AppSettings["MySqlForGetColumnName"].Trim(), DBName,TableName);
            }
            else
            {
                return null;
            }

            if (myconnect.FillDataset(strSql, "dbTable", DS) == "ok")
            {
                return DS;
            }
            else
            {
                return null;
            }
        }

        public  List<string> getTableName()
        {
            List<string> strResult=new List<string>();

            if (DBType.ToLower().Equals("sqlserver"))
            {
                strSql = ConfigurationManager.AppSettings["SqlserverForGetTableName"].Trim();
            }
            else if (DBType.ToLower().Equals("mysql"))
            {
                strSql = string.Format(ConfigurationManager.AppSettings["MySqlForGetTableName"].Trim(), DBName);
            }
            else
            {
                return null;
            }

            if(myconnect.FillDataset(strSql,"dbTable",DS)=="ok")
            {
                foreach (DataRow dr in DS.Tables["dbTable"].Rows)
                {
                   strResult.Add(dr[0].ToString());
                }
             }

            return strResult;

        }
    }
}
