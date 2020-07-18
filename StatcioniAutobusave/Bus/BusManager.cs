﻿using StatcioniAutobusave.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatcioniAutobusave.Bus
{
    public partial class BusManager : Form
    {
        public BusManager()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource asynchronously
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            BusEdit busedit = new BusEdit();
            busedit.Show();
        }
        private void initialData()
        {
            BusBLL role = new BusBLL();
            dgvbusshow.DataSource = role.GetALl();
            //dgvbusshow.ColumnCount = 2;
            //dgvbusshow.Columns[0].HeaderText = "EmriKompanise";
            //dgvbusshow.Columns[1].HeaderText = "Capacity";

        }

        

        private void BusManager_Load(object sender, EventArgs e)
        {
            initialData();
        }

        private void txtfiltergridrole_TextChanged(object sender, EventArgs e)
        {
            BusBLL role = new BusBLL();
            dgvbusshow.DataSource = role.KerkomeEmer(txtsearchbox.Text);
        }
    }
}
