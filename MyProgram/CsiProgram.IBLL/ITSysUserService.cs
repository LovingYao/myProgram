using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.Entity;

namespace CsiProgram.IBLL
{
    public partial interface ITSysUserService : IBaseService<T_SYS_USER>
    {
        /// <summary>
        /// 接口约束，检查用户登录的信息
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        T_SYS_USER checkUserLogin(T_SYS_USER userinfo);
        /// <summary>
        /// 获取用户分页列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable<T_SYS_USER> LoadSearchData(QueryCondition query);

        bool existUser(T_SYS_USER userinfo);
    }
}
