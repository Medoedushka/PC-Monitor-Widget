using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PC_Monitor_Widget
{
    public partial class HardDriveControl : UserControl
    {
        DriveInfo driveInfo = new DriveInfo("C");
        public HardDriveControl()
        {
            InitializeComponent();
            cpb_HardDrive.DynamicProgress = true;
            cpb_HardDrive.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_HardDrive.Text = "0%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double f1 = driveInfo.TotalFreeSpace / 1048576;
            double f2 = driveInfo.TotalSize / 1048576;
            double size = 100 * (1 - f1 / f2);
            cpb_HardDrive.Text = string.Format("{0}%", (int)size);
            cpb_HardDrive.SetValue((int)size);
        }

        private void HardDriveControl_Load(object sender, EventArgs e)
        {
            timer1_Tick(new object(), new EventArgs());
            timer1.Start();
        }
    }
}
