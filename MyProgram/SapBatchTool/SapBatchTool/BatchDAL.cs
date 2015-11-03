using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapBatchTool
{
    public class BatchDAL
    {
        // <summary>
        /// 获取form所有信息
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        public static BatchModel getBatchInfo(string strJobno, string strBatch)
        {
            string strSQL = string.Format(@"SELECT TOP 1 [ID],[JOB_NO],[SAP_BATCH]
      ,[STDPOWER]
      ,[CREATED_ON]
      ,[CREATED_BY]
      ,[MODIFIED_ON]
      ,[MODIFIED_BY]
      ,[RESV01]
      ,[RESV02]
      ,[RESV03]
      ,[RESV04]
      ,[RESV05]
      ,[RESV06]
      ,[RESV07]
      ,[RESV08]
      ,[RESV09]
      ,[RESV10]
  FROM [TSAP_JOBNO_BATCH] NOLOCK WHERE JOB_NO='{0}' AND SAP_BATCH='{1}'", strJobno, strBatch);

            var reader = SqlHelper.ExecuteReader(SqlHelper.ConnectString, CommandType.Text, strSQL);

            return DataUtils.ReaderToModel<BatchModel>(reader);
        }

        public static bool Insert(BatchModel bm)
        {
            string strSQL = string.Format(@"INSERT INTO [TSAP_JOBNO_BATCH]([JOB_NO],[SAP_BATCH],[STDPOWER],[CREATED_ON],[CREATED_BY]) VALUES
  ('{0}','{1}','{2}','{3}','{4}')", bm.JOB_NO, bm.SAP_BATCH,bm.STDPOWER,bm.CREATED_ON,bm.CREATED_BY);

            var reader = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectString, CommandType.Text, strSQL);

            return reader > 0 ? true : false;

        }

        public static bool Delete(BatchModel bm)
        {

            string strSQL = "DELETE FROM [TSAP_JOBNO_BATCH] WHERE 1=1";
            if(bm.SAP_BATCH==""&&bm.JOB_NO=="")
            {
                return false;
            }

            if (bm.SAP_BATCH != "")
            {
                strSQL = strSQL + " AND SAP_BATCH='" + bm.SAP_BATCH + "'";
            }
            if (bm.JOB_NO != "")
            {
                strSQL = strSQL + " AND JOB_NO='" + bm.JOB_NO + "'";
            }

            if (bm.STDPOWER != "")
            {
                strSQL = strSQL + " AND STDPOWER='" + bm.STDPOWER + "'";
            }

            var reader = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectString, CommandType.Text, strSQL);

            return reader > 0 ? true : false;

        }
    }
}
