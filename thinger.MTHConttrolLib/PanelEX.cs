using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.MTHConttrolLib
{
    public partial class PanelEX : Panel
    {
        public PanelEX()
        {
            InitializeComponent();


            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private int topGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示上边间隔距离")]
        public int TopGap
        {
            get { return topGap; }
            set
            {
                topGap = value;
                this.Invalidate();
            }
        }

        private int bottomGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示下边间隔距离")]
        public int BottomGap
        {
            get { return bottomGap; }
            set
            {
                bottomGap = value;
                this.Invalidate();
            }
        }

        private int leftGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示左边间隔距离")]
        public int LeftGap
        {
            get { return leftGap; }
            set
            {
                leftGap = value;
                this.Invalidate();
            }

        }

        private int rightGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示右边间隔距离")]
        public int RightGap
        {
            get { return rightGap; }
            set
            {
                rightGap = value;
                this.Invalidate();
            }
        }

        private int borderWidh = 2;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示线条宽度")]
        public int BorderWidh
        {
            get { return borderWidh; }
            set
            {
                borderWidh = value;
                this.Invalidate();
            }
        }

        private Color boderColor = Color.FromArgb(35, 255, 253);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示线条的颜色")]
        public Color BoderColor
        {
            get { return boderColor; }
            set
            {
                boderColor = value;
                this.Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //准备画布
            Graphics graphics= e.Graphics;
            //准备画笔
            Pen pen = new Pen(boderColor,borderWidh);
            //准备矩形参数
            float x = leftGap + borderWidh * 0.5f;
            float y = topGap + borderWidh * 0.5f;
            float width = this.Width-leftGap-rightGap-borderWidh;
            float height = this.Height-topGap-bottomGap -borderWidh;

            //绘制矩形
            graphics.DrawRectangle(pen, x, y, width, height);

        }
    }
}
