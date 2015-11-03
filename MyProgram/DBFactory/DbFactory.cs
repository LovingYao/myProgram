using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFactory
{
    public class DbFactory
    {
        public DbFactory() { }

        public DbConnect CreatConnect(string contype, string connectstring)
        {

            switch (contype.ToLower())
            {
                case "oracle":
                    return new DbOracle(connectstring);
                case "sqlserver":
                    return new DbSqlserver(connectstring);
                case "mysql":
                    return new DbMysql(connectstring);
                default:
                    return null;

            }           
        }
    }
}
