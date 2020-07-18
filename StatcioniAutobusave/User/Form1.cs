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
using StatcioniAutobusave.Bus;
using StatcioniAutobusave.Bill;
using StatcioniAutobusave.BLL;
using System.Globalization;
using System.Threading;


namespace StatcioniAutobusave
{
    public partial class btnrezervo : Form
    {
        BillBLL billBLL = new BillBLL();
        RezervimetBLL rezervimetBLL = new RezervimetBLL();
        public btnrezervo()
        {
            InitializeComponent(); 
        }

        private void initDataforbus()
        {
            BillBLL billBLL = new BillBLL();
            cbbiletaa.DataSource = billBLL.GetALl();
            cbbiletaa.DisplayMember = "Cmimi";
            cbbiletaa.ValueMember = "billid";
            cbbiletaa.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BillBLL billBLL = new BillBLL();
            BusBLL bus = new BusBLL();
            initDataforbus();
            dgvbus.DataSource = bus.GetALl();
            dgvbileta.DataSource = billBLL.GetALl();


        }
       
        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm(new Role_Managment ());
            pnlpanelibiletadhebus.Visible = false;
            pnlrezervimibiletes.Visible = false;
            
        }
        public void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Forma_per_autentifikim login = new Forma_per_autentifikim();
            login.ShowDialog();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusManager bus = new BusManager();
            bus.Show();
        }

        private void userManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usermanagment user = new Usermanagment();
            user.Show();
        }
        public static void sendtheusername()
        {
            
        }
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rezervoBiletenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlrezervimibiletes.Visible = true;
            pnlpanelibiletadhebus.Visible = true;
            
        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Krijo_Bileten krijo = new Krijo_Bileten();
            krijo.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnrezervimi_Click(object sender, EventArgs e)
        {
            lblemrirez.Visible = true;
            cbbiletaa.Visible = true;
            lblbileta.Visible = true;
            btnfshij.Visible = true;
            btnruaj.Visible = true;
            txtemrirezervimit.Visible = true;
            
        }

        private void btnfshij_Click(object sender, EventArgs e)
        {
            lblemrirez.Visible = false;
            cbbiletaa.Visible = false;
            lblbileta.Visible = false;
            btnfshij.Visible = false;
            btnruaj.Visible = false;
            txtemrirezervimit.Visible = false;
        }

        private void btnruaj_Click(object sender, EventArgs e)
        {
            var bilet = (BO.Bill)cbbiletaa.SelectedItem;

            rezervimetBLL.Add(new BO.Rezervimet() {emrirezervimit=txtemrirezervimit.Text,bileta=bilet });
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();

            changePassword.Show();

        }

       

        private void albanianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("sq");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this,url: @"C:\Users\Noti-Toni\Documents\Help+Manual\NewProject\NewProject.chm");
        }

        private void bookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking_list booking_List = new Booking_list();

            booking_List.Show();
        }
    }
}
