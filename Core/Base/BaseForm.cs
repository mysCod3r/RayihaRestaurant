using System.Runtime.InteropServices;

namespace RayihaRestaurant.Core.Base
{
    public abstract partial class BaseForm : Form
    {
        public abstract Size WindowSize { get; }
        public abstract string WindowPanelName { get; }
        public BaseForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Size = WindowSize;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            scrollPanel.Size = new Size(Width, 40);
            lblWindowPanel.Text = WindowPanelName;
            lblWindowPanel.Size = new Size(Width, 20);
            lblWindowPanel.Location = new Point(Width / 2 - WindowPanelName.Length / 2, 0);
            btnClose.Location = new Point(Width - btnClose.Size.Width, 30);
        }


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

        private void _btnClose(object sender, EventArgs e) => Hide();
    }
}
