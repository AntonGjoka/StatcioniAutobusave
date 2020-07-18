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
    public partial class Billmanagment : Form
    {
        BillBLL billBLL = new BillBLL();
        public Billmanagment()
        {
            InitializeComponent();
            datagridviewbill.DataSource = billBLL.GetALl();
        }

        private void Billmanagment_Load(object sender, EventArgs e)
        {


        }
    }
}
