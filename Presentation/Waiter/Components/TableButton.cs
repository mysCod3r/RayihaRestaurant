using Rayiha.Presentation.Cashier;
using RayihaRestaurant.Core.Socket;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class TableButton : CustomButton
    {
        private Form1 _waiterForm = new Form1();
        private CashierForm _cashierForm = new CashierForm();
        private int _tableId;
        private ClientType _clientType;

        public TableButton(int tableId, ClientType clientType)
        {
            _tableId = tableId;
            _clientType = clientType;
            Text = _tableId.ToString();
            Click += (_,__) =>  _openForm();
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
