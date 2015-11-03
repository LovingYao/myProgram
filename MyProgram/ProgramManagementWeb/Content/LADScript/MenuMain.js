//添加用户
var url;

function newUser() {
    $('#dlg').dialog('open').dialog('setTitle', '添加');
    $('#fm').form('clear');
    url = '/Account/AddUsersSelect';
}
//保存用户
function saveUser() {
    $('#fm').form('submit', {
        url: url,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (date) {
            if (date == "-2") {
                $.messager.alert('警告', '操作失败啦', 'error');
            }
            else if (date == "-1") {
                $.messager.alert('警告', '同名了', 'error');
            }
            else {
                $('#dlg').dialog('close');
                $('#dg').datagrid('reload');
                // $.messager.alert('警告', '操作成功');
                $.messager.show({
                    title: '提示',
                    msg: '操作成功',
                    showType: 'show'
                });
            }
        }
    });
}
//修改用户
function editUser() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $('#dlg').dialog('open').dialog('setTitle', '修改');
        $('#fm').form('load', row);
        // $('#UserName').attr('readonly', 'readonly').css({ "color": "red" });控制不可以修改
        url = '/Account/editUsersSelect/' + row.ID;
    }
}
//删除用户
function destroyUser() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $.messager.confirm('提示', '确定要删除该用户信息吗?', function (r) {
            if (r) {
                $.post('/Account/delUsersSelect/' + row.ID, function (date) {
                    if (date == "-2") {
                        $.messager.alert('警告', '操作失败啦', 'error');
                    }
                    else {

                        $('#dg').datagrid('reload');
                        $.messager.show({
                            title: '提示',
                            msg: '操作成功',
                            showType: 'show'
                        });

                    }
                }, 'json');
            }
        });
    }
}
$(function () {
    $('#cc').combo({
        required: true,
        editable: false
    });
    $('#sp').appendTo($('#cc').combo('panel'));
    $('#sp input').click(function () {
        var v = $(this).val();
        var s = $(this).next('span').text();
        $('#cc').combo('setValue', v).combo('setText', s).combo('hidePanel');
    });
});



