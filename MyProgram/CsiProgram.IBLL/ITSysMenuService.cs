using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.Entity;
namespace CsiProgram.IBLL
{
    public partial interface ITSysMenuService : IBaseService<T_SYS_MENU>
    {
        
        /// <summary>
        /// 获取用户分页列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable<T_SYS_MENU> LoadSearchData(QueryCondition query);

        bool existMenuName(T_SYS_MENU info);

        IQueryable<T_SYS_MENU> LoadAllData();
    }
}
