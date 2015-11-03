//注销
function Logout() {
    $.messager.confirm("提示", "是否要注销登录？", function (r) {
        if (r) {
            $.post("/account/Logout", function (data) {
                if (data == "-1") {
                    $.messager.alert('警告', '注销失败');
                } else {
                    window.location.href = "/account/Login";
                }
            }
       );
        }
    });
}