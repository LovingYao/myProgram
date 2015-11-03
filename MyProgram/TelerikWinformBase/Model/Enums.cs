using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
  
    public enum MaterialCategory
    {
        CELL,
        EVA,
        TPT,
        BUSBAR,
        GLASS
    }

    public enum EquipmentStatusType
    {
        STARTON,
        RUN,
        STOP

    }
    public enum MonitorStatusType
    {
        STARTON,
        STOP

    }

    public enum EquipmentType
    {
        DT4000,
        AUTOID

    }

    public enum StepType
    {
        StringBusBar,
        LoadTPT,
        Laminating,
        Assembling

    }

    public enum ErrorType
    {
        Fail,
        Repaired,
        Normally
    }

    public enum StatusType
    {
        Active,
        Cancle,
        Commit,
        Warning,
        Waiting
    }

    #region* 查询条件字段 QueryConditionField *
    //查询条件字段
    /// <summary>
    /// 查询条件字段
    /// </summary>
    public enum QueryConditionField
    {
        CATEGORY,

        WORKSHOP ,

        PROTOCOL,

        EQUIPMENT,

        EQUIPMENTIP,

        UserId,

        Code,

        ReasonCategory,

        Name,

        Resv01,

        DepartmentCode,

        InCondition,

        NotInCondition,

    }

    #endregion

    #region* 数据字典 DataDictionary *
    //数据字典 主要用于 FastDropDownList DictionaryCode
    /// <summary>
    /// 数据字典
    /// </summary>
    public enum DataDictionary
    {
        /// <summary>
        /// 车间
        /// </summary>
        Workshop,
        /// <summary>
        /// 部门
        /// </summary>
        Department,
        /// <summary>
        /// 功能命令
        /// </summary>
        FunctionCommand,
        /// <summary>
        /// 公司代码
        /// </summary>
        OrgID,
        /// <summary>
        /// 匹配状态
        /// </summary>
        MatchStatus,
        /// <summary>
        /// 匹配状态（手动匹配）
        /// </summary>
        UserMatch,
        /// <summary>
        /// 运算符
        /// </summary>
        OperatorChar,

        /// <summary>
        /// 出货方式
        /// </summary>
        Action
    }

    #endregion

    //界面操作状态
    /// <summary>
    /// 界面操作状态
    /// </summary>
    public enum OperationStatus
    {
        Default,
        New,
        Edit
    }

    //系统查询配置界面的控件类型
    /// <summary>
    /// 系统查询配置界面的控件类型
    /// </summary>
    public enum QueryCtrlType
    {
        TextBox,
        DropDownList,
        DateTimePicker
    }

    //系统查询配置界面的参数类型
    /// <summary>
    /// 系统查询配置界面的参数类型
    /// </summary>
    public enum ConditionType
    {
        SqlCondition,
        SqlParam
    }

    //Box流程路径
    /// <summary>
    /// Box流程路径
    /// </summary>
    public enum BoxWipPath
    {
        OK,
        NG
    }

    //Box处理状态
    /// <summary>
    /// Box处理状态
    /// </summary>
    public enum BoxProcessStatus
    {
        Created,
        Active,
        Finished,
        Hold,
        OqcFail
    }

    //Box处理方法
    /// <summary>
    /// Box处理方法
    /// </summary>
    public enum BoxWipActionCode
    {
        Create,
        TrackIn,
        Hold,
        UnHold,
        UnFinished,
        RepositionStep,
        ReplaceOldBox,
        ReplaceNewBox,
        OqcConfirmRework
    }

    public enum BoxLogActivity
    {
        Create,
        Packing,
        Vanning,
        OQCTrackOut,
        Devanning,
        ReplaceBox,
        Inventory,
        UnInventory,
        OQCConfirmRework,
        OQCHold,
        OQCUnHold
    }

    #region * FastControl *

    public enum FastTextBoxUsageFor
    {
        /// <summary>
        /// 工单号
        /// </summary>
        OrderNo,
        /// <summary>
        /// 产品
        /// </summary>
        ProductName,
        /// <summary>
        /// 物料编号
        /// </summary>
        MaterialCode,
        /// <summary>
        /// 网版产品属性
        /// </summary>
        HalftoneAttribute,
        /// <summary>
        /// 备注
        /// </summary>
        Remark,
        /// <summary>
        /// QC检查的标准
        /// </summary>
        InspectionStandard,
        //计划单号
        /// <summary>
        /// 计划单号
        /// </summary>
        PlanOrderNo,
        //OQC确认记录
        /// <summary>
        /// OQC确认记录
        /// </summary>
        OqcConfirm,
        //抽检国标
        /// <summary>
        /// 抽检国标
        /// </summary>
        AqlSampleSolution
    }

    public enum FastDropDownListUsageFor
    {
        DictionaryItem,
        Dictionary,
        MesStep,
        // 后道工序
        BackStep,
        UserGroup,
        FunctionGroup,
        DutyPlan,
        MesEquipments,
        MaterialCode,
        ProductName,
        DutyPost,
        CustomQuery,
        ViewPostEquipment,
        BatchNo,
        IpAddress,
        ReasonCode,
        ReasonCategory,
        //刻蚀设备组
        /// <summary>
        /// 刻蚀设备组
        /// </summary>
        EtchingGroup,
        //网版类型:背电极/背电场/正电极
        /// <summary>
        /// 网版类型
        /// </summary>
        HalftoneType,
        //网版型号
        /// <summary>
        /// 网版型号：156P/156M/125P/125M/156类单晶/156ESE
        /// </summary>
        HalftoneModel,
        //硅片类型
        /// <summary>
        /// 硅片类型
        /// </summary>
        WaferType,
        //硅片规格型号
        /// <summary>
        /// 硅片规格型号
        /// </summary>
        WaferModel,
        //硅片料号
        /// <summary>
        /// 硅片料号
        /// </summary>
        WaferMaterialCode,
        //浆料类型
        /// <summary>
        /// 浆料类型
        /// </summary>
        PasteType,
        //浆料规格型号
        /// <summary>
        /// 浆料规格型号
        /// </summary>
        PasteModel,
        //浆料料号
        /// <summary>
        /// 浆料料号
        /// </summary>
        PasteMaterialCode,
        //
        /// <summary>
        /// 
        /// </summary>
        HalftoneProductName,
        //责任工序
        /// <summary>
        /// 责任工序
        /// </summary>
        DutyStep,
        //版型 产品类型
        /// <summary>
        /// 版型 产品类型
        /// </summary>
        MesProductCategory,
        //物料类型
        /// <summary>
        /// 物料类型
        /// </summary>
        MesMaterialCategory,
        //BOM中的物料代码
        /// <summary>
        /// BOM中的物料代码
        /// </summary>
        BomMaterialCode,
        //库存ERP批次
        /// <summary>
        /// 库存ERP批次
        /// </summary>
        StockErpBatch,
        //库存物料料号
        /// <summary>
        /// 库存物料料号
        /// </summary>
        StockPartName,
        //待确认库存
        /// <summary>
        /// 待确认库存
        /// </summary>
        StockLotId,
        //设备类型
        /// <summary>
        /// 设备类型
        /// </summary>
        MesEqpType,
        //设备型号
        /// <summary>
        /// 设备型号
        /// </summary>
        MesEqpModel,
        /// <summary>
        /// 印刷方案
        /// </summary>
        HalftonePrintModel,
        /// <summary>
        /// 设备状态
        /// </summary>
        MesEqpState,
        /// <summary>
        /// 班别(五天内)
        /// </summary>
        TeamCode,
        /// <summary>
        /// 首件点检时机
        /// </summary>
        FirstItemOpportunity
    }
    #endregion

    //消息类型
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType
    {
        //普通消息：绿色
        /// <summary>
        /// 普通消息：绿色
        /// </summary>
        Info,
        //警告消息：黄色
        /// <summary>
        /// 警告消息：黄色
        /// </summary>
        Warn,
        //错误消息：红色
        /// <summary>
        /// 错误消息：红色
        /// </summary>
        Error
    }

    public enum BatchNoStatus
    {
        Created,
        Started,
        TestingFinished,
        Finished
    }

    public enum DictionaryCategory
    {
        Dictionary,
        ReasonCode
    }

    //Lot标签类型
    /// <summary>
    /// Lot标签类型
    /// </summary>
    public enum BarcodeType
    {
        //良品
        /// <summary>
        /// 良品
        /// </summary>
        G,
        //不良
        /// <summary>
        /// 不良
        /// </summary>
        NG,
        //B级
        /// <summary>
        /// B级
        /// </summary>
        B,
        //返工
        /// <summary>
        /// 返工
        /// </summary>
        Rework
    }

    public enum SystemCommand
    {
        //当前截屏
        CurrentScreen
    }

    public enum Languages
    {
        LanguageCN,
        LanguageEN,
        LanguageUS,
        LanguageTW
    }

    public enum CommandButton
    {
        Add,
        Edit,
        Submit,
        Save,
        Cancel,
        Delete,
        Print,
        RefreshData,
        Query,
        Import,
        Export,
        Help,
        Close
    }

    /// <summary>
    /// 锁定因素
    /// </summary>
    public enum LockedFactor
    {
        FqcUser,
        /// <summary>
        /// 后道工序
        /// </summary>
        BackStep,
        Equipment,
        /// <summary>
        /// 前道工序
        /// </summary>
        StepEquipment
    }

    public enum OqcStatus
    {
        Active,
        Hold,
        OqcFail,
        OqcFailConfirmed
    }

    public enum DictionaryField
    {
        CATEGORY,
        Protocol,
        MonitorDevice,
        Workshop

    }
}
