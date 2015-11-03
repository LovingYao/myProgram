using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.IDAL;
using CsiProgram.Entity;

namespace CsiProgram.EFDAL
{
    public partial class TSysMenuRepository: BaseRepository<T_SYS_MENU>, ITSysMenuRepository
    {

        /// <summary>
        /// 检查导航名是否存在
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public bool existMenuName(T_SYS_MENU info)
        {
            var result = LoadEntities(u => u.MENU_NAME == info.MENU_NAME).FirstOrDefault();
            return result == null ? false : true;
        }

        /// <summary>
        /// 加载用户模糊查询的数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IQueryable<T_SYS_MENU> LoadSearchData(QueryCondition query)
        {
            //拿到所有的数据
            var temp = LoadEntities(u => true);

            //返回总数
            query.total = temp.Count();

            //做分页查询
            return temp.Skip(query.pageSize * (query.pageIndex - 1)).Take(query.pageSize).AsQueryable();

        }

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IQueryable<T_SYS_MENU> LoadAllData()
        {
            //拿到所有的数据
            var temp = LoadEntities(u => true);

            //做分页查询
            return temp;

        }
    }
}
