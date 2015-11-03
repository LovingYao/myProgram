using System;
//using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Web;
using System.Security.Cryptography;

namespace MyTools
{
    /// <summary>
    /// 用户数据库字符、MD5加密处理类
    /// </summary>
    public class Tools
    {
        private static Regex SpbEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info|cc|cn|com.cn|net.cn|org|org.cn)$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样
        private static Regex SpbCHZN = new Regex("[\u4e00-\u9fa5]");//检测是否有中文字符
        private static Regex SpbUser = new Regex(@"^[A-Za-z0-9]+$");//检测是否英文字母或数字
        private static Regex SpbSz = new Regex(@"^[0-9]*[1-9][0-9]*$"); //检测是否英文字母或数字
       // public Tools(){}  
        
        /// <summary>
        /// 检查字符串是否超过指定的最大长度
        /// </summary>
        /// <param name="sqlInput">输入字符串</param>
        /// <param name="maxLength">最大长度</param>
        /// <returns></returns>			
        public static bool StrLength(string StrInput, int maxLength)
        {
            if (StrInput.Length > maxLength)
            {
                return false;//超过8个字符，返回假
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 规定多少字符到多少字符之间false
        /// </summary>
        /// <param name="StrInput">输入字符串</param>
        /// <param name="StrNoint">最少长度</param>
        /// <param name="StrNointTwo">最大长度</param>
        /// <returns></returns>
        public static bool StrLengthNoint(string StrInput, int StrNoint, int StrNointTwo)
        {
            // int StrNoint = 3, StrNointTwo=5;
            if (StrInput.Length > StrNoint || StrInput.Length < StrNointTwo)
            {
                return false;//超过8个字符，返回假
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 字符数目绝对等于
        /// </summary>
        /// <param name="StrInput"></param>
        /// <param name="StrNoint"></param>
        /// <returns></returns>
        public static bool StrLengthdengyu(string StrInput, int StrNoint)
        {
            // int StrNoint = 3, StrNointTwo=5;
            if (StrInput.Length == StrNoint)
            {
                return false;//超过8个字符，返回假
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 检测是否有中文字符
        /// </summary>
        /// <param name="StrInput"></param>
        /// <returns></returns>
        public static bool IsZh(string StrInput)
        {
            Match m = SpbCHZN.Match(StrInput);
            return m.Success;
        }
        /// <summary>
        /// 检测SpbEmail是否成立
        /// </summary>
        /// <param name="StrInput"></param>
        /// <returns></returns>
        public static bool IsEmail(string StrInput)
        {
            Match m = SpbEmail.Match(StrInput);
            return m.Success;
        }
        /// <summary>
        /// Email使用
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string strIn)
        {
            return
      Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// 检测是否英文字母或数字
        /// </summary>
        /// <param name="StrInput"></param>
        /// <returns></returns>
        public static bool IsEnNum(string StrInput)
        {
            Match m = SpbUser.Match(StrInput);
            return m.Success;
        }
        /// <summary>
        /// 检查是不是全是非负数的数字
        /// </summary>
        /// <param name="StrInput"></param>
        /// <returns></returns>
        public static bool IsEnNumber(string StrInput)
        {
            Match m = SpbSz.Match(StrInput);
            return m.Success;
        }

        /// <summary>
        /// MD5加密处理
        /// </summary>
        /// <param name="toHash"></param>
        /// <returns></returns>
        public static string Hash(string toHash)
        {
            MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF7.GetBytes(toHash);
            bytes = crypto.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte num in bytes)
            {
                sb.AppendFormat("{0:x2}", num);
            }
            return sb.ToString();
        }
        ///
        /// MembershipPasswordFormat.Hashed
        //public static string Hashed(string Hashed)
        //{
        //    Membership s = MembershipPasswordFormat.Hashed();
        //}
        /// <summary>
        /// 根据配置对指定字符串进行 MD5 加密
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMD5(string s)
        {
            //md5加密
            s = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(s, "md5").ToString();

            return s.ToLower();
        }

        /// <summary>
        /// 转换成小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StrToLower(string str)
        {
            return str.ToLower();
        }
        /// <summary>
        /// Guid编号ID
        /// </summary>
        /// <returns></returns>
        public static string StrGuid()
        {
            string strBh = System.Guid.NewGuid().ToString();//GUID编号ID
            return strBh;
        }
        /// <summary>
        /// 索取返回地址
        /// </summary>
        /// <returns></returns>
        public static string SpbRul()
        {
            string strRul = HttpContext.Current.Request.Url.AbsolutePath; //索取返回地址
            return strRul;
        }
        /// <summary>
        /// 产生随机数组
        /// </summary>
        /// <returns></returns>
        public static string SpbRandom()
        {
            Random ro = new Random(unchecked((int)DateTime.Now.Ticks));
            String RoInt2 = ro.Next().ToString();
            return RoInt2;
        }
        /// <summary>
        /// Spb自定MD5编码
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string SpbMd5(string pwd)
        {
            string rdoms = "Spb.an8.net";  //定义字符串
            string strmd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(rdoms, "MD5").ToLower();
            string strmd5 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strmd + pwd, "MD5").ToLower();  //把两位随机字母和md5连接并再次进行MD5加密
            return strmd5; //将两位随机字母与加密后的MD5值再次连接

        }
        //将C时间戳转换为.NET时间
        /// <summary>
        /// 将C时间戳转换为.NET时间
        /// </summary>
        /// <param name="nTimer"></param>
        /// <returns></returns>
        /// tools.SpbDateTime(nTimer);
        public static DateTime SpbDateTime(long nTimer)
        {
            long nDays = nTimer / 86400;	//计算出天数
            long nSecond = nTimer % 86400;	//剩余的秒
            long nHour = nSecond / 3600L;	//计算出小时
            nSecond = nSecond % 3600;		//剩余的秒
            long nMinute = nSecond / 60;	//计算出分钟
            nSecond = nSecond % 60;			//剩余的秒
            TimeSpan timeSpan = new TimeSpan((int)nDays, (int)nHour, (int)nMinute, (int)nSecond);
            return new DateTime(621356256000000000 + timeSpan.Ticks);
        }
        //将.NET时间转换为C时间戳
        /// <summary>
        /// 将.NET时间转换为C时间戳
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        /// 
        ///  DateTime dt = DateTime.Now;
        ///  long strtime = Tools.SpbTime(dt);
        public static long SpbTime(DateTime dt)
        {
            TimeSpan timeSpan = new TimeSpan(dt.Ticks - 621356256000000000);
            return (long)timeSpan.TotalSeconds;
        }
        /// <summary>
        /// 检测是否有Sql危险字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsSafeSqlString(string str)
        {

            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|　|\*|!|\']");
        }
        /// <summary>
        /// 用户IP
        /// </summary>
        /// <returns></returns>
        public static string SpbIPAddress()
        {
            string UserIP = "";

            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                UserIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                UserIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }

            return UserIP.ToString();

        }
        /// <summary>
        ///处理 html中的危险字符
        /// </summary>
        //public class SystemHTML
        // {
        public static string HTMLEncode(string fString)
        {
            if (fString != string.Empty)
            {
                ///替换尖括号
                fString.Replace("<", "&lt;");
                fString.Replace(">", "&rt;");
                ///替换引号
                fString.Replace(((char)34).ToString(), "&quot;");
                fString.Replace(((char)39).ToString(), "&#39;");
                ///替换空格
                fString.Replace(((char)13).ToString(), "");
                ///替换换行符
                fString.Replace(((char)10).ToString(), "<BR> ");
                ///替换LUNLI
                fString.Replace("伦理", "过滤字");
            }
            return (fString);
        }
        // }
        /// <summary>
        /// 写入时候过滤字符
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string cutBadStr(string inputStr)
        {
            inputStr = inputStr.ToLower().Replace(",", "");
            inputStr = inputStr.ToLower().Replace("<", "&lt;");
            inputStr = inputStr.ToLower().Replace(">", "&gt;");
            inputStr = inputStr.ToLower().Replace("%", "");
            inputStr = inputStr.ToLower().Replace(".", "");
            inputStr = inputStr.ToLower().Replace(":", "");
            inputStr = inputStr.ToLower().Replace("#", "");
            inputStr = inputStr.ToLower().Replace("&", "");
            inputStr = inputStr.ToLower().Replace("$", "");
            inputStr = inputStr.ToLower().Replace("^", "");
            inputStr = inputStr.ToLower().Replace("*", "");
            inputStr = inputStr.ToLower().Replace("`", "");
            inputStr = inputStr.ToLower().Replace(" ", "");
            inputStr = inputStr.ToLower().Replace("~", "");
            inputStr = inputStr.ToLower().Replace("or", "");
            inputStr = inputStr.ToLower().Replace("and", "");
            inputStr = inputStr.ToLower().Replace("伦理", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("毛片", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("色情", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("三级", "**已经过滤**");
            return inputStr;

        }
        /// <summary>
        /// 读取过滤字符
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string SelectcutBadStr(string inputStr)
        {
            inputStr = inputStr.ToLower().Replace(",", "");
            inputStr = inputStr.ToLower().Replace("<", "&lt;");
            inputStr = inputStr.ToLower().Replace(">", "&gt;");
            inputStr = inputStr.ToLower().Replace("%", "");
            inputStr = inputStr.ToLower().Replace(".", "");
            inputStr = inputStr.ToLower().Replace(":", "");
            inputStr = inputStr.ToLower().Replace("#", "");
            inputStr = inputStr.ToLower().Replace("&", "");
            inputStr = inputStr.ToLower().Replace("$", "");
            inputStr = inputStr.ToLower().Replace("^", "");
            inputStr = inputStr.ToLower().Replace("*", "");
            inputStr = inputStr.ToLower().Replace("`", "");
            inputStr = inputStr.ToLower().Replace(" ", "");
            inputStr = inputStr.ToLower().Replace("~", "");
            inputStr = inputStr.ToLower().Replace("or", "");
            inputStr = inputStr.ToLower().Replace("and", "");
            inputStr = inputStr.ToLower().Replace("伦理", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("毛片", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("色情", "**已经过滤**");
            inputStr = inputStr.ToLower().Replace("三级", "**已经过滤**");
            return inputStr;

        }
        /// <summary> 
        /// 显示消息提示对话框 
        /// AlertMsg (this,"看，我出来啦，挖哈哈！");
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="msg">对话框显示信息</param> 
        public static void AlertMsg(System.Web.UI.Page page, string msg)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<Script Language='Javascript'>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.Append("</Script>");
            page.Response.Write(Builder);
        }
        /// <summary> 
        /// 显示消息提示对话框，并进行页面跳转
        /// ShowAndRedirect(this, "走了，嘿嘿，去首页！", "index.aspx");
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="msg">提示信息</param> 
        /// <param name="url">跳转的目标URL</param> 
        public static void ShowAndRedirect(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script language='javascript' defer>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("location.href='{0}'", url);
            Builder.Append("</script>");
            page.Response.Write(Builder.ToString());

        }
        /// <summary> 
        /// 显示消息选择对话框，跳转不同页面
        /// ShowAndSelect (this,"确定去首页，取消去lei页","index.aspx","lei.aspx");
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="msg">对话框显示信息</param>
        /// <param name="url1">点击确定后转到地址</param>
        /// <param name="url2">点击取消后转到地址</param>
        public static void ShowAndSelect(System.Web.UI.Page page, string msg, string url1, string url2)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<Script Language='Javascript'>");
            Builder.AppendFormat("if(confirm('{0}'))", msg);
            Builder.Append("{");
            Builder.AppendFormat("location.href='{0}';", url1);
            Builder.Append("}");
            Builder.Append("else");
            Builder.Append("{");
            Builder.AppendFormat("location.href='{0}';", url2);
            Builder.Append("}");
            Builder.Append("</Script>");
            page.Response.Write(Builder);
        }
        /// <summary> 
        /// 控件点击消息确认提示框 
        /// CtrlConfirm(btn1, "点确定继续，点取消就等于我没出来，挖哈哈");
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="msg">显示信息</param> 
        public static void CtrlConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }
        /// <summary> 
        /// 输出自定义脚本信息 
        /// ResponseScript(this,"alert('我是输入的脚本产生的！')");
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="script">输出脚本</param> 
        public static void ResponseScript(System.Web.UI.Page page, string script)
        {
            page.Response.Write("<script language='javascript' defer>" + script + "</script>");
        }
        /// <summary> 
        /// 点击对话框，自动回到上一页 
        /// </summary> 
        /// <param name="page">当前页面指针，一般为this</param> 
        /// <param name="script">显示信息</param> 
        public static void GoError(System.Web.UI.Page page, string str)
        {
            page.Response.Write("<script language=javascript>alert('" + str + "\\n\\n系统将自动返回前一页...');history.back();</script>");
            page.Response.End();
        }
        /**调用说明**/
        /*
    DHK.AlertMsg (this,"看，我出来啦，挖哈哈！");
    DHK.ShowAndSelect (this,"确定去首页，取消去lei页","index.aspx","lei.aspx");
    DHK.CtrlConfirm(btn1, "点确定继续，点取消就等于我没出来，挖哈哈");
    DHK.ResponseScript(this,"alert('我是输入的脚本产生的！')");
    DHK.ShowAndRedirect(this, "走了，嘿嘿，去首页！", "index.aspx");
         * */
        /// <summary>
        /// md5加密，返回第6至13位置中的字符
        /// </summary>
        /// <param name="password">密码明文</param>
        /// <returns></returns>
        public string Md5(string password)
        {
            MD5CryptoServiceProvider hashmd5;
            hashmd5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(hashmd5.ComputeHash(Encoding.Default.GetBytes(password))).Replace("-", "").Substring(6, 13);
        }
        /// <summary>
        /// 是否为id
        /// </summary>
        /// <param name="chars">待判断字符</param>
        /// <returns></returns>
        public static bool IsId(string chars)
        {
            return Regex.IsMatch(chars, @"^\d{1,9}$");
        }
        /// <summary>
        /// 过滤一切脚本内容
        /// </summary>
        /// <param name="content">内容</param>
        /// <returns></returns>
        public static string Filtrate(string content)
        {
            return Regex.Replace(content, "<[^>]*>", "");
        }
        #region  生成随机的数字和字母 codeCount是希望生成的长度
        /// <summary>
        ///	生成随机的数字和字母
        /// </summary>
        /// <param name="codeCount">codeCount是希望生成的长度</param>
        /// <returns></returns>
        public string CreateRandomCode(int codeCount) //codeCount是希望生成的长度
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            Random rand = new Random();
            int temp = -1;
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(0, 10);

                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }
        #endregion

        #region  判断是否是数字格式
        /// <summary>
        /// 判断是否是数字格式
        /// </summary>
        /// <param name="GetNum"></param>
        public bool CheckNumber(string GetNum)
        {

            Regex r = new Regex(@"^[0-9]+$");
            if (r.IsMatch(GetNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region  检测非法字符，防止sql注入
        /// <summary>
        /// 检测非法字符，防止sql注入
        /// 如果参数是空，返回false
        /// 如果参数中包含非法字符，返回false
        ///// 否则返回    true
        /// </summary>
        /// <param name="thePara"></param>
        /// <returns></returns>
        public bool toFilter(string thePara)
        {
            string[] BadCode = new string[] { "'", "\"", "exec", "cmd", ">", "<", "and", "=", "\\", ";" };
            try
            {
                if (CheckNullstr(thePara) == false)          //如果参数是空值，返回false
                {
                    throw new Exception("参数为空");
                }
                else
                {
                    for (int i = 0; i < BadCode.Length; i++)
                    {
                        if (thePara.IndexOf(BadCode[i]) > 0)
                        {
                            throw new Exception("包含非法字符");
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }


        }
        #endregion

        #region  bool CheckNullstr(string Getstr)判断是否是空值
        /// <summary>
        /// Getstr得到参数判断是否是空值
        /// </summary>
        /// <param name="Getstr">需要检查的值</param>
        /// <param name="GetShow">这个字段的功能说明：姓名,sex</param>
        public bool CheckNullstr(string Getstr)
        {
            try
            {
                if (Getstr == null || Getstr == "" || Getstr.Length < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        #endregion


        #region bool CheckNumberRegx(string GetNum)正则表达式 判断是否是正负数字含小数
        /// <summary>
        /// 判断是否是数字格式
        /// </summary>
        /// <param name="GetNum"></param>
        public bool CheckNumberRegx(string GetNum)
        {
            //^[+-]?\d+(\.\d+)?$正负数字含小数     数字含小数^\d+(\.\d+)?$
            Regex r = new Regex(@"^\d+(\.\d+)?$");
            if (r.IsMatch(GetNum))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion


        #region  用C#截取指定长度的中英文混合字符串
        /// <summary>
        /// s接受的字符
        /// l长度
        /// </summary>
        /// <param name="s"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static string CutStr(string s, int l)
        {
            string temp = s;
            if (Regex.Replace(temp, "[\u4e00-\u9fa5]", "zz", RegexOptions.IgnoreCase).Length <= l)
            {
                return temp;
            }
            for (int i = temp.Length; i >= 0; i--)
            {
                temp = temp.Substring(0, i);
                if (Regex.Replace(temp, "[\u4e00-\u9fa5]", "zz", RegexOptions.IgnoreCase).Length <= l - 3)
                {
                    return temp + "";
                }
            }
            return "";
        }
        #endregion


        #region 数字和字母随机数
        /// <summary>
        /// 数字和字母随机数
        /// </summary>
        /// <param name="n">生成长度</param>
        /// <returns></returns>
        public static string Rand_Number_AZ_Code(int n)
        {
            char[] arrChar = new char[]{
       'a','b','d','c','e','f','g','h','i','j','k','l','m','n','p','r','q','s','t','u','v','w','z','y','x',
       '0','1','2','3','4','5','6','7','8','9',
       'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Q','P','R','T','S','V','U','W','X','Y','Z'
      };

            StringBuilder num = new StringBuilder();

            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                num.Append(arrChar[rnd.Next(0, arrChar.Length)].ToString());

            }

            return num.ToString();
        }
        #endregion

        #region 字母随机数
        /// <summary>
        /// 字母随机数
        /// </summary>
        /// <param name="n">生成长度</param>
        /// <returns></returns>
        public static string RandLetter(int n)
        {
            char[] arrChar = new char[]{
        'a','b','d','c','e','f','g','h','i','j','k','l','m','n','p','r','q','s','t','u','v','w','z','y','x',
       'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Q','P','R','T','S','V','U','W','X','Y','Z'
      };

            StringBuilder num = new StringBuilder();

            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                num.Append(arrChar[rnd.Next(0, arrChar.Length)].ToString());

            }

            return num.ToString();
        }
        #endregion

        #region 日期随机函数
        /// <summary>
        /// 日期随机函数
        /// </summary>
        /// <param name="ra">长度</param>
        /// <returns></returns>
        public static string DateRndName(Random ra)
        {
            DateTime d = DateTime.Now;
            string s = null, y, m, dd, h, mm, ss;
            y = d.Year.ToString();
            m = d.Month.ToString();
            if (m.Length < 2) m = "0" + m;
            dd = d.Day.ToString();
            if (dd.Length < 2) dd = "0" + dd;
            h = d.Hour.ToString();
            if (h.Length < 2) h = "0" + h;
            mm = d.Minute.ToString();
            if (mm.Length < 2) mm = "0" + mm;
            ss = d.Second.ToString();
            if (ss.Length < 2) ss = "0" + ss;
            s += y + m + dd + h + mm + ss;
            s += ra.Next(100, 999).ToString();
            return s;
        }
        #endregion

        #region 生成GUID
        /// <summary>
        /// 生成GUID
        /// </summary>
        /// <returns></returns>
        public static string GetGuid()
        {
            System.Guid g = System.Guid.NewGuid();
            return g.ToString();
        }
        #endregion
        #region 去除HTML标记
        /// <summary>
        /// 去除HTML标记
        /// </summary>
        /// <param name="Htmlstring">包括HTML的源码 </param>
        /// <returns>已经去除后的文字</returns>
        public string NoHTML(string Htmlstring)
        {
            //删除脚本
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            //删除HTML
            /*Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);*/
            //      add new 2006-12-30
            //Htmlstring = Regex.Replace(Htmlstring, @"<.*?>", "", RegexOptions.IgnoreCase);//      清除所有标签
            Htmlstring = Regex.Replace(Htmlstring, @"<script.*>[\s\S]*?</script>", "", RegexOptions.IgnoreCase);

            //Htmlstring.Replace("<", "");
            // Htmlstring.Replace(">", "");
            //Htmlstring.Replace("\r\n", "");
            //Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();

            return Htmlstring;
        }
        #endregion
        #region SQL防注入函数
        //#################### SQL防注入函数 #################### 
        public static string CheckRequest(string myStr)
        {
            myStr = HttpContext.Current.Request[myStr];
            if (myStr != null&&myStr!="")
            {
                myStr = myStr.Replace("'", "[YshxwDot]");//过滤最关键的单引号
                myStr = myStr.Replace("=", "[YshxwEqual]");
                myStr = myStr.Replace("--", "[YshxwLine]");//防止被注释
            }
            return myStr;
        }
        public string CheckGetBack(string myStr)
        {
            if (myStr != null && myStr != "")
            {
                myStr = myStr.Replace("[YshxwDot]", "'");
                myStr = myStr.Replace("[YshxwEqual]", "=");
                myStr = myStr.Replace("[YshxwLine]", "--");
            }
            return myStr;
        }
        #endregion
    }
}
