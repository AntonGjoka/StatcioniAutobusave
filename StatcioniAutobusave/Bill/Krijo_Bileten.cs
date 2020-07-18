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

namespace StatcioniAutobusave.Bill
{
    public partial class Krijo_Bileten : Form
    {
        BillBLL billBLL = new BillBLL();

        public Krijo_Bileten()
        {
            InitializeComponent();
        }

       
        private void Krijo_Bileten_Load(object sender, EventArgs e)
        {
            initDataforbus();
        }
        private void initDataforbus()
        {
            BusBLL busbll = new BusBLL();
            cbautobusi.DataSource = busbll.GetALl();
            cbautobusi.DisplayMember = "EmriKompanise";
            cbautobusi.ValueMember = "BusID";
            cbautobusi.SelectedIndex = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var busi =(BO.Bus) cbautobusi.SelectedItem;
           
            billBLL.Add(new BO.Bill() { bus = busi, Cmimi = nmcmimi.Value, KohaMberritjes = dtpmberritja.Value, KohaNisjes = dtpnisja.Value, NrKontaktit = txtnumrikontaktues.Text });
            //busbll.Add(new BO.Bus() { Capacity = (int)nudcapacity.Value, EmriKompanise = txtcompanyname.Text });
        }
    }
}
