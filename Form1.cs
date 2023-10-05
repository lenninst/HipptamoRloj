using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HipptamoRloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm;ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lbHora_Click(object sender, EventArgs e)
        {

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {
            lbFecha.TextAlign = ContentAlignment.MiddleCenter;
            int padding = (lbFecha.Height - (int) lbFecha.Font.GetHeight())/ 2;
            lbFecha.Padding = new Padding(0, padding, 0, padding);
        }
    }
}
