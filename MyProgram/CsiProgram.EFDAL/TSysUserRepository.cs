using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.IDAL;
using CsiProgram.Entity;

namespace CsiProgram.EFDAL
{
    public partial class TSysUserRepository : BaseRepository<T_SYS_USER>, ITSysUserRepository
    {
        /// <summary>
        /// 验证用户
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public T_SYS_USER checkUserLogin(T_SYS_USER userinfo)
        {
            return LoadEntities(u => u.USERNAME == userinfo.USERNAME && u.PASSWORD == userinfo.PASSWORD).FirstOrDefault();
        }

        /// <summary>
        /// 检查登录名是否存在
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public bool existUser(T_SYS_USER userinfo)
        {
            var result= LoadEntities(u => u.USERNAME == userinfo.USERNAME).FirstOrDefault();
            return result == null ? false : true;
        }

        /// <summary>
        /// 加载用户模糊查询的数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IQueryable<T_SYS_USER> LoadSearchData(QueryCondition query)
        {
            //拿到所有的数据
            var temp = LoadEntities(u => true);

            //返回总数
            query.total = temp.Count();

            //做分页查询
            return temp.Skip(query.pageSize * (query.pageIndex - 1)).Take(query.pageSize).AsQueryable();

        }
    }
}
