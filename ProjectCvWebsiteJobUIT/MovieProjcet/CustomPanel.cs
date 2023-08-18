using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieProjcet
{
    public class RJPanel : Panel
    {

        // Fields
        //private int borderRadius = 30;
        private int borderRadiusTopLeft = 30;
        private int borderRadiusTopRight = 30;
        private int borderRadiusBotLeft = 30;
        private int borderRadiusBotRight = 30;
        private float gradientAng = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Constructor
        public RJPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);
        }

        // Properties
        [Category("RJ Code Advance")]
        public int BorderRadiusTopLeft
        {
            get => borderRadiusTopLeft;
            set
            {
                borderRadiusTopLeft = value;
                this.Invalidate();
            }
        }
        public int BorderRadiusTopRight
        {
            get => borderRadiusTopRight;
            set
            {
                borderRadiusTopRight = value;
                this.Invalidate();
            }
        }
        public int BorderRadiusBotLeft
        {
            get => borderRadiusBotLeft;
            set
            {
                borderRadiusBotLeft = value;
                this.Invalidate();
            }
        }
        public int BorderRadiusBotRight
        {
            get => borderRadiusBotRight;
            set
            {
                borderRadiusBotRight = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public float GradientAng
        {
            get => gradientAng;
            set
            {
                gradientAng = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        // Methods
        private GraphicsPath GetRJPanel(RectangleF rectangle, float radiusTL, float radiusTR, float radiusBL, float radiusBR)
        {
            GraphicsPath f = new GraphicsPath();
            f.StartFigure();
            f.AddArc(rectangle.Width - radiusTL, rectangle.Height - radiusTL, radiusTL, radiusTL, 0, 90);
            f.AddArc(rectangle.X, rectangle.Height - radiusTR, radiusTR, radiusTR, 90, 90);
            f.AddArc(rectangle.X, rectangle.Y, radiusBL, radiusBL, 180, 90);
            f.AddArc(rectangle.Width - radiusBR, rectangle.Y, radiusBR, radiusBR, 270, 90);
            f.CloseFigure();
            return f;
        }

        //Overriddem Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.GradientAng);
            Graphics graphicsArtan = e.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            // BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadiusTopLeft < 0 || borderRadiusTopRight < 0 || borderRadiusBotLeft < 0 || borderRadiusBotRight < 0)
                this.Region = new Region(rectangleF);
            else
            {
                using (GraphicsPath f = GetRJPanel(rectangleF, borderRadiusTopLeft, borderRadiusTopRight, borderRadiusBotLeft, borderRadiusBotRight))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(f);
                    e.Graphics.DrawPath(pen, f);
                }
            }
        }
    }
}
