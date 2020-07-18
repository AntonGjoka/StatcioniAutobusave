using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatcioniAutobusave.BLL;
using StatcioniAutobusave.BO;

namespace StatcioniAutobusave.Bus
{
    public partial class BusEdit : Form
    {
       
        BusBLL busbll = new BusBLL();


        public BusEdit()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            busbll.Add(new BO.Bus() { Capacity = (int)nudcapacity.Value, EmriKompanise = txtcompanyname.Text });
            txtcompanyname.Text = "";
            nudcapacity.Value = 0;
            dgvbus.DataSource = busbll.GetALl();

        }

        private void BusEdit_Load(object sender, EventArgs e)
        {
       
            dgvbus.DataSource = busbll.GetALl();

        }


        private void dgvbus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            BO.Bus bus = (BO.Bus)dgvbus.Rows[index].DataBoundItem;

            if (bus != null)
            {
                txtid.Text = bus.BusID.ToString();
                txtcompanyname.Text = bus.EmriKompanise;

            }
            lblcapacity.Visible = false;
            nudcapacity.Visible = false;
            btndelete.Visible = true;
            dgvbus.DataSource = busbll.GetALl();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int var = int.Parse(txtid.Text);
            busbll.Remove(var);

            dgvbus.DataSource = busbll.GetALl();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvbus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
