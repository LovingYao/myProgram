function formatProgress(value) {
    if (value) {
        var s = '<div style="width:100%;border:1px solid #ccc">' +
                '<div style="width:' + value + '%;background:#cc0000;color:#fff">' + value + '%' + '</div>'
        '</div>';
        return s;
    } else {
        return '';
    }
}
var editingId;
function edit() {
    if (editingId != undefined) {
        $('#tg').treegrid('select', editingId);
        return;
    }
    var row = $('#tg').treegrid('getSelected');
    if (row) {
        editingId = row.ID
        $('#dlg2').dialog('open').dialog('setTitle', '修改ID=' + row.ID + '分类名:' + row.name);
        $('#fm2').form('clear');
        url = '/SuperviseManagement/Commodityupdatetree?ID=' + row.ID + '&parendId=' + row.parendId + '';
    }
}
function cancel() {
    if (editingId != undefined) {
        $('#tg').treegrid('cancelEdit', editingId);
        editingId = undefined;
    }
}



function add() {
    $('#dlg').dialog('open').dialog('setTitle', '添加');
    $('#fm').form('clear');
    url = '/SuperviseManagement/Commodityaddtree';
}

function savetree() {

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
                $('#tg').treegrid('reload');
                $('#combotree').combotree('reload');
                $("#tt").tree('reload');
                $('#dlg').dialog('close');
                $.messager.show({
                    title: '提示',
                    msg: '操作成功',
                    showType: 'show'
                });
            }
        }
    });
}
function updatetree() {

    $('#fm2').form('submit', {
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
                $('#tg').treegrid('reload');
                $('#combotree').combotree('reload');
                $('#tt').tree('reload');
                $('#dlg2').dialog('close');
                cancel();
                $.messager.show({
                    title: '提示',
                    msg: '操作成功',
                    showType: 'show'
                });
            }
        }
    });
}


   
