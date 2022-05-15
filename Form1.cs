using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FiveM_META_TOOL
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series["META"].IsXValueIndexed = false;
                chart1.Series["META"].Points.AddXY(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].BackImage = Application.StartupPath + @"\FiveM_Map.png";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }
    }
}
