using StatcioniAutobusave.BLL;
using StatcioniAutobusave.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatcioniAutobusave.BO;

namespace StatcioniAutobusave
{
    public partial class Usermanagment : Form
    {
        UsersBLL userbll = new UsersBLL();
        public Usermanagment()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UserAdd useradd = new UserAdd();
            
            useradd.ShowDialog();
        }

        private void Usermanagment_Load(object sender, EventArgs e)
        {
            
            dgvusermanagment.DataSource = userbll.GetALl();
            
        }

        private void dgwusermanagment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            StatcioniAutobusave.BO.User user = (BO.User)dgvusermanagment.Rows[index].DataBoundItem;
            
        }
    }
}
