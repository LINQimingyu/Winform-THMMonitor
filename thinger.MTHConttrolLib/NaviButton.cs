using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHConttrolLib
{
    [DefaultEvent("Click")]
    public partial class NaviButton : UserControl
    {
        public NaviButton()
        {
            InitializeComponent();
            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        }


        private bool isSelected = false;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮是否选中")]
        public bool IsSelect
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                UpDataImage();
            }
        }

        private bool isLeft = true;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮是否为左边")]
        public bool IsLeft
        {
            get { return isLeft; }
            set
            {
                isLeft = value;
                UpDataImage();
            }
        }

        private string titleName = "导航按钮";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示导航按钮文本的内容")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.lbl_Title.Text = titleName;
            }
        }





        /// <summary>
        /// 统一更新背景
        /// </summary>
        private void UpDataImage()
        {
            if (this.isLeft)
            {
                this.BackgroundImage = isSelected ? Properties.Resources.LeftSelected : Properties.Resources.LeftUnSelected;
            }
            else
            {
                this.BackgroundImage = isSelected ? Properties.Resources.RightSelected : Properties.Resources.RightUnSelected;
            }
        }


        public new  EventHandler Click;
        [Browsable(true)]
        [Category("自定义事件")]
        [Description("设置或显示导航按钮文本的内容")]
        private void lbl_Title_Click(object sender, EventArgs e)
        {
            if (this.Click!=null)
            {
                this.Click?.Invoke(this, e);
            }
        }
    }
}
