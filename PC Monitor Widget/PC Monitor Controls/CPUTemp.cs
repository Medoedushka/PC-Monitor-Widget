using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

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
            
            try
            {
                Double CPUtprt = 0;
                System.Management.ManagementObjectSearcher MOS = new System.Management.ManagementObjectSearcher("root\\WMI",
                        "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                foreach (System.Management.ManagementObject Mo in MOS.Get())
                {
                    CPUtprt = Convert.ToDouble(Convert.ToDouble(Mo.GetPropertyValue("CurrentTemperature".ToString())) - 2732) / 10.0;
                    cpb_CPUTemp.Text = string.Format("{0}°С", (int)CPUtprt);
                    cpb_CPUTemp.SetValue((int)CPUtprt);
                    break;
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("Ошибка получения данных " + ex.Message);
            }
        }
    }
}
