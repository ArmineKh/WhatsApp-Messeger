using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppMessenger
{
    public partial class frmAddEditUser : Form
    {
        private Label label1;
        private TextBox txtPhoneNumber;
        private TextBox txtFullName;
        private Label label2;
        private Button btnOk;

        object obj;

        public frmAddEditUser(object obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(182, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(97, 15);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(97, 54);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(160, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full name:";
            // 
            // frmAddEditUser
            // 
            this.AcceptButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(270, 119);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditUser_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmAddEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (obj == null)
                {
                    if (Globals.DB.Users.FindByUserId(txtPhoneNumber.Text) == null)
                    {
                        AppData.UsersRow row = Globals.DB.Users.NewUsersRow();
                        row.AccountId = Properties.Settings.Default.PhoneNumber;
                        row.UserId = txtPhoneNumber.Text;
                        row.FullName = txtFullName.Text;
                        Globals.DB.Users.AddUsersRow(row);
                        Globals.DB.Users.AcceptChanges();
                        Globals.DB.Users.WriteXml(string.Format("{0}\\users.dat", Application.StartupPath));
                        e.Cancel = false;
                    }
                    else
                    {
                        MessageBox.Show("This phone number already exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }

                }
                else
                {
                    AppData.UsersRow row = Globals.DB.Users.FindByUserId(obj.GetType().GetProperty("PhoneNumber").GetValue(obj, null).ToString());
                    if (row == null)
                    {
                        row.UserId = txtPhoneNumber.Text;
                        row.FullName = txtFullName.Text;
                        Globals.DB.AcceptChanges();
                        Globals.DB.Users.WriteXml(string.Format("{0}\\users.dat", Application.StartupPath));
                        e.Cancel = false;
                    }
                    else
                        e.Cancel = true;
                }
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            if (obj != null)
            {
                txtPhoneNumber.Text = obj.GetType().GetProperty("PhoneNumber").GetValue(obj, null).ToString();
                txtFullName.Text = obj.GetType().GetProperty("FullName").GetValue(obj, null).ToString();
            }
        }
    }
}
