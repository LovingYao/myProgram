using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.IDAL;
using CsiProgram.DAL;

namespace CsiProgram.DBFactory
{
    /// <summary>
    /// 数据层工厂
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// 通过反射，来实例化接口对象
        /// </summary>
        private static readonly string _assembly = "CsiProgram.DAL";//程序集名称
        private static readonly string _path = "CsiProgram.DAL";//命名空间

        /// <summary>
        /// 通过反射机制，实例化接口对象
        /// </summary>
        /// <param name="CacheKey">接口对象名称(键)</param>
        ///<returns>接口对象</returns>
        private static object GetInstance(string CacheKey)
        {
            object objType = DataCache.GetCache(CacheKey);
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(DALFactory._assembly).CreateInstance(CacheKey);
                    DataCache.SetCache(CacheKey, objType);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return objType;
        }

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_C_TestDAL接口对象(测试用)
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_C_TestDAL CSI_C_TestDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_C_TestDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_C_TestDAL)objType;
        //}

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_T_UserDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_UserDAL CSI_T_UserDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_UserDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_UserDAL)objType;
        //}

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_T_TreeDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_TreeDAL CSI_T_TreeDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_TreeDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_TreeDAL)objType;
        //}

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_T_StatusDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_StatusDAL CSI_T_StatusDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_StatusDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_StatusDAL)objType;
        //}

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_OperateProgramDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_OperateProgramDAL CSI_OperateProgramDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_OperateProgramDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_OperateProgramDAL)objType;
        //}

        ///// <summary>
        ///// 通过反射机制，实例化ICSI_T_ProjectUserDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_ProjectUserDAL CSI_T_ProjectUserDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_ProjectUserDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_ProjectUserDAL)objType;
        //}

        ///// 通过反射机制，实例化ICSI_T_ProjectUserDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_ProjectHistoryDAL CSI_T_ProjectHistoryDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_ProjectHistoryDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_ProjectHistoryDAL)objType;
        //}

        ///// 通过反射机制，实例化ICSI_T_ProjectUserDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_TaskDAL CSI_T_TaskDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_TaskDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_TaskDAL)objType;
        //}

        ///// 通过反射机制，实例化ICSI_T_ProjectDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_T_ProjectDAL CSI_T_ProjectDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_T_ProjectDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_T_ProjectDAL)objType;
        //}

        ///// 通过反射机制，实例化ICSI_T_ProjectDAL接口对象
        ///// </summary>
        /////<returns></returns>
        //public static ICSI_BaseGridDAL CSI_BaseGridDALInstance()
        //{
        //    string CacheKey = string.Format("{0}{1}", DALFactory._path, ".Csi_BaseGridDAL");
        //    object objType = DALFactory.GetInstance(CacheKey);
        //    return (ICSI_BaseGridDAL)objType;
        //}







    }
}
