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
    public partial class CPUTemp : UserControl
    {
        
        public CPUTemp()
        {
            InitializeComponent();
            cpb_CPUTemp.DynamicProgress = true;
            cpb_CPUTemp.TextFont = new Font("Century Gothic", 15, FontStyle.Bold);
            cpb_CPUTemp.Text = "0%";
        }

        private void CPUTemp_Load(object sender, EventArgs e)
        {
            timer1_Tick(new object(), new EventArgs());
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Temperature> tempList = Temperature.Temperatures;
            cpb_CPUTemp.Text = string.Format("{0}°С", tempList[0].CurrentValue);
            cpb_CPUTemp.SetValue((int)tempList[0].CurrentValue);
        }
    }
}
