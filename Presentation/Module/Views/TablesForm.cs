using RayihaRestaurant.Presentation.Main;
using RayihaRestaurant.Presentation.Waiter;
using RayihaRestaurant.Presentation.Waiter.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayihaRestaurant.Presentation.Module.Views
{
    public partial class TablesForm : Form
    {
        private Dictionary<string, Form1> waiterForms = new Dictionary<string, Form1>();
        bool mouseDown;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
       

        public TablesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CreateTablePanels();
        }
        private void CreateTablePanels()
        {
            for (int i = 1; i <= 20; i++)
            {
                string tableName = "Masa " + i;
                CustomButton tableButton = new CustomButton();
                tableButton.Text = tableName;
                tableButton.Click += (sender, e) => OpenWaiterForm(tableName);
                flowLayoutPanel1.Controls.Add(tableButton);
            }
        }

        private void OpenWaiterForm(string tableName)
        {
            if (!waiterForms.ContainsKey(tableName) || waiterForms[tableName].IsDisposed)
            {
                waiterForms[tableName] = new Form1(); // Yeni Form1 oluştur veya varsa mevcut formu göster
                waiterForms[tableName].Text = tableName + " - Waiter Form for Orders";
                waiterForms[tableName].FormClosed += (sender, e) => waiterForms.Remove(tableName);
                waiterForms[tableName].Show();
            }
            else
            {
                waiterForms[tableName].Show();
                waiterForms[tableName].Focus();
            }
        }
        

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            int tableNumber = int.Parse(clickedPanel.Name.Substring(5)); // extracting the table number from panel name
            ShowTableInfo(tableNumber);
        }

        private void ShowTableInfo(int tableNumber)
        {
            // Burada, tableNumber kullanarak formunuzu açabilir ve ilgili masanın bilgilerini gösterebilirsiniz.
            // Örneğin:
            
        }
    

    private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int x = MousePosition.X - 400;
                int y = MousePosition.Y - 20;
                this.SetDesktopLocation(x, y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
