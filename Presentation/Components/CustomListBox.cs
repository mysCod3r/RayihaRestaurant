using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayihaRestaurant.Presentation.Components
{
    internal class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.BackColor = Color.Red;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
        }
    }
}
