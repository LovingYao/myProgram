using System;
using System.Text;
using log4net;
using System.Windows.Forms;

namespace RFIDProgram
{
    //日志类
    /// <summary>
    /// 日志类
    /// </summary>
    internal class Logger
    {
        //日志记录实例
        /// <summary>
        /// 日志记录实例
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger("FastLogger");

        private static readonly string MsgHeader = "ClientVersion::" + Application.ProductVersion;
        //构造异常信息的日志记录
        /// <summary>
        /// 构造异常信息的日志记录
        /// </summary>
        /// <param name="ex">异常信息</param>
        /// <returns>日志记录</returns>
        private static string GetErrorCode(Exception ex)
        {
            if (ex == null)
                return "";

            var error = new StringBuilder();
            error.AppendLine(MsgHeader + "Class Name :: " +
                             ((ex.TargetSite == null || ex.TargetSite.DeclaringType == null)
                                  ? "null"
                                  : ex.TargetSite.DeclaringType.FullName));
            error.AppendLine("Method Name :: " + (ex.TargetSite == null ? "null" : ex.TargetSite.Name));
            error.AppendLine("Message :: " + (ex.Message ?? "null"));
            error.AppendLine("StackTrace :: " + (ex.StackTrace ?? "null"));
            error.AppendLine("Source :: " + (ex.Source ?? "null"));
            error.AppendLine("InnerException :: " + (ex.InnerException == null ? "null" : ex.InnerException.ToString()));
            return error.ToString();
        }

        #region 记录Debug日志

        //记录Debug日志
        /// <summary>
        /// 记录Debug日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="msg">日志内容</param>
        internal static void LogDebug(string localtion, string msg)
        {
            if (Log.IsDebugEnabled)
                Log.Debug(MsgHeader + " :: " + localtion + " :: " + msg);
        }

        //记录Debug日志
        /// <summary>
        /// 记录Debug日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="ex">异常信息</param>
        internal static void LogDebug(string localtion, Exception ex)
        {
            if (Log.IsDebugEnabled)
                Log.Debug(localtion + " :: " + GetErrorCode(ex) + "\r\n" + GetErrorCode(ex.GetBaseException()));
        }

        #endregion

        #region 记录Info日志

        //记录Info日志
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="msg">日志内容</param>
        internal static void LogInfo(string msg)
        {
            if (Log.IsInfoEnabled)
                Log.Info(msg);
        }

        //记录Info日志
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="msg">日志内容</param>
        internal static void LogInfo(string localtion, string msg)
        {
            if (Log.IsInfoEnabled)
                Log.Info(localtion + " :: " + msg);
        }

        //记录Info日志
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="ex">异常信息</param>
        internal static void LogInfo(Exception ex)
        {
            if (Log.IsInfoEnabled)
                Log.Info(GetErrorCode(ex) + "\r\n" + GetErrorCode(ex.GetBaseException()));
        }

        //记录Info日志
        /// <summary>
        /// 记录Info日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="ex">异常信息</param>
        internal static void LogInfo(string localtion, Exception ex)
        {
            if (Log.IsInfoEnabled)
                Log.Info(localtion + " :: " + GetErrorCode(ex) + "\r\n" + GetErrorCode(ex.GetBaseException()));
        }

        #endregion

        #region 记录Error日志

        //记录Error日志
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="msg">日志内容</param>
        internal static void LogError(string localtion, string msg)
        {
            if (Log.IsErrorEnabled)
                Log.Error(MsgHeader + " :: " + localtion + " :: " + msg);
        }

        //记录Error日志
        /// <summary>
        /// 记录Error日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="ex">异常信息</param>
        internal static void LogError(string localtion, Exception ex)
        {
            if (Log.IsErrorEnabled)
                Log.Error(localtion + " :: " + GetErrorCode(ex) + "\r\n" + GetErrorCode(ex.GetBaseException()));
        }

        #endregion

        #region 记录Fatal日志

        //记录Fatal日志
        /// <summary>
        /// 记录Fatal日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="msg">日志内容</param>
        internal static void LogFatal(string localtion, string msg)
        {
            if (Log.IsFatalEnabled)
                Log.Fatal(MsgHeader + " :: " + localtion + " :: " + msg);
        }

        //记录Fatal日志
        /// <summary>
        /// 记录Fatal日志
        /// </summary>
        /// <param name="localtion">日志记录位置</param>
        /// <param name="ex">异常信息</param>
        internal static void LogFatal(string localtion, Exception ex)
        {
            if (Log.IsFatalEnabled)
                Log.Fatal(localtion + " :: " + GetErrorCode(ex) + "\r\n" + GetErrorCode(ex.GetBaseException()));
        }

        #endregion
    }
}