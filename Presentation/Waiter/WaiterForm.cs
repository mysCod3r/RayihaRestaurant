using RayihaRestaurant.Presentation.Main;
using RayihaRestaurant.Presentation.Module.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayihaRestaurant.Presentation.Waiter
{

    public partial class WaiterForm : Form
    {
        bool mouseDown;

        public WaiterForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            
        }

        private void Button_Click(object? sender, EventArgs e)
        {
           flowLayoutPanel2 .Controls.Clear();
           IEnumerable<Product> a = DummyData.products.Where(e => e.category.name == (sender as Button).Text);
            
            foreach (Product item in a)
            {
                Button button = new Button();
                button.Size = new Size(464, 33);
                button.Text = item.name;
                button.Click += product_buton_clik;
                flowLayoutPanel2.Controls.Add(button);
            }

        }

        private void product_buton_clik(object? sender, EventArgs e)
        {
            int amount = 1;
            string productName = (sender as Button)?.Text;

            if (!string.IsNullOrEmpty(productName))
            {
                // Ürünler arasında bu isme sahip ürünleri bul
                var existingItem = listView1.FindItemWithText(productName);

                if (existingItem != null)
                {
                    // Eğer eleman varsa, miktarını artır
                    int index = listView1.Items.IndexOf(existingItem);
                    int currentAmount = int.Parse(listView1.Items[index].SubItems[2].Text);
                    listView1.Items[index].SubItems[2].Text = (currentAmount + amount).ToString();
                }
                else
                {
                    // Eğer eleman yoksa listeye ekle
                    var products = DummyData.products.Where(item => item.name == productName);

                    foreach (Product item in products)
                    {
                        string[] row = { item.name, item.price.ToString(), amount.ToString() };
                        ListViewItem listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            decimal totalPrice = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                int amount = int.Parse(item.SubItems[2].Text);
                decimal price = decimal.Parse(item.SubItems[1].Text);
                totalPrice += amount * price;
            }

            label2.Text = $" Toplam Fiyat: {totalPrice:C}";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
