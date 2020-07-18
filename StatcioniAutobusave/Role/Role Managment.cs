using StatcioniAutobusave.BLL;
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
    
    public partial class Role_Managment : Form
    {
        private RoleBLL role = new RoleBLL();

       private List<Role> roleslist = null;
        public Role_Managment()
        {
            InitializeComponent();
        }

        private void Role_Managment_Load(object sender, EventArgs e)
        {
            initialData();
        }

        private void initialData()
        {
            RoleBLL role = new RoleBLL();
            dgvRolemanagment.DataSource = role.GetALl();
        }

        private void txtfiltergridrole_KeyUp(object sender, KeyEventArgs e)
        {
            if (roleslist!=null)
            {
                var filterrole = roleslist.Where(a => a.Name.Contains(txtfiltergridrole.Text)).ToList();
                dgvRolemanagment.DataSource = filterrole;
            }
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RoleAdd roleform = new RoleAdd();
            roleform.ShowDialog();

           
        }
    }
}
