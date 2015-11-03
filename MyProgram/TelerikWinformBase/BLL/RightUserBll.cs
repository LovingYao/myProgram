using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TelerikWinformBase
{
    public class RightUserBll
    {
        public static List<RightUser> QueryRightUser(QueryCondition queryCondition)
        {
            return RightUserDal.QueryRightUser(queryCondition);
        }

        public static bool InsertRightUser(RightUser rightUser, out string msg)
        {
            var lstData = RightUserDal.QueryRightUserByUserId(rightUser.UserId);
            if (lstData != null && lstData.Count > 0)
            {
                msg = "工号不能重复";
                return false;
            }
            if (!RightUserDal.Insert(rightUser))
            {
                msg = "增加用户信息保存失败";
                return false;
            }
            msg = "操作成功";
            return true;
        }

        public static bool UpdateRightUser(RightUser rightUser, out string msg)
        {
            var lstData = RightUserDal.QueryRightUserByUserId(rightUser.UserId);
            if (lstData != null)
            {
                foreach (var info in lstData)
                {
                    if (info.Sysid == rightUser.Sysid)
                        continue;

                    msg = "工号不能重复";
                    return false;
                }
            }
            if (!RightUserDal.Update(rightUser))
            {
                msg = "更新用户信息保存失败";
                return false;
            }
            msg = "操作成功";
            return true;
        }

        public static bool DeleteRightUser(RightUser rightUser)
        {
            return RightUserDal.Delete(rightUser);
        }

        public static RightUser QueryRightUserByUserId(string userId)
        {
            var lstData = RightUserDal.QueryRightUserByUserId(userId);
            if (lstData == null || lstData.Count <= 0)
                return null;

            return lstData[0];
        }

        public static bool ChangeSelfPassword(string userId, string currentPwd,
            string newPwd, out string msg)
        {
            var lstData = RightUserDal.QueryRightUserByUserId(userId);
            if (lstData == null || lstData.Count != 1)
            {
                msg = "获取用户信息失败";
                return false;
            }
            var rightUser = lstData[0];
            if (rightUser.UserPwd != ToMd5(currentPwd))
            {
                msg = "当前密码错误";
                return false;
            }
            rightUser.UserPwd = ToMd5(newPwd);
            rightUser.ModifiedBy = userId;
            if (!RightUserDal.Update(rightUser))
            {
                msg = "修改密码保存失败";
                return false;
            }
            msg = "修改密码成功";
            return true;
        }

        public static bool IsAdmin(QueryCondition queryCondition)
        {
            return RightUserDal.IsAdmin(queryCondition);
        }

        //MD5加密字符串
        /// <summary>
        /// MD5加密字符串
        /// </summary>
        /// <param name="sourceStr"></param>
        /// <returns></returns>
        public static string ToMd5(string sourceStr)
        {
            var md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hasher.ComputeHash(Encoding.Unicode.GetBytes(sourceStr));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    
    }
}
