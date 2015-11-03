using System;
using System.Net;
using TelerikWinformBase;

namespace RFIDProgram
{
    //全局数据缓存
    /// <summary>
    /// 全局数据缓存
    /// </summary>
    internal class GloableData
    {
        private GloableData()
        {
        }

        private static GloableData _instance;
        internal static GloableData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GloableData();

                return _instance;
            }
        }

        private string _clientId = string.Empty;
        //客户端ID
        /// <summary>
        /// 客户端ID
        /// </summary>
        internal string ClientId
        {
            get
            {
                if (string.IsNullOrEmpty(_clientId))
                    _clientId = AppSetting.ClientId;
                return _clientId;
            }
            set
            {
                _clientId = value;
                AppSetting.ClientId = _clientId;
            }
        }

        //“配置数据库”连接字符串
        /// <summary>
        /// “配置数据库”连接字符串
        /// </summary>
        private string _configDbConn = string.Empty;
        //“配置数据库”连接字符串
        /// <summary>
        /// “配置数据库”连接字符串
        /// </summary>
        //internal string ConfigDbConn
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_configDbConn))
        //        {
        //            var result = ClientUpdateService.GetConnectionString(AppSetting.ClientDbKey);
        //            if (result.Result)
        //            {
        //                _configDbConn = result.Message;
        //                //SystemConfigBll.UpdateConnectionString(_configDbConn);
        //            }
        //        }
        //        return _configDbConn;
        //    }
        //    set
        //    {
        //        _configDbConn = value;
 
        //    }
        //}

        private const string _IpAddress = "";
        //Ip地址
        /// <summary>
        /// Ip地址
        /// </summary>
        internal string IpAddress
        {
            get
            {
                if (!string.IsNullOrEmpty(_IpAddress))
                    return _IpAddress;

                var ips = Dns.GetHostAddresses(HostName);
                foreach (var ip in ips)
                {
                    if (ip.IsIPv6LinkLocal)
                        continue;

                    return ip.ToString();
                }
                return "";
            }
        }

        private const string _HostName = "";
        //主机名称
        /// <summary>
        /// 主机名称
        /// </summary>
        internal string HostName
        {
            get
            {
                return !string.IsNullOrEmpty(_HostName) ? _HostName : Dns.GetHostName();
            }
        }

        //private SysMapping _teamCodeTimeSetting;
        //internal DateTime DateTimeFrom
        //{
        //    get
        //    {
        //        if (_teamCodeTimeSetting == null)
        //            _teamCodeTimeSetting = SysMappingBll.QueryTeamCodeTimeSetting();
        //        var dtTemp = DateTime.Parse(_teamCodeTimeSetting.Map01);
        //        var dtDb = DT.DateTime().DateTime;
        //        return new DateTime(dtDb.Year, dtDb.Month, dtDb.Day, dtTemp.Hour, dtTemp.Minute, dtTemp.Second);
        //    }
        //}
        //internal DateTime DateTimeTo
        //{
        //    get
        //    {
        //        if (_teamCodeTimeSetting == null)
        //            _teamCodeTimeSetting = SysMappingBll.QueryTeamCodeTimeSetting();
        //        var dtTemp = DateTime.Parse(_teamCodeTimeSetting.Map02);
        //        var dtDb = DT.DateTime().DateTime;
        //        return new DateTime(dtDb.Year, dtDb.Month, dtDb.Day, dtTemp.Hour, dtTemp.Minute, dtTemp.Second);
        //    }
        //}

        //车间
        /// <summary>
        /// 车间
        /// </summary>
        internal string Workshop { get; set; }

        //当前工号
        /// <summary>
        /// 当前工号
        /// </summary>
        internal string UserId { get; set; }

        //当前用户是否是管理员
        /// <summary>
        /// 当前用户是否是管理员
        /// </summary>
        internal bool IsAdmin { get; set; }

        //private DutyTeamCode _currentTeam;
        ////当前班别
        ///// <summary>
        ///// 当前班别
        ///// </summary>
        //internal DutyTeamCode CurrentTeam
        //{
        //    get
        //    {
        //        if (_currentTeam == null)
        //            _currentTeam = DutyTeamCodeBll.QueryCurrentDutyTeamCode(Workshop, DateTimeFrom, DateTimeTo);
        //        if (_currentTeam != null)
        //        {
        //            if (!ClientUpdateService.EqualsCurrentTeamCode(_currentTeam.TeamCode).Result)
        //            {
        //                FrmMainClient.Form.SetTeamCodeText("");
        //                _currentTeam = DutyTeamCodeBll.QueryCurrentDutyTeamCode(Workshop, DateTimeFrom, DateTimeTo);
        //                if (_currentTeam != null)
        //                    FrmMainClient.Form.SetTeamCodeText(_currentTeam.TeamCode);
        //            }
        //        }
        //        return _currentTeam;
        //    }
        //    set
        //    {
        //        _currentTeam = value;
        //    }
        //}

        ////客户端配置
        ///// <summary>
        ///// 客户端配置
        ///// </summary>
        //internal UserClientConfig ClientConfig { get; set; }

        ////当前员工上岗信息
        ///// <summary>
        ///// 当前员工上岗信息
        ///// </summary>
        //internal Duty CurrentDuty { get; set; }

        ////登录信息
        ///// <summary>
        ///// 登录信息
        ///// </summary>
        //internal UserLogin UserLogin { get; set; }

        private readonly DateTime _today = DateTime.MinValue;
        //数据库服务器上的当天日期
        /// <summary>
        /// 数据库服务器上的当天日期
        /// </summary>
        internal DateTime Today
        {
            get
            {
                return _today == DateTime.MinValue ? DateTime.Now : _today;
            }
        }

        //系统语言
        /// <summary>
        /// 系统语言
        /// </summary>
        internal DictionaryItem SystemLanguage { get; set; }

       
    }
}