using System;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RFIDProgram
{
    public class ProcessHelper
    {
        //根据进程名称结束进程
        /// <summary>
        /// 根据进程名称结束进程
        /// </summary>
        /// <param name="processName">进程名称</param>
        public static void KillProcess(string processName)
        {
            var proc = GetProcessByName(processName);

            if (proc == null)
                return;

            proc.Kill();

            Thread.Sleep(1000);

            KillProcess(processName);
        }

        //根据进程名称获取进程
        /// <summary>
        /// 根据进程名称获取进程
        /// </summary>
        /// <param name="processName">进程名称</param>
        /// <returns></returns>
        public static Process GetProcessByName(string processName)
        {
            var proc = Process.GetProcesses().FirstOrDefault(x => x.ProcessName.ToLower() == processName.ToLower());

            if (proc != null)
                return proc;

            proc =
                Process.GetProcesses().FirstOrDefault(
                    x => x.ProcessName.ToLower() == processName.ToLower().Replace(".exe", ""));

            return proc;
        }

        public static void StartMesToolkit()
        {
            try
            {
                const string fileName = "Insurance.Report.ClientToolkit.exe";
                var process = GetProcessByName(fileName);

                if (process == null)
                {
                    var fileFullName = AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName;
                    if (File.Exists(fileFullName))
                        Process.Start(fileFullName);
                }
            }
            catch (Exception ex)
            {
                Logger.LogDebug("StartMesToolkit", ex);
            }
        }

        public static void KillMesToolkit()
        {
            try
            {
                const string processName = "Insurance.Report.ClientToolkit.exe";

                KillProcess(processName);
            }
            catch (Exception ex)
            {
                Logger.LogDebug("KillMesToolkit", ex);
            }
        }
    }
}