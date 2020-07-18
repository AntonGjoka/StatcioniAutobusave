namespace StatcioniAutobusave
{
    partial class Booking_list
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
            this.dgvrezervo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrezervo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrezervo
            // 
            this.dgvrezervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrezervo.Location = new System.Drawing.Point(12, 12);
            this.dgvrezervo.Name = "dgvrezervo";
            this.dgvrezervo.Size = new System.Drawing.Size(332, 245);
            this.dgvrezervo.TabIndex = 0;
            // 
            // Booking_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 275);
            this.Controls.Add(this.dgvrezervo);
            this.Name = "Booking_list";
            this.Text = "Booking_list";
            this.Load += new System.EventHandler(this.Booking_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrezervo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrezervo;
    }
}