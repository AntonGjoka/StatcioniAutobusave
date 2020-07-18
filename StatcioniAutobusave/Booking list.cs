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

namespace StatcioniAutobusave
{
    public partial class Booking_list : Form
    {
        RezervimetBLL rezervimetBLL = new RezervimetBLL();
        
        public Booking_list()
        {

            InitializeComponent();
        }

        private void Booking_list_Load(object sender, EventArgs e)
        {
            dgvrezervo.DataSource = rezervimetBLL.GetALl();
        }
    }
}
