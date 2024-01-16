namespace OOP_Proje_Forms
{
    partial class EmanetList
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
            this.dataGridViewEmanetListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmanetListesi
            // 
            this.dataGridViewEmanetListesi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewEmanetListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanetListesi.Location = new System.Drawing.Point(54, 67);
            this.dataGridViewEmanetListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmanetListesi.Name = "dataGridViewEmanetListesi";
            this.dataGridViewEmanetListesi.RowHeadersWidth = 51;
            this.dataGridViewEmanetListesi.RowTemplate.Height = 24;
            this.dataGridViewEmanetListesi.Size = new System.Drawing.Size(802, 456);
            this.dataGridViewEmanetListesi.TabIndex = 0;
            this.dataGridViewEmanetListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanetListesi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emanet Belgelerinin Geniş Listesi";
            // 
            // EmanetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmanetListesi);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmanetList";
            this.Text = "EmanetList";
            this.Load += new System.EventHandler(this.EmanetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmanetListesi;
        private System.Windows.Forms.Label label1;
    }
}