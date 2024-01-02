
using Rayiha.Presentation.Cashier;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Presentation.Main;
using RayihaRestaurant.Presentation.Module.Views;
using RayihaRestaurant.Presentation.Waiter;
using System.Runtime.InteropServices;

namespace Rayiha.Presentation.Waiter
{
    public partial class LoginForm : Form
    {
        bool mouseDown;
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            CheckForIllegalCrossThreadCalls = false;
            _socketClient = new SocketClient();
            _clientType = ClientType.Waiter;
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
        }

        private void WaiterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "deneme" };
            _socketClient.SendMessage(messageModel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kullanıcıyı bul
            User user = DummyData.users.FirstOrDefault(u => u.name == username && u.password == password);

            if (user != null)
            {
                MessageBox.Show("Giriş Yapıldı");

                if (user.type == "waiter")
                {
                    this.Hide();
                    //TablesForm tf = new TablesForm();
                    //tf.Show();
                }
                else if (user.type == "cashier")
                {
                    this.Hide();
                    CashierForm cashierForm = new CashierForm();
                    cashierForm.Show();
                }
                // Diğer kullanıcı tiplerine göre gerekli form açılımlarını buraya ekle

            }
            else
            {
                MessageBox.Show("Eksik veya Hatalı Giriş");
            }
        }

    }
}
