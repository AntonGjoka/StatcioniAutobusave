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

namespace StatcioniAutobusave.User
{
    public partial class UserAdd : Form
    {
        UsersBLL usersBLL = new UsersBLL();
        public UserAdd()
        {
            InitializeComponent();
        }
        private void initData()
        {
            RoleBLL userbll = new RoleBLL();
            cbrole.DataSource = userbll.GetALl();
            cbrole.DisplayMember = "Name";
            cbrole.ValueMember = "ID";
            cbrole.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var var = (Role) cbrole.SelectedItem;
            var role1 = (Role) cbrole.SelectedItem;

            usersBLL.Add(new BO.User() {role= var,UserName = txtusername.Text, Password = txtpassword.Text, ExpireDate = dtpdate.Value });
            dgwusermanagment.DataSource = usersBLL.GetALl();


        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            initData();
            UsersBLL userbll = new UsersBLL();
            dgwusermanagment.DataSource = userbll.GetALl();
        }

        //private delegate bool MyDelegate();

        //MyDelegate del = new MyDelegate(kthe);
        
       
        //private bool kthe()
        //{
        //    if (cbactive.Checked)
        //        return true;
    
        //         return false;
            
            
        //}

        private void cbactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
           BO.User user = (BO.User)dgwusermanagment.Rows[index].DataBoundItem;

            if (user != null)
            {
                txtpassword.Text = user.Password;
                txtusername.Text = user.UserName;
                txtid.Text = user.Id.ToString();

            }
            dtpdate.Visible = false;
            cbrole.Visible = false;
            lbldate.Visible = false;
            lblrole.Visible = false;
            btndelete.Visible = true;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int var = int.Parse( txtid.Text);
            UsersBLL userbll = new UsersBLL();
            userbll.Remove(var);
            dgwusermanagment.DataSource = userbll.GetALl();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
