using StatcioniAutobusave.BLL;
using StatcioniAutobusave.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatcioniAutobusave
{
    public partial class RoleAdd : Form
    {
        Role role = new Role();
        
        RoleBLL roleBLL=new RoleBLL();
        public RoleAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string name = txtrolename.Text;
            //string description = rtbdescription.Text;
            //role.Name = name;
            //role.Description = description;
            
            roleBLL.Add(new Role() { Name = txtrolename.Text , Description = rtbdescription.Text});
            txtrolename.Text = "";
            rtbdescription.Text = "";
            RoleBLL role = new RoleBLL();
            dgvroleadd.DataSource = roleBLL.GetALl();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
           Role role = (Role)dgvroleadd.Rows[index].DataBoundItem;

            if (role != null)
            {
                txtrolename.Text = role.Name;
               rtbdescription.Text = role.Description;
                txtID.Text = role.ID.ToString();
                
            }
            lbldescription.Visible = false;
            rtbdescription.Visible = false;
            btndelete.Visible = true;
           
           
        }

        private void RoleAdd_Load(object sender, EventArgs e)
        {
           
            dgvroleadd.DataSource = roleBLL.GetALl();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            int var = int.Parse(txtID.Text);

            roleBLL.Remove(var);
            dgvroleadd.DataSource = roleBLL.GetALl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
