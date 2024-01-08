﻿
using Rayiha.Presentation.Cashier;
using Rayiha.Presentation.Kitchen;
using RayihaRestaurant;
using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Module.Views;
using RayihaRestaurant.Presentation.Waiter;

namespace Rayiha.Presentation.Waiter
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _service;
        private SocketServer _socketServer;
        private MainForm _mainForm;
        private KitchenForm _kitchenForm = new KitchenForm();
        private WaiterForm _waiterForm = new WaiterForm();
        private CashierForm _cashierForm = new CashierForm();
        private TablesForm _tablesWaiter;
        private TablesForm _tablesCashier;
        public LoginForm(SocketServer socketServer, MainForm mainForm)
        {
            _service = new AuthService(new DatabaseContext());
            _socketServer = socketServer;
            _mainForm = mainForm;
            _tablesWaiter = new TablesForm(form: _waiterForm);
            _tablesCashier = new TablesForm(form: _cashierForm);
            _registerServer();
            InitializeComponent();
        }
        private void _registerServer()
        {
            _socketServer.AddMessageHandler(_kitchenForm);
            _socketServer.AddMessageHandler(_waiterForm);
            _socketServer.AddMessageHandler(_cashierForm);
            _socketServer.AddMessageHandler(_tablesWaiter);
            _socketServer.AddMessageHandler(_tablesCashier);
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
                        _tablesWaiter.Show();
                        break;
                    case UserType.Cashier:
                        _tablesCashier.Show();
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
    }
}
