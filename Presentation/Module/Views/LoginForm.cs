
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Module;

namespace Rayiha.Presentation.Waiter
{
    public partial class LoginForm : BaseForm
    {
        
        bool mouseDown;
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        private readonly AuthService _service;
        private User _user;
        public LoginForm()
        {
            _service = new AuthService(new DatabaseContext());
            InitializeComponent();
            MySize = new Size(245,378);
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
            _user = _service.AuthenticateUser(username, password);

            if (_user != null)
            {
                MessageBox.Show("Giriş Yapıldı");
                switch (_user.Type)
                {
                    case UserType.Waiter:
                        MessageBox.Show(UserType.Waiter.ToString());
                        break;
                    case UserType.Cashier:
                        MessageBox.Show("Cashier");
                        break;
                    case UserType.Chef:
                        MessageBox.Show("Kitchen");
                        break;
                    default:
                        MessageBox.Show("Bilinmeyen Kullanıcı Türü");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Eksik veya Hatalı Giriş");
            }
        }

    }
}
