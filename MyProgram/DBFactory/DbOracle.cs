using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace DBFactory
{
    public class DbOracle : DbConnect
    {
        private OracleConnection MyConn;//全局数据连接
        private string MyConnectString;//全局连接字符串
        public DbOracle(string connectstring)
        {
            MyConn = new OracleConnection();
            MyConnectString = connectstring;
        }

        public override string Connect()//创建数据库连接
        {
            try
            {
                if (MyConn.State == ConnectionState.Closed || MyConn.State == ConnectionState.Broken)
                {
                    MyConn.ConnectionString = MyConnectString;
                    MyConn.Open();
                }
                else
                {
                    MyConn.Close();
                    MyConn.ConnectionString = MyConnectString;
                    MyConn.Open();
                }

                return ("ok");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }

        }
        public override string CheckConn()//数据连接检查
        {
            try
            {
                if (this.MyConn.State == ConnectionState.Closed || this.MyConn.State == ConnectionState.Broken)
                {
                    this.Connect();
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }

        }
        public override string FillDataset(string strsql, string TableName, DataSet DS)
        {
            try
            {
                string errstr;
                errstr = CheckConn();
                if (errstr != "ok") { return (errstr); }
                OracleCommand Cmd = MyConn.CreateCommand();//sql查询命令对象
                Cmd.CommandText = strsql;//sql命令付给MyOraCmd对象
                OracleDataAdapter dabuff = new OracleDataAdapter();//建立适配器
                if (DS.Tables.Contains(TableName) == false)//判断数据集中是否有相同名称表
                {
                    DS.Tables.Add(new DataTable(TableName));

                }
                else
                { //清除数据集中存在表的行数
                    DS.Tables[TableName].Rows.Clear();

                }
                dabuff.SelectCommand = Cmd;
                DS.Tables[TableName].BeginLoadData();
                dabuff.Fill(DS.Tables[TableName]);
                DS.Tables[TableName].EndLoadData();
                Cmd.Dispose();
                dabuff.Dispose();
                return ("ok");

            }
            catch (Exception ex)
            {
                return (ex.Message);
            }

        }
        public override string DeleteBySql(string strsql)//提交删除命令
        {
            try
            {
                this.CheckConn();
                OracleCommand cmdDel = new OracleCommand();
                OracleDataAdapter daDel = new OracleDataAdapter();
                int delrownum;
                cmdDel.Connection = MyConn;
                cmdDel.CommandText = strsql;
                daDel.DeleteCommand = cmdDel;
                delrownum = daDel.DeleteCommand.ExecuteNonQuery();
                cmdDel.Dispose();
                daDel.Dispose();
                return ("ok");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        public override string UpdateBySql(string strsql)//提交更新命令
        {
            try
            {
                this.CheckConn();
                OracleCommand cmdUpdate = new OracleCommand();
                OracleDataAdapter daUpdate = new OracleDataAdapter();
                cmdUpdate.Connection = MyConn;
                cmdUpdate.CommandText = strsql;
                daUpdate.UpdateCommand = cmdUpdate;
                daUpdate.UpdateCommand.ExecuteNonQuery();
                cmdUpdate.Dispose();
                daUpdate.Dispose();
                return ("ok");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
        public override string InsertBySql(string strsql)//提交插入命令
        {
            try
            {
                this.CheckConn();
                OracleCommand cmdInsert = new OracleCommand();
                OracleDataAdapter daInsert = new OracleDataAdapter();
                cmdInsert.Connection = MyConn;
                cmdInsert.CommandText = strsql;
                daInsert.InsertCommand = cmdInsert;
                daInsert.InsertCommand.ExecuteNonQuery();
                cmdInsert.Dispose();
                daInsert.Dispose();
                return ("ok");
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}
