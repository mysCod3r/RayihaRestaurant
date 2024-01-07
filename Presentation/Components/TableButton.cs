using Rayiha.Presentation.Cashier;
using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Presentation.Waiter;
using RayihaRestaurant.Properties;

namespace RayihaRestaurant.Presentation.Components
{
    internal class TableButton : CustomButton
    {
        private SocketServer _socketServer;
        private WaiterForm _waiterForm = new WaiterForm();
        private CashierForm _cashierForm = new CashierForm();
        private int _tableId;
        private ClientType _clientType;

        public TableButton(int tableId, ClientType clientType, SocketServer socketServer)
        {

            _socketServer = socketServer;
            _registerServer();
            _tableId = tableId;
            _clientType = clientType;
            Text = _tableId.ToString();
            Click += (_, __) => _openForm();
            string? img = PicturesEnumExtension.PictureConverter((int)Pictures.Restaurant_table);
            BackgroundImage = Image.FromFile(img ?? "");
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Location = new Point(1711, 12);
            Size = new Size(150, 150);
            Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Padding = new Padding(5);
            TabIndex = 2;
            UseVisualStyleBackColor = false;

            Click += (_, __) => _openForm();
        }

        private void _registerServer()
        {
            _socketServer.AddMessageHandler(_waiterForm);
            _socketServer.AddMessageHandler(_cashierForm);
        }

        private void _openForm()
        {
            switch (_clientType)
            {
                case ClientType.Waiter:
                    _waiterForm.tableId = _tableId;
                    _waiterForm.Open();
                    break;
                case ClientType.Cashier:
                    _cashierForm.tableId = _tableId;
                    _cashierForm.Open(); break;
                default: return;
            }
        }
    }
}
