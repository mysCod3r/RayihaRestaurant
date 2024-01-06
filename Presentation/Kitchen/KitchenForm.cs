using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using System.Runtime.InteropServices;


namespace Rayiha.Presentation.Kitchen
{

    public partial class KitchenForm : Form, IMessageHandler
    {
        public ClientType ClientType => ClientType.Kitchen;
        private bool isSecondClick;
        private readonly KitchenService _service;
        private readonly SocketClient _socketClient;


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
        public KitchenForm()
        {
            _socketClient = new SocketClient();
            _service = new KitchenService(new DatabaseContext());
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CheckForIllegalCrossThreadCalls = false;
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = ClientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
        }

        private void KitchenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = ClientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (isSecondClick)
            {
                btnStatus.BackColor = Color.Green;
                btnStatus.Text = "Hazır";
                btnStatus.ForeColor = Color.White;
                btnStatus.Click -= btnStatus_Click;
            }
            else
            {
                btnStatus.BackColor = Color.Yellow;
                btnStatus.Text = "Hazırlanıyor";
                btnStatus.ForeColor = Color.Black;
            }
            isSecondClick = !isSecondClick;
        }

        public void HandleMessageFromSocket(MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}
