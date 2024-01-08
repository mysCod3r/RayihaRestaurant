using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Data;
using RayihaRestaurant.Presentation.Components;
using RayihaRestaurant.Core.Base;
using System.Windows.Forms;


namespace RayihaRestaurant.Presentation.Module.Views
{
    public partial class TablesForm : BaseForm, IMessageHandler
    {
        public override Size WindowSize => new Size(650, 510);
        public override string WindowPanelName => "Masalar";
                                    
        //                               for nothing
        public ClientType ClientType => ClientType.Waiter;

        private List<Table> _tables = new List<Table>();
        private readonly CashierService _service;
        private BaseForm _form;


        public TablesForm(BaseForm form)
        {
            _service = new CashierService(new DatabaseContext());
            _fetchTables();
            _form = form;
            InitializeComponent();
            _init();
        }
        private void _createTables()
        {
            foreach (var item in _tables)
            {
                CustomButton tableButton = new TableButton(form: _form, isAvailable: item.TableStatus, tableId: item.ID);
                flpTables.Controls.Add(tableButton);
            }        
        }

        private void _init() => _createTables();
        private void _reInit()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(_reInit));
                return;
            }

            flpTables.Controls.Clear();
            _init();
        }

        private void _fetchTables() => _tables = _service.GetTables();

        public override void Open() => Show();

        public override void SetTable(int tableId) { }

        public void HandleMessageFromSocket(MessageModel message)
        {
            _reInit();
        }
    }
}
