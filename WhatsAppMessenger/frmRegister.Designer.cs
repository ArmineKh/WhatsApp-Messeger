﻿namespace WhatsAppMessenger
{
    partial class txtPhoneNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRequest = new System.Windows.Forms.Button();
            this.grbRequestCode = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbConfirmCode = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSmsCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbRequestCode.SuspendLayout();
            this.grbConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(241, 74);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // grbRequestCode
            // 
            this.grbRequestCode.Controls.Add(this.txtFullName);
            this.grbRequestCode.Controls.Add(this.btnRequest);
            this.grbRequestCode.Controls.Add(this.label2);
            this.grbRequestCode.Controls.Add(this.textBox1);
            this.grbRequestCode.Controls.Add(this.label1);
            this.grbRequestCode.Location = new System.Drawing.Point(12, 12);
            this.grbRequestCode.Name = "grbRequestCode";
            this.grbRequestCode.Size = new System.Drawing.Size(333, 100);
            this.grbRequestCode.TabIndex = 1;
            this.grbRequestCode.TabStop = false;
            this.grbRequestCode.Text = "Step 1: Request code";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(91, 48);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(225, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone number:";
            // 
            // grbConfirmCode
            // 
            this.grbConfirmCode.Controls.Add(this.btnConfirm);
            this.grbConfirmCode.Controls.Add(this.txtSmsCode);
            this.grbConfirmCode.Controls.Add(this.label4);
            this.grbConfirmCode.Location = new System.Drawing.Point(12, 120);
            this.grbConfirmCode.Name = "grbConfirmCode";
            this.grbConfirmCode.Size = new System.Drawing.Size(333, 84);
            this.grbConfirmCode.TabIndex = 2;
            this.grbConfirmCode.TabStop = false;
            this.grbConfirmCode.Text = "Step 2: Confirm code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(241, 48);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtSmsCode
            // 
            this.txtSmsCode.Location = new System.Drawing.Point(91, 22);
            this.txtSmsCode.MaxLength = 6;
            this.txtSmsCode.Name = "txtSmsCode";
            this.txtSmsCode.Size = new System.Drawing.Size(225, 20);
            this.txtSmsCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sms code:";
            // 
            // txtPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 216);
            this.Controls.Add(this.grbConfirmCode);
            this.Controls.Add(this.grbRequestCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "txtPhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.grbRequestCode.ResumeLayout(false);
            this.grbRequestCode.PerformLayout();
            this.grbConfirmCode.ResumeLayout(false);
            this.grbConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox grbRequestCode;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbConfirmCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSmsCode;
        private System.Windows.Forms.Label label4;
    }
}