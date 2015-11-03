$(function () {
    $('#LoginDIV').window({
        width: 300,
        height: 180,
        modal: true,
        closable: false,
        collapsible: false,
        minimizable: false,
        maximizable: false,
        draggable: false,
        resizable: false
       
    });

});


//登录
function Login() {
    var username = $('#username').val();
    var password = $('#password').val();
    if (username != "" && password!="") {
        var win = $.messager.progress({
            title: '提示',
            msg: '查询数据是否正确.....'
        });
        setTimeout(function () {
            $.messager.progress('close');            
            $.post("/Account/DoLogin", { "username": username, "password": password },
                    function (data) {

                        if (data == "-2") {
                            $.messager.alert('警告', '用户名或者密码错误');
                        }
                        else {
                            window.location.href = "/Home/Management";
                        }
                    }
                 );
           
        }, 3000)
    }
    else {        $.messager.alert('警告', '用户名字不能为空');     }
             
}
