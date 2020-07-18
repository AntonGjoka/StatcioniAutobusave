namespace StatcioniAutobusave.Bill
{
    partial class Krijo_Bileten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krijo_Bileten));
            this.label1 = new System.Windows.Forms.Label();
            this.cbautobusi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpnisja = new System.Windows.Forms.DateTimePicker();
            this.dtpmberritja = new System.Windows.Forms.DateTimePicker();
            this.nmcmimi = new System.Windows.Forms.NumericUpDown();
            this.txtnumrikontaktues = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmcmimi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbautobusi
            // 
            this.cbautobusi.FormattingEnabled = true;
            resources.ApplyResources(this.cbautobusi, "cbautobusi");
            this.cbautobusi.Name = "cbautobusi";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dtpnisja
            // 
            resources.ApplyResources(this.dtpnisja, "dtpnisja");
            this.dtpnisja.Name = "dtpnisja";
            // 
            // dtpmberritja
            // 
            resources.ApplyResources(this.dtpmberritja, "dtpmberritja");
            this.dtpmberritja.Name = "dtpmberritja";
            // 
            // nmcmimi
            // 
            resources.ApplyResources(this.nmcmimi, "nmcmimi");
            this.nmcmimi.Name = "nmcmimi";
            // 
            // txtnumrikontaktues
            // 
            resources.ApplyResources(this.txtnumrikontaktues, "txtnumrikontaktues");
            this.txtnumrikontaktues.Name = "txtnumrikontaktues";
            // 
            // btnadd
            // 
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Krijo_Bileten
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnumrikontaktues);
            this.Controls.Add(this.nmcmimi);
            this.Controls.Add(this.dtpmberritja);
            this.Controls.Add(this.dtpnisja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbautobusi);
            this.Controls.Add(this.label1);
            this.Name = "Krijo_Bileten";
            this.Load += new System.EventHandler(this.Krijo_Bileten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcmimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbautobusi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpnisja;
        private System.Windows.Forms.DateTimePicker dtpmberritja;
        private System.Windows.Forms.NumericUpDown nmcmimi;
        private System.Windows.Forms.TextBox txtnumrikontaktues;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclose;
    }
}