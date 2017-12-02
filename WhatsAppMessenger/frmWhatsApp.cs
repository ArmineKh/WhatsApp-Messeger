using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WhatsAppMessenger
{
    public partial class frmWhatsApp : Form
    {
        WhatsApp wa;

        public frmWhatsApp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            wa = new WhatsApp(Properties.Settings.Default.PhoneNumber, Properties.Settings.Default.Password, Properties.Settings.Default.FullName, true);
            wa.OnLoginSuccess += Wa_OnLoginSuccess;
            wa.OnLoginFailed += Wa_OnLoginFailed;
            wa.OnConnectFailed += Wa_OnConnectFailed;
            wa.Connect();
            wa.Login();
        }

        private void Wa_OnConnectFailed(Exception ex)
        {
            MessageBox.Show(string.Format("Connect failed: {0}", ex.StackTrace), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Wa_OnLoginFailed(string data)
        {
            MessageBox.Show(string.Format("Login failed: {0}", data), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Wa_OnLoginSuccess(string phoneNumber, byte[] data)
        {
            panel1.Enabled = false;
            panel2.BringToFront();
            panel2.Enabled = true;
            signOutToolStripMenuItem.Visible = true;
            Globals.DB.Users.Clear();
            Globals.DB.Accounts.Clear();
            Globals.DB.AcceptChanges();
            string accountFile = string.Format("{0}\\accaunts.dat", Application.StartupPath);
            if(File.Exists(accountFile))        
                Globals.DB.Accounts.ReadXml(accountFile);
            string userfile = string.Format("{0}\\users.dat", Application.StartupPath);
            if (File.Exists(userfile))
                Globals.DB.Users.ReadXml(userfile);
            LoadData();
        }

        private void LoadData()
        {
            var query = from o in Globals.DB.Users
                        where o.AccountId == Properties.Settings.Default.PhoneNumber
                        select new
                        {
                            PhoneNumber = o.UserId,
                            FullName = o.FullName,
                            Dspay = string.Format(" {0} (+{1})", o.FullName, o.UserId)
                        };
            listUsers.DataSource = query.ToList();
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = chkRemember.Checked;
            Properties.Settings.Default.PhoneNumber = txtPhoneNumber.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(frmRegister frm = new frmRegister())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                    txtPassword.Text = Properties.Settings.Default.Password;               }
            }
        }

        private void frmWhatsApp_Load(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            panel2.Enabled = false;
            listUsers.DisplayMember = "Display";
            listUsers.ValueMember = "PhoneNumber";
        
            if (Properties.Settings.Default.Remember)
            {
                txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRemember.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            wa.Disconnect();
            panel2.Enabled = false;
            panel1.Enabled = true;
            panel1.BringToFront();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmAbout frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
