using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;  

namespace MyTestDemo
{
    public partial class AlertWindows : Form
    {
        #region 变量
        private InformStyle InfoStyle = InformStyle.Vanish;//定义变量为隐藏  
        private System.Drawing.Rectangle Rect;//定义一个存储矩形框的数组  
        private bool isMouseMove = false;//是否在窗体中移动  
        static private AlertWindows alertwindows = new AlertWindows();//实例化当前窗体  
        #endregion  

        #region 内置属性
        /// <summary>  
        /// 定义一个任务通知器的枚举值  
        /// </summary>//InformStyle  
        protected enum InformStyle
        {
            /// <summary>  
            /// 隐藏  
            /// </summary>  
            Vanish = 0,
            /// <summary>  
            /// 显视  
            /// </summary>  
            Display = 1,
            /// <summary>  
            /// 显视中  
            /// </summary>  
            Displaying = 2,
            /// <summary>  
            /// 隐藏中  
            /// </summary>  
            Vanishing = 3
        }

        /// <summary>  
        /// 获取或设置当前的操作状态  
        /// </summary>  
        protected InformStyle InfoState
        {
            get { return this.InfoStyle; }
            set { this.InfoStyle = value; }
        }
        #endregion  

        public AlertWindows()
        {
            InitializeComponent();
            this.alerttimer.Stop();//停止计时器  
            //初始化工作区大小  
            System.Drawing.Rectangle rect = System.Windows.Forms.Screen.GetWorkingArea(this);
            this.Rect = new System.Drawing.Rectangle(rect.Right - this.Width - 1, rect.Bottom - this.Height - 1, this.Width, this.Height);
        }

        #region 返回当前窗体的实例化
        /// <summary>  
        /// 返回此对象的实例  
        /// </summary>  
        /// <returns></returns>  
        static public AlertWindows Instance()
        {
            return alertwindows;
        }
        #endregion

        #region 声明WinAPI
        /// <summary>  
        /// 显示窗体  
        /// </summary>  
        /// <param name="hWnd"></param>  
        /// <param name="nCmdShow"></param>  
        /// <returns></returns>  
        [DllImport("user32.dll")]
        private static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);
        #endregion

        #region 方法
        /// <summary>  
        /// 显示窗体  
        /// </summary>  
        public void Show(string value)
        {
            this.label2.Text = value;
            switch (this.InfoState)
            {
                case InformStyle.Vanish://窗体隐藏  
                    this.InfoState = InformStyle.Displaying;//设置窗体的操作状态为显示中  
                    this.SetBounds(Rect.X, Rect.Y + Rect.Height, Rect.Width, 0);//显示Popup窗体，并放置到屏幕的底部  
                    ShowWindow(this.Handle, 4);//显示窗体  
                    this.alerttimer.Interval = 100;//设置时间间隔为100  
                    this.alerttimer.Start();//启动计时器  
                    break;
                case InformStyle.Display://窗体显示  
                    this.alerttimer.Stop();//停止计时器  
                    this.alerttimer.Interval = 5000;//设置时间间隔为5000  
                    this.alerttimer.Start();//启动记时器  
                    break;
            }
        }
        #endregion

        #region timer事件
        private void alerttimer_Tick_1(object sender, EventArgs e)
        {
            switch (this.InfoState)
            {
                case InformStyle.Display://显示当前窗体  
                    this.alerttimer.Stop();//停止计时器  
                    this.alerttimer.Interval = 100;//设置时间间隔为100  
                    if (!(this.isMouseMove))//如果鼠标不在窗体中移动  
                        this.InfoState = InformStyle.Vanishing;//设置当前窗体的操作状态为隐藏中  
                    this.alerttimer.Start();//启动计时器  
                    break;
                case InformStyle.Displaying://当前窗体显示中  
                    if (this.Height <= this.Rect.Height - 12)//当窗体没有完全显示时  
                        this.SetBounds(Rect.X, this.Top - 12, Rect.Width, this.Height + 12);//使窗体不断上移  
                    else
                    {
                        this.alerttimer.Stop();//停止计时器  
                        this.SetBounds(Rect.X, Rect.Y, Rect.Width, Rect.Height);//设置当前窗体的边界  
                        this.InfoState = InformStyle.Display;//设置当前窗体的操作状态为显示  
                        this.alerttimer.Interval = 5000;//设置时间间隔为5000  
                        this.alerttimer.Start();//启动计时器  
                    }
                    break;
                case InformStyle.Vanishing://隐藏当前窗体  
                    if (this.isMouseMove)//如果鼠标在窗体中移动  
                        this.InfoState = InformStyle.Displaying;//设置窗体的操作状态为显示  
                    else
                    {
                        if (this.Top <= this.Rect.Bottom - 12)//如果窗体没有完全隐藏  
                            this.SetBounds(Rect.X, this.Top + 12, Rect.Width, this.Height - 12);//使窗体不断下移  
                        else
                        {
                            this.Hide();//隐藏当前窗体  
                            this.InfoState = InformStyle.Vanish;//设置窗体的操作状态为隐藏  
                        }
                    }
                    break;
            }
        }
        #endregion
    }
}
