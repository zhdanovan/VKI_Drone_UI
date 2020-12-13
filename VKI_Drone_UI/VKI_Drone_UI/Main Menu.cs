using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKI_Drone_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckDrone_Click(object sender, EventArgs e)
        {
            Drone_status Child = new Drone_status();
            Child.MdiParent = this;
            Child.Show();
        }

        private void DeviceControl_Click(object sender, EventArgs e)
        {
            Devices C = new Devices();
            C.MdiParent = this;
            C.Show();

            textBox1.Text = Data.Signal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Order_Click(object sender, EventArgs e)
        {
            textBox1.Text = Data.Signal;

            textBox1.Text = Data.Order;
        }
    }
}
