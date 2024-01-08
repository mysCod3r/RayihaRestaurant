using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Data;
using RayihaRestaurant.Presentation.Components;
using RayihaRestaurant.Core.Base;


namespace RayihaRestaurant.Presentation.Module.Views
{
    public partial class TablesForm : BaseForm
    {
        public override Size WindowSize => new Size(650, 510);
        public override string WindowPanelName => "Masalar";
        private List<Table> _tables;
        private ClientType _clientType;
        private SocketServer _socketServer;
        private readonly CashierService _service;

        public TablesForm(ClientType clientType, SocketServer socketServer)
        {
            _service = new CashierService(new DatabaseContext());
            _socketServer = socketServer;
            _clientType = clientType;
            _tables = _service.GetTables();
            InitializeComponent();
            CreateTablePanels();
        }
        private void CreateTablePanels()
        {
            foreach (var item in _tables)
            {
                CustomButton tableButton = new TableButton(item.ID, clientType: _clientType, socketServer: _socketServer);
                flpTables.Controls.Add(tableButton);

            }        
        }
    }
}
