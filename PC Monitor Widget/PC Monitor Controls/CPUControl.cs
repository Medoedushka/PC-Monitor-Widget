using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Monitor_Widget
{
    public partial class CPUControl : UserControl
    {
        public CPUControl()
        {
            InitializeComponent();
            cpb_CPU.DynamicProgress = true;
            cpb_CPU.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_CPU.Text = "0%";
        }

        private void CPUControl_Load(object sender, EventArgs e)
        {
            timer1_Tick(new object(), new EventArgs());
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            cpb_CPU.Text = string.Format("{0}%", (int)fcpu);
            cpb_CPU.SetValue((int)fcpu);
        }
    }
}
