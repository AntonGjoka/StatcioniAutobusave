using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatcioniAutobusave.User
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            txthelptext.Text = $"This app is made for bus managment,"+"you can book a ticket in main form by selecting the bus, u can create a bill for any trip by pressing bill managment and filling the informations, u can create the bus with its own informations by pressing buss managment." +
                "" +
                " you can create new users with new username and password, you can change the password of existing account by pressing the change password button ";
            
        }
    }
}
