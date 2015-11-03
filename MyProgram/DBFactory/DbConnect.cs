using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFactory
{
    public abstract class DbConnect
    {
        public DbConnect() { }

        public abstract string Connect();
        public abstract string CheckConn();//数据连接检查
        public abstract string FillDataset(string strsql, string TableName, DataSet DS);
        public abstract string DeleteBySql(string strsql);
        public abstract string UpdateBySql(string strsql);//提交更新命令  
        public abstract string InsertBySql(string strsql);//提交插入命令
    }
}
