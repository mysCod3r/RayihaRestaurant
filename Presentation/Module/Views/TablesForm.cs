using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Presentation.Waiter.Components;
using System.Runtime.InteropServices;


namespace RayihaRestaurant.Presentation.Module.Views
{
    public partial class TablesForm : Form
    {
        bool mouseDown;
        private ClientType _clientType;
        private SocketServer _socketServer;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
       

        public TablesForm(ClientType clientType, SocketServer socketServer)
        {
            _socketServer = socketServer;
            _clientType = clientType;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CreateTablePanels();
        }
        private void CreateTablePanels()
        {
            for (int i = 1; i <= 20; i++)
            {
                CustomButton tableButton = new TableButton(tableId: i,socketServer: _socketServer, clientType: _clientType);
                flowLayoutPanel1.Controls.Add(tableButton);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void TablesForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
