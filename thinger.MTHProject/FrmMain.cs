using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.MTHConttrolLib;
using thinger.MTHModels;

namespace thinger.MTHProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通用窗体切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonNaviButton_Click(object sender, EventArgs e)
        {
            if (sender is NaviButton navi)
            {
                if (Enum.IsDefined(typeof(FormNames),navi.TitleName))
                {
                    //拿到导航按钮对应的窗体枚举值
                    FormNames formNames = (FormNames)Enum.Parse(typeof(FormNames), navi.TitleName, true);

                    //窗体切换
                    OpenFrom(this.MainPanel, formNames);

                    //设置Title
                    SetTitle(this.lbl_Title, formNames);

                    //设置选中
                    SetNaviButton(this.TopPanel, navi);
                }
                
            }
        }

        /// <summary>
        /// 通用打开窗体
        /// </summary>
        /// <param name="mainPanel">容器控件</param>
        /// <param name="frmNmaes">窗体枚举名称</param>
        private  void OpenFrom(Panel mainPanel, FormNames frmNmaes)
        {
            int total=MainPanel.Controls.Count;
            int closeCount = 0;
            bool isFind = false;
            for (int i = 0; i < total; i++)
            {
                Control ct = mainPanel.Controls[i-closeCount];
                if (ct is Form frm)
                {
                    //如果当前Form是我们需要的窗体
                    if (frm.Text==frmNmaes.ToString())
                    {
                        frm.BringToFront();
                        isFind= true;
                        break;
                    }
                    //如果当前Form不是我们需要的窗体,判断是否为固定窗体，如果不是则关闭，如果是则不作处理
                    else if ((FormNames)Enum.Parse(typeof(FormNames), frm.Text, true)>= FormNames.临界窗体)
                    {
                        frm.Close();
                        closeCount++;
                    }
                }
            }

            if (isFind==false)
            {
                Form frm = null;
                switch (frmNmaes)
                {
                    case FormNames.集中监控:
                        frm = new FrmMonitor();
                        break;
                    case FormNames.参数设置:
                        frm = new FrmParamSet();
                        break;
                    case FormNames.配方管理:
                        frm = new FrmRecipe();
                        break;
                    case FormNames.报警追溯:
                        frm = new FrmAlarm();
                        break;
                    case FormNames.历史趋势:
                        frm = new FrmHistory();
                        break;
                    case FormNames.用户管理:
                        frm = new FrmUserManager();
                        break;
                    default:
                        break;
                }


                if (frm!=null)
                {
                    //设置非顶层窗体
                    frm.TopLevel = false;
                    //去除边框
                    frm.FormBorderStyle= FormBorderStyle.None;

                    //填充
                    frm.Dock= DockStyle.Fill;

                    //设置父容器为容器控件
                    frm.Parent= mainPanel;

                    //置前
                    frm.BringToFront();

                    //显示
                    frm.Show();
                }
            }
        }

        /// <summary>
        /// 设置标题内容
        /// </summary>
        /// <param name="label">标题控件</param>
        /// <param name="formNmaes">窗体枚举名称</param>
        private void SetTitle(Label label, FormNames formNmaes)
        {
            label.Text=formNmaes.ToString();
        }

        /// <summary>
        /// 设置导航按钮的选中
        /// </summary>
        /// <param name="topPanel">导航按钮的容器</param>
        /// <param name="naviButton">导航按钮</param>
        private void SetNaviButton(Panel topPanel, NaviButton naviButton)
        {
            foreach (var item in TopPanel.Controls.OfType<NaviButton>())
            {
                item.IsSelect = false;

            }
            naviButton.IsSelect = true;
        }

        #region 减少闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}
