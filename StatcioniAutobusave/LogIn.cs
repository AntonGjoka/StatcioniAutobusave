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
using StatcioniAutobusave.BLL;
using StatcioniAutobusave.User;
using System.Globalization;
using System.Threading;

namespace StatcioniAutobusave
{
    public partial class Forma_per_autentifikim : Form
    {
        public Forma_per_autentifikim()
        {
            InitializeComponent();
        }
        public Forma_per_autentifikim(string msg)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (Username.Trim()=="")
            {
                txtUsername.BackColor = Color.Red;
                txtPassword.Focus();
                return;
            }
            if (Password.Trim() == "")
            {
                txtPassword.BackColor = Color.Red;
                txtPassword.Focus();
                return;
                
            }
            
            
            AdministrationBLL administration = new AdministrationBLL();
            StatcioniAutobusave.BO.User user  = administration.userlogin(Username,Password);

            if (user==null)
            {
                MessageBox.Show("Kontrolloni username/password ");
            }
            else
            {
                this.Close();
            }
            btnrezervo frm=new btnrezervo();
         
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbalbanian_CheckedChanged(object sender, EventArgs e)
        {
            if (rbalbanian.Checked)
            {
                chanelanguage("sq");
            }
        }

        private void rbenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbenglish.Checked)
            {
                chanelanguage("en-UK");
            }
        }
        public void chanelanguage(string language)
        {
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
