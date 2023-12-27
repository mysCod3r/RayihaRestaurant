using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class CustomPanelMenu : Panel
    {
        private int borderRadius = 50;

        public CustomPanelMenu()
        {
            BackColor = Color.White;
            ForeColor = Color.White;
            Size = new Size(350, 200);
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        private GraphicsPath GetGraphicsPath(RectangleF rectangleF, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangleF.Width - radius, rectangleF.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangleF.X, rectangleF.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangleF.X, rectangleF.Y, radius, radius, 180, 90);
            path.AddArc(rectangleF.Width - radius, rectangleF.Y, radius, radius, 270, 90);
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetGraphicsPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else Region = new Region(rectangleF);
        }

    }
}
