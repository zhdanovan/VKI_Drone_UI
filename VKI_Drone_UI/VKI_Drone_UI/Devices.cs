﻿using System;
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
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDevice_Click(object sender, EventArgs e)
        {
            Adding_Info Window = new Adding_Info();
            Window.Show();
        }
    }
}
