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
    public partial class TSysUserService : BaseService<T_SYS_USER>, ITSysUserService
    {

        //简单工厂：创建实例，不再依赖具体的实例的类型
        private ITSysUserRepository _userInfoRepository = RepositoryFactory.TSysUserRepository;

        public override void SetCurrentRepository()
        {
            CurrentRepository = RepositoryFactory.TSysUserRepository;
        }
        /// <summary>
        /// 检验用户是否登录成功
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public T_SYS_USER checkUserLogin(T_SYS_USER userinfo)
        {
            //return null;
            //判断用户的用户名密码是否正确
            return _userInfoRepository.checkUserLogin(userinfo);
        }

        public bool existUser(T_SYS_USER userinfo)
        {
            return _userInfoRepository.existUser(userinfo);
        }

        public IQueryable<T_SYS_USER> LoadSearchData(QueryCondition query)
        {
            return _userInfoRepository.LoadSearchData(query);
        }
    }
}
