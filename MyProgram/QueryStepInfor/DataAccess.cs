using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QueryStepInfor
{
    public class DataAccess
    {
        // <summary>
        /// 获取form所有信息
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        public static List<DataModel> getData(string strStartTime, string strEndTime, string strEquip)
        {
            string strSQL = string.Format(@"SELECT [WORKSHOP]
      ,[LINE]
      ,[EQUIPMENT_NAME]
      ,[MODULE_SN]
      ,[CREATED_ON]
  FROM [AIPlatform].[dbo].[T_MONITOR_MODULE] nolock
  where equipment_name='{2}'
  and created_on>='{0}'
  and created_on<='{1}'
  and module_sn like '115%'
  and len(module_sn)=14
  order by created_on", strStartTime, strEndTime,strEquip);

            var reader = SqlHelper.ExecuteReader(SqlHelper.ConnectString, CommandType.Text, strSQL);

            return DataUtils.ReaderToList<DataModel>(reader);
        }

    }
}
