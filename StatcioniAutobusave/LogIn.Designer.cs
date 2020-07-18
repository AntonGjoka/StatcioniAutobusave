namespace StatcioniAutobusave
{
    partial class Forma_per_autentifikim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_per_autentifikim));
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbalbanian = new System.Windows.Forms.RadioButton();
            this.rbenglish = new System.Windows.Forms.RadioButton();
            this.lblhyr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            resources.ApplyResources(this.lblusername, "lblusername");
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblusername.Name = "lblusername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Name = "lblPassword";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Green;
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.BtnOk.FlatAppearance.BorderSize = 2;
            this.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.BtnOk, "BtnOk");
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbalbanian);
            this.panel1.Controls.Add(this.rbenglish);
            this.panel1.Controls.Add(this.lblhyr);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // rbalbanian
            // 
            resources.ApplyResources(this.rbalbanian, "rbalbanian");
            this.rbalbanian.Name = "rbalbanian";
            this.rbalbanian.UseVisualStyleBackColor = true;
            this.rbalbanian.CheckedChanged += new System.EventHandler(this.rbalbanian_CheckedChanged);
            // 
            // rbenglish
            // 
            resources.ApplyResources(this.rbenglish, "rbenglish");
            this.rbenglish.Checked = true;
            this.rbenglish.Name = "rbenglish";
            this.rbenglish.TabStop = true;
            this.rbenglish.UseVisualStyleBackColor = true;
            this.rbenglish.CheckedChanged += new System.EventHandler(this.rbenglish_CheckedChanged);
            // 
            // lblhyr
            // 
            this.lblhyr.BackColor = System.Drawing.Color.Transparent;
            this.lblhyr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.lblhyr, "lblhyr");
            this.lblhyr.Name = "lblhyr";
            // 
            // Forma_per_autentifikim
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Forma_per_autentifikim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblhyr;
        private System.Windows.Forms.RadioButton rbalbanian;
        private System.Windows.Forms.RadioButton rbenglish;
        private System.Windows.Forms.Label label1;
    }
}