using CsiProgram.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.DAL;
using CsiProgram.EFDAL;

namespace CsiProgram.DBFactory
{
    /// <summary>
    /// 简单工厂实现低耦合，数据库访问层的统一入口
    /// </summary>
    /// 尽量的去依赖接口编程
    public partial class RepositoryFactory
    {

        public static ITSysUserRepository TSysUserRepository
        {
            get
            {
                return new TSysUserRepository();
            }
        }

        public static ITSysMenuRepository TSysMenuRepository
        {
            get
            {
                return new TSysMenuRepository();
            }
        }

    }
}
