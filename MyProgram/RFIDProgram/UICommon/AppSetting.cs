using System;
using System.Configuration;
using System.Xml;

namespace RFIDProgram
{
    //应用程序设置
    /// <summary>
    /// 应用程序设置
    /// </summary>
    internal class AppSetting
    {
        //客户端ID
        /// <summary>
        /// 客户端ID
        /// </summary>
        /// <returns></returns>
        internal static string ClientId
        {
            get
            {
                return ConfigurationManager.AppSettings["ClientId"];
            }
            set
            {
                UpdateAppConfig("ClientId", value);
            }
        }

        //客户端数据库连接配置项
        /// <summary>
        /// 客户端数据库连接配置项
        /// </summary>
        /// <returns></returns>
        internal static string ClientDbKey
        {
            get
            {
                return "InsuranceReport";
            }
        }

        //  PECVD读取和修改
        /// <summary>
        /// PECVD读取和修改
        /// </summary>
        /// <returns></returns>
        internal static string PECVDTestFile
        {
            get
            {
                return ConfigurationManager.AppSettings["PECVDTestFile"];
            }
            set
            {
                UpdateAppConfig("PECVDTestFile", value);
            }
        }

        //客户端启动程序名
        /// <summary>
        /// 客户端启动程序名
        /// </summary>
        /// <returns></returns>
        internal static string ClientEnterAppName
        {
            get
            {
                return ConfigurationManager.AppSettings["ClientEnterAppName"];
            }
            set
            {
                UpdateAppConfig("ClientEnterAppName", value);
            }
        }

        //自动更新程序名
        /// <summary>
        /// 自动更新程序名
        /// </summary>
        /// <returns></returns>
        internal static string AutoUpdateAppName
        {
            get
            {
                return ConfigurationManager.AppSettings["AutoUpdateAppName"];
            }
            set
            {
                UpdateAppConfig("AutoUpdateAppName", value);
            }
        }

        //在＊.exe.config文件中appSettings配置节更新一对键、值对
        ///<summary>
        ///在＊.exe.config文件中appSettings配置节更新一对键、值对
        ///</summary>
        ///<param name="newKey"></param>
        ///<param name="newValue"></param>
        private static void UpdateAppConfig(string newKey, string newValue)
        {
            var isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Full);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");

            SaveConfig(newKey, newValue);
        }

        //保存配置
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="newKey"></param>
        /// <param name="newValue"></param>
        private static void SaveConfig(string newKey, string newValue)
        {
            var doc = new XmlDocument();

            //获得配置文件的全路径
            var strFileName = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName + ".config";
            doc.Load(strFileName);　　//找出名称为“add”的所有元素

            var nodes = doc.GetElementsByTagName("add");
            for (var i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                var att = nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value != newKey)
                    continue;

                //对目标元素中的第二个属性赋值
                att = nodes[i].Attributes["value"];
                att.Value = newValue;
                break;
            }
            //保存上面的修改
            doc.Save(strFileName);
        }
    }
}