using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Data;
using System.Runtime.InteropServices;
using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Presentation.Components;
using RayihaRestaurant.Core.Base;


namespace RayihaRestaurant.Presentation.Module.Views
{
    public partial class TablesForm : BaseForm
    {
        public override Size WindowSize => new Size(650, 510);
        bool mouseDown;
        private List<Table> _tables;
        private ClientType _clientType;
        private SocketServer _socketServer;
        private readonly CashierService _service;
        public override string WindowPanelName => "Masalar " + _clientType.ToString();




        public TablesForm(ClientType clientType, SocketServer socketServer)
        {
            _socketServer = socketServer;
            _service = new CashierService(new DatabaseContext());
            _tables = _service.GetTables();
            _clientType = clientType;
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
