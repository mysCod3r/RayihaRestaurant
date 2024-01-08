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
        private readonly CashierService _service;
        private BaseForm _form;


        public TablesForm(BaseForm form)
        {
            _service = new CashierService(new DatabaseContext());
            _tables = _service.GetTables();
            _form = form;
            InitializeComponent();
            CreateTablePanels();
        }
        private void CreateTablePanels()
        {
            foreach (var item in _tables)
            {
                CustomButton tableButton = new TableButton(form: _form, tableId: item.ID);
                flpTables.Controls.Add(tableButton);
            }        
        }

        public override void Open() => Show();

        public override void SetTable(int tableId) { }
    }
}
