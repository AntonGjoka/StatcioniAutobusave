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
 

namespace StatcioniAutobusave.User
{
    public partial class ChangePassword : Form
    {
        UsersBLL user = new UsersBLL();
        public ChangePassword()
        {
            InitializeComponent();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsee_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = char.MinValue;
        }
        
        private void btnsave_Click(object sender, EventArgs e)
        {
            
            user.changepassword(txtusername.Text, txtpassword.Text, txtnewpassword.Text);
        }

        private void btnse_Click(object sender, EventArgs e)
        {
           txtnewpassword.PasswordChar= char.MinValue;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
