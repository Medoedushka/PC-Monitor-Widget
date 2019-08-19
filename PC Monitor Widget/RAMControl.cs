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
    public partial class RAMControl : UserControl
    {
        public RAMControl()
        {
            InitializeComponent();
            cpb_RAM.DynamicProgress = true;
            cpb_RAM.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_RAM.Text = "0%";
        }

        private void RAMControl_Load(object sender, EventArgs e)
        {
            timer1_Tick(new object(), new EventArgs());
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fram = RAM.NextValue();
            cpb_RAM.Text = string.Format("{0}%", (int)fram);
            cpb_RAM.SetValue((int)fram);
        }
    }
}
