using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ShoppingOnline
{
    public class RJPanel : Panel
    {

        // Fields
        private int borderRadius = 30;
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
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
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
        private GraphicsPath GetRJPanel(RectangleF rectangle, float radius)
        {
            GraphicsPath f = new GraphicsPath();
            f.StartFigure();
            f.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            f.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            f.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            f.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
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
            if (borderRadius > 2)
            {
                using (GraphicsPath f = GetRJPanel(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(f);
                    e.Graphics.DrawPath(pen, f);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
