using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsiProgram.EFModel;
using CsiProgram.IBLL;
using CsiProgram.BLL;
using CsiProgram.Entity;
using System.Web.Script.Serialization;
using System.Text;

namespace ProgramManagementWeb.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        ITSysUserService iTSysUser = new TSysUserService();
        ITSysMenuService iTSysMenu = new TSysMenuService();

        #region 登录页面
        public ActionResult Login()
        {
            return View();
        }

        #region 登录判断

        public ActionResult DoLogin()
        {
            int res = 0;
            T_SYS_USER user = new T_SYS_USER();
            user.USERNAME = Request.Form["username"].ToLower();
            user.PASSWORD= Request.Form["password"];
            if (string.IsNullOrEmpty(user.USERNAME))
            {
                res = -1;
            }
            else
            {
                var iUser=iTSysUser.checkUserLogin(user);
                if (iUser == null)
                {
                    res = -2;
                }
                else
                {
                    Session["user"] = iUser;
                }

            }
            return Content(res.ToString());
        }
        #endregion 登录判断结束

        #region 注销登录
        public ActionResult Logout()
        {
            int res = 0;
            try
            {
                Session.RemoveAll();
                Session.Clear();
            }
            catch (Exception)
            {

                res = -1;
            }
            return Content(res.ToString());
        }
        #endregion 注销登录结束

        #endregion

        #region 用户管理页面
        public ActionResult UserMain()
        {
            return View();
        }

        #region 显示数据
        public ActionResult UsersReadUsersSelect()
        {
            QueryCondition qc = new QueryCondition();
            qc.pageIndex = Request.Form["page"] == null ? 1 : Convert.ToInt32(Request.Form["page"]);
            qc.pageSize = Request.Form["rows"] == null ? 10 : Convert.ToInt32(Request.Form["rows"]);
            var list = iTSysUser.LoadSearchData(qc);
            var data = new { total = qc.total, rows = list };
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string json = javaScriptSerializer.Serialize(data);
            return Content(json.ToString());
        }
        #endregion

        #region 添加用户
        public ActionResult AddUsersSelect()
        {
            T_SYS_USER SessionUser = Session["user"] as T_SYS_USER;

            T_SYS_USER user = new T_SYS_USER();
            user.USERNAME = Request.Form["UserName"];
            user.PASSWORD = Request.Form["UserPWD"];
            user.NICKNAME=Request.Form["NickName"];
            user.IS_ACTIVE = "Y";
            user.EMAIL = Request.Form["UserEmail"];
            user.CELLPHONE = Request.Form["UserPhonenumber"];
            user.CREATED_ON = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            user.CREATED_BY = SessionUser.USERNAME;
           
            int res = 0;

            if (!iTSysUser.existUser(user))
            {
                iTSysUser.AddEntities(user);
       
                res = 1;

            }
            else
            {
                res = -1;
            }

            return Content(res.ToString());
        }
        #endregion

        #region 修改用户//修改密码处需要修改
        public ActionResult editUsersSelect(int id)
        {

            T_SYS_USER user = new T_SYS_USER();
            user.ID = id;
            user.USERNAME = Request.Form["UserName"];
            user.PASSWORD = Request.Form["UserPWD"];
            user.NICKNAME = Request.Form["NickName"];
            user.IS_ACTIVE = "Y";
            user.EMAIL = Request.Form["UserEmail"];
            user.CELLPHONE = Request.Form["UserPhonenumber"];
            user.CREATED_ON = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            user.CREATED_BY = "Admin";

            int res = 0;

            try
            {
                iTSysUser.UpdateEntities(user);
                res = 1;
            }
            catch
            {
                res = -1;
            }
            
            return Content(res.ToString());
        }
        #endregion

        #region 删除用户
        public ActionResult delUsersSelect(int id)
        {
            int res = 0;
            T_SYS_USER user = new T_SYS_USER();
            user.ID = id;

            iTSysUser.DeleteEntities(user);

            res = 1;
           
            return Content(res.ToString());
        }
        #endregion

        #endregion

        #region 导航菜单管理页面

        public ActionResult MenuMain()
        {
            return View();
        }

        public ActionResult GetMenuLeft()
        {
            var list = iTSysMenu.LoadAllData();
            StringBuilder Json = new StringBuilder();
            string jsonName = "menus";
            Json.Append("{\"" + jsonName + "\":[");
            var listTreeMain = list.Where(u => u.PARENT_ID == 0).ToList();
            if (listTreeMain.Count > 0)
            {
                foreach (var item in listTreeMain)
                {
                    Json.Append("{");
                    Json.Append("\"menuid\": \"" + item.SORT + "\", \"icon\": \"icon-sys\", \"menuname\": \"" + item.MENU_NAME + "\",");
                    var listTreeParent = list.Where(u => u.PARENT_ID == item.ID).ToList();
                    if (listTreeParent.Count > 0)
                    {
                        Json.Append("\"menus\": [");
                        foreach (var itemParent in listTreeParent)
                        {
                            Json.Append("{ \"menuid\": \"" + itemParent.SORT + "\", \"menuname\": \"" + itemParent.MENU_NAME + "\", \"icon\": \"icon-nav\", \"url\": \"" + itemParent.MENU_HREF + "\" },");
                        }
                        Json = Json.Remove(Json.Length - 1, 1);
                        Json.Append("]},");
                    }
                    else
                    {
                        Json = Json.Remove(Json.Length - 1, 1);
                        Json.Append("},");
                    }

                }

                Json = Json.Remove(Json.Length - 1, 1);
                Json.Append("]}");

            }


            return Content(Json.ToString());
        }

       

        #region 显示数据
        public ActionResult MenuSelect()
        {
            QueryCondition qc = new QueryCondition();
            qc.pageIndex = Request.Form["page"] == null ? 1 : Convert.ToInt32(Request.Form["page"]);
            qc.pageSize = Request.Form["rows"] == null ? 10 : Convert.ToInt32(Request.Form["rows"]);
            var list = iTSysMenu.LoadSearchData(qc);
            var data = new { total = qc.total, rows = list };
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string json = javaScriptSerializer.Serialize(data);
            return Content(json.ToString());
        }
        #endregion

        //#region 添加用户
        //public ActionResult AddUsersSelect()
        //{
        //    T_SYS_USER SessionUser = Session["user"] as T_SYS_USER;

        //    T_SYS_MENU menu = new T_SYS_MENU();
        //    menu.MENU_NAME = Request.Form["MENU_NAME"];
        //    menu.MENU_TYPE = Request.Form["MENU_TYPE"];
        //    menu.MENU_HREF = Request.Form["MENU_HREF"];
        //    menu.IS_ACTIVE = "Y";
        //    menu.PARENT_ID = int.Parse(Request.Form["PARENT_ID"]);
        //    menu.SORT = int.Parse(Request.Form["SORT"]);
        //    menu.CREATED_ON = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        //    menu.CREATED_BY = SessionUser.USERNAME;

        //    int res = 0;

        //    if (!iTSysMenu.existMenuName(menu))
        //    {
        //        iTSysMenu.AddEntities(menu);

        //        res = 1;

        //    }
        //    else
        //    {
        //        res = -1;
        //    }

        //    return Content(res.ToString());
        //}
        //#endregion

        //#region 修改用户//修改密码处需要修改
        //public ActionResult editUsersSelect(int id)
        //{

        //    T_SYS_USER user = new T_SYS_USER();
        //    user.ID = id;
        //    user.USERNAME = Request.Form["UserName"];
        //    user.PASSWORD = Request.Form["UserPWD"];
        //    user.NICKNAME = Request.Form["NickName"];
        //    user.IS_ACTIVE = "Y";
        //    user.EMAIL = Request.Form["UserEmail"];
        //    user.CELLPHONE = Request.Form["UserPhonenumber"];
        //    user.CREATED_ON = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        //    user.CREATED_BY = "Admin";

        //    int res = 0;

        //    try
        //    {
        //        iTSysUser.UpdateEntities(user);
        //        res = 1;
        //    }
        //    catch
        //    {
        //        res = -1;
        //    }

        //    return Content(res.ToString());
        //}
        //#endregion

        //#region 删除菜单
        //public ActionResult delUsersSelect(int id)
        //{
        //    int res = 0;
        //    T_SYS_MENU menu = new T_SYS_MENU();
        //    menu.ID = id;

        //    iTSysMenu.DeleteEntities(menu);

        //    res = 1;

        //    return Content(res.ToString());
        //}
        //#endregion

        #endregion
        
        #region 角色管理页面
        /// <summary>
        /// 角色管理
        /// </summary>
        /// <returns></returns>
        public ActionResult UserGroupMain()
        {
            return View();
        }
        #endregion

    }
}
