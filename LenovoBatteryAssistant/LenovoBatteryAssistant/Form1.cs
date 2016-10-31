using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenovoBatteryAssistant
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        const int MAXIMUM = 100;
        const string FORMAT_PERCENTAGE = "0#\\%";

        public Form1()
        {
            InitializeComponent();
            InitializaTooltips();
        }

        void InitializaTooltips()
        {
            metroToolTip1.SetToolTip(checkBox_Start, "Activates/deactivates the custom start threshold.\r\n\tThis allows you to prevent the battery from charging until a certain battery level is reached.\t");
            metroToolTip1.SetToolTip(trackBar_Start, "Sets the custom start threshold.\r\n\tA value between 10% and 100% is recommended\t");

            metroToolTip1.SetToolTip(checkBox_Stop, "Activates/deactivates the custom stop threshold.\r\n\tThis allows you to prevent the battery from charging above a certain battery level.\t");
            metroToolTip1.SetToolTip(trackBar_Stop, "Sets the custom stop threshold.\r\n\tA value between the custom start threshold and 100% is recommended\t");
        }

        private void trackBar_Start_Scroll(object sender, ScrollEventArgs e)
        {
            trackBar_Stop.Minimum = trackBar_Start.Value + 1 >= 100? 100 : trackBar_Start.Value + 1;
            label_Start.Text = trackBar_Start.Value.ToString(FORMAT_PERCENTAGE);
            label_Stop.Text = trackBar_Stop.Value.ToString(FORMAT_PERCENTAGE);
        }

        private void checkBox_Start_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Start.Checked)
            {
                trackBar_Start.Enabled = true;
            }
            else
            {
                trackBar_Start.Value = MAXIMUM;
                label_Start.Text = trackBar_Start.Value.ToString(FORMAT_PERCENTAGE);
                trackBar_Start.Enabled = false;
            }
        }

        private void checkBox_Stop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Stop.Checked)
            {
                trackBar_Stop.Enabled = true;
            }
            else
            {
                trackBar_Stop.Value = MAXIMUM;
                label_Stop.Text = trackBar_Stop.Value.ToString(FORMAT_PERCENTAGE);
                trackBar_Stop.Enabled = false;
            }
        }

        private void trackBar_Stop_Scroll(object sender, ScrollEventArgs e)
        {
            label_Stop.Text = trackBar_Stop.Value.ToString(FORMAT_PERCENTAGE);
        }

    }
}
