using System.Drawing.Drawing2D;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class CustomPanel : Panel
    {
        private int _borderRadius = 50;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (_borderRadius > 2)
            {
                using (GraphicsPath path = GetGraphicsPath(rectangleF, _borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else Region = new Region(rectangleF);
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
    }
}
