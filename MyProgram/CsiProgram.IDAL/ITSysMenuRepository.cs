using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.Entity;

namespace CsiProgram.IDAL
{
    public partial interface ITSysMenuRepository : IBaseRepository<T_SYS_MENU>
    {

        /// <summary>
        /// 是否存在导航名
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        bool existMenuName(T_SYS_MENU info);

        /// <summary>
        /// 获取用户分页列表 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable<T_SYS_MENU> LoadSearchData(QueryCondition query);

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable<T_SYS_MENU> LoadAllData();

    }
}
