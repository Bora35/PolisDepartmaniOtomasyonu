namespace PolisDepartmanıOtomasyonu
{
    partial class FrmAnaEkran
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
            this.BtnSuclu = new System.Windows.Forms.Button();
            this.BtnMemur = new System.Windows.Forms.Button();
            this.LbLYetkiliAdi = new System.Windows.Forms.Label();
            this.BtnDüzenle = new System.Windows.Forms.Button();
            this.Join_panel = new System.Windows.Forms.Panel();
            this.Join_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSuclu
            // 
            this.BtnSuclu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSuclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSuclu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSuclu.Location = new System.Drawing.Point(100, 129);
            this.BtnSuclu.Name = "BtnSuclu";
            this.BtnSuclu.Size = new System.Drawing.Size(221, 66);
            this.BtnSuclu.TabIndex = 7;
            this.BtnSuclu.Text = "Suçlu Sistemi";
            this.BtnSuclu.UseVisualStyleBackColor = false;
            this.BtnSuclu.Click += new System.EventHandler(this.BtnSuclu_Click);
            // 
            // BtnMemur
            // 
            this.BtnMemur.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnMemur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnMemur.Location = new System.Drawing.Point(385, 129);
            this.BtnMemur.Name = "BtnMemur";
            this.BtnMemur.Size = new System.Drawing.Size(221, 66);
            this.BtnMemur.TabIndex = 8;
            this.BtnMemur.Text = "Memur Sistemi";
            this.BtnMemur.UseVisualStyleBackColor = false;
            this.BtnMemur.Click += new System.EventHandler(this.BtnMemur_Click);
            // 
            // LbLYetkiliAdi
            // 
            this.LbLYetkiliAdi.AutoSize = true;
            this.LbLYetkiliAdi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbLYetkiliAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbLYetkiliAdi.ForeColor = System.Drawing.Color.White;
            this.LbLYetkiliAdi.Location = new System.Drawing.Point(17, 20);
            this.LbLYetkiliAdi.Name = "LbLYetkiliAdi";
            this.LbLYetkiliAdi.Size = new System.Drawing.Size(76, 36);
            this.LbLYetkiliAdi.TabIndex = 9;
            this.LbLYetkiliAdi.Text = "Test";
            // 
            // BtnDüzenle
            // 
            this.BtnDüzenle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDüzenle.ForeColor = System.Drawing.Color.Black;
            this.BtnDüzenle.Location = new System.Drawing.Point(546, 23);
            this.BtnDüzenle.Name = "BtnDüzenle";
            this.BtnDüzenle.Size = new System.Drawing.Size(143, 33);
            this.BtnDüzenle.TabIndex = 10;
            this.BtnDüzenle.Text = "Bilgilerini Düzenle";
            this.BtnDüzenle.UseVisualStyleBackColor = false;
            this.BtnDüzenle.Click += new System.EventHandler(this.BtnDüzenle_Click);
            // 
            // Join_panel
            // 
            this.Join_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Join_panel.Controls.Add(this.BtnDüzenle);
            this.Join_panel.Controls.Add(this.LbLYetkiliAdi);
            this.Join_panel.Location = new System.Drawing.Point(-5, -8);
            this.Join_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Join_panel.Name = "Join_panel";
            this.Join_panel.Size = new System.Drawing.Size(724, 86);
            this.Join_panel.TabIndex = 43;
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 255);
            this.Controls.Add(this.BtnMemur);
            this.Controls.Add(this.BtnSuclu);
            this.Controls.Add(this.Join_panel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FrmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            this.Join_panel.ResumeLayout(false);
            this.Join_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSuclu;
        private System.Windows.Forms.Button BtnMemur;
        private System.Windows.Forms.Label LbLYetkiliAdi;
        private System.Windows.Forms.Button BtnDüzenle;
        private System.Windows.Forms.Panel Join_panel;
    }
}