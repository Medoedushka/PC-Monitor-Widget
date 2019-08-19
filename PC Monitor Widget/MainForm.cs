using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;

namespace PC_Monitor_Widget
{
    public partial class MainForm : Form
    {
        #region Перетаскивание формы.
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        #endregion

        DriveInfo drive = new DriveInfo("C");
        public MainForm()
        {
            InitializeComponent();
            pcb_Close.MouseEnter += (s, e) => { pcb_Close.Image = Properties.Resources.checkedCancel27px; };
            pcb_Close.MouseLeave += (s, e) => { pcb_Close.Image = Properties.Resources.uncheckedCancel27px; };
            pcb_Close.Click += (s, e) => { Application.Exit(); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpb_CPU.DynamicProgress = true;
            cpb_RAM.DynamicProgress = true;
            cpb_Hard.DynamicProgress = true;
            cpb_CPU.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_RAM.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_Hard.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            timer1_Tick(new object(), new EventArgs());
            timer1.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float fram = RAM.NextValue();
            double f1 = drive.TotalFreeSpace / 1048576;
            double f2 = drive.TotalSize / 1048576;
            double size = 100 * (1 - f1 / f2);
            cpb_CPU.Text = string.Format("{0}%", (int)fcpu);
            cpb_CPU.SetValue((int)fcpu);
            cpb_RAM.Text = string.Format("{0}%", (int)fram);
            cpb_RAM.SetValue((int)fram);
            cpb_Hard.Text = string.Format("{0}%", (int)size);
            cpb_Hard.SetValue((int)size);
            //label2.Text = fcpu.ToString();
        }
    }
}
