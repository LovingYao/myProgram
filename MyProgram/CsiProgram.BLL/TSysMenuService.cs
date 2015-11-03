using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.EFModel;
using CsiProgram.IBLL;
using CsiProgram.IDAL;
using CsiProgram.EFDAL;
using CsiProgram.DBFactory;
using CsiProgram.Entity;

namespace CsiProgram.BLL
{
    public partial class TSysMenuService : BaseService<T_SYS_MENU>, ITSysMenuService
    {
        //简单工厂：创建实例，不再依赖具体的实例的类型
        private ITSysMenuRepository _userInfoRepository = RepositoryFactory.TSysMenuRepository;

        public override void SetCurrentRepository()
        {
            CurrentRepository = RepositoryFactory.TSysMenuRepository;
        }

        /// <summary>
        /// 是否存在munuName
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool existMenuName(T_SYS_MENU info)
        {
            return _userInfoRepository.existMenuName(info);
        }
        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IQueryable<T_SYS_MENU> LoadSearchData(QueryCondition query)
        {
            return _userInfoRepository.LoadSearchData(query);
        }

        /// <summary>
        /// 获取所有的数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<T_SYS_MENU> LoadAllData()
        {
            return _userInfoRepository.LoadAllData();
        }

        
    }
}
