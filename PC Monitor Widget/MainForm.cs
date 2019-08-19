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
        List<Temperature> tempList;
        CPUControl cpuControl;
        public MainForm()
        {
            InitializeComponent();
            
            pcb_Close.MouseEnter += (s, e) => { pcb_Close.Image = Properties.Resources.checked15px; };
            pcb_Close.MouseLeave += (s, e) => { pcb_Close.Image = Properties.Resources.unchecked15px; };
            pcb_Close.Click += (s, e) => { Application.Exit(); };
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //cpb_RAM.DynamicProgress = true;
            //cpb_Hard.DynamicProgress = true;
            
            //cpb_RAM.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            //cpb_Hard.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            //timer1_Tick(new object(), new EventArgs());
            //tempList = Temperature.Temperatures;
            //string str = "";
            //foreach (Temperature t in tempList) str += t.InstanceName + " " + t.CurrentValue + "\n";
            //MessageBox.Show(str);
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
            
            //cpb_CPU.Text = string.Format("{0}%", (int)fcpu);
            //cpb_CPU.SetValue((int)fcpu);
            //cpb_RAM.Text = string.Format("{0}%", (int)fram);
            //cpb_RAM.SetValue((int)fram);
            
            
        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsm_CPU_Click(object sender, EventArgs e)
        {
            tsm_CPU.Checked = true;
            tsm_RAM.Checked = false;
            tsm_HardDrive.Checked = false;
            tsm_CPUTemp.Checked = false;

            pnl_Controls.Controls.Clear();
            pnl_Controls.Controls.Add(new CPUControl()
            {
                Location = new Point (0, 0)
            });

            pnl_Hat.BackColor = Color.FromArgb(104, 158, 49);
            pnl_Border.BackColor = Color.FromArgb(162, 247, 77);
        }

        private void tsm_RAM_Click(object sender, EventArgs e)
        {
            tsm_CPU.Checked = false;
            tsm_RAM.Checked = true;
            tsm_HardDrive.Checked = false;
            tsm_CPUTemp.Checked = false;

            pnl_Controls.Controls.Clear();
            pnl_Controls.Controls.Add(new RAMControl()
            {
                Location = new Point(0, 0)
            });

            pnl_Hat.BackColor = Color.FromArgb(166, 0, 33);
            pnl_Border.BackColor = Color.FromArgb(255, 0, 45);
        }

        private void tsm_HardDrive_Click(object sender, EventArgs e)
        {
            tsm_CPU.Checked = false;
            tsm_RAM.Checked = false;
            tsm_HardDrive.Checked = true;
            tsm_CPUTemp.Checked = false;

            pnl_Controls.Controls.Clear();
            pnl_Controls.Controls.Add(new HardDriveControl()
            {
                Location = new Point(0, 0)
            });

            pnl_Hat.BackColor = Color.FromArgb(77, 14, 140);
            pnl_Border.BackColor = Color.FromArgb(126, 23, 230);
        }
    }
}
