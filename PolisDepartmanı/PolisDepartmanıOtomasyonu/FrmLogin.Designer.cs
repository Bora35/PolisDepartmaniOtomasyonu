namespace PolisDepartmanıOtomasyonu
{
    partial class FrmLogin
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
            this.Join_panel = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Join_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Join_panel
            // 
            this.Join_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Join_panel.Controls.Add(this.label1);
            this.Join_panel.Location = new System.Drawing.Point(-35, -17);
            this.Join_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Join_panel.Name = "Join_panel";
            this.Join_panel.Size = new System.Drawing.Size(868, 199);
            this.Join_panel.TabIndex = 42;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.Location = new System.Drawing.Point(195, 380);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(171, 41);
            this.BtnLogin.TabIndex = 49;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPass.Location = new System.Drawing.Point(195, 323);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(169, 29);
            this.TxtPass.TabIndex = 46;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password_label.Location = new System.Drawing.Point(188, 289);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(73, 32);
            this.Password_label.TabIndex = 45;
            this.Password_label.Text = "Şifre:";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Location = new System.Drawing.Point(195, 254);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(169, 29);
            this.TxtId.TabIndex = 44;
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Username_label.Location = new System.Drawing.Point(188, 220);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(47, 32);
            this.Username_label.TabIndex = 43;
            this.Username_label.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(137, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 106);
            this.label1.TabIndex = 50;
            this.label1.Text = "Giriş Yap";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 549);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Join_panel);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Join_panel.ResumeLayout(false);
            this.Join_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Join_panel;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label label1;
    }
}