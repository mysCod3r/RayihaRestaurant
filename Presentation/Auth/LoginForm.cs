
using Rayiha.Presentation.Kitchen;
using RayihaRestaurant;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Module.Views;
using System.Runtime.InteropServices;

namespace Rayiha.Presentation.Waiter
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _service;
        private SocketServer _socketServer;
        private MainForm _mainForm;
        private KitchenForm _kitchenForm = new KitchenForm();

        public LoginForm(SocketServer socketServer, MainForm mainForm)
        {
            _service = new AuthService(new DatabaseContext());
            _mainForm = mainForm;
            _socketServer = socketServer;
            _socketServer.AddMessageHandler(_kitchenForm);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            User _user = _service.AuthenticateUser(username, password);

            if (_user != null)
            {
                MessageBox.Show("Giriş Yapıldı");
                switch (_user.Type)
                {
                    case UserType.Waiter:
                        new TablesForm(socketServer: _socketServer, clientType: ClientType.Waiter).Show();
                        break;
                    case UserType.Cashier:
                        new TablesForm(socketServer: _socketServer, clientType: ClientType.Cashier).Show();
                        break;
                    case UserType.Chef:
                        _kitchenForm.Open();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
