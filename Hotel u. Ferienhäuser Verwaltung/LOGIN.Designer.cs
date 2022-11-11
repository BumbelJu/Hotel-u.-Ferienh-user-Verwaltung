
namespace Hotel_u.Ferienhäuser_Verwaltung
{
    partial class LOGIN
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
            this.label4 = new System.Windows.Forms.Label();
            this.LblBuchenBundesland = new System.Windows.Forms.Label();
            this.LblBuchenName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.BtnAnmelden = new System.Windows.Forms.Button();
            this.BtnRegistrieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anmelden";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblBuchenBundesland
            // 
            this.LblBuchenBundesland.AutoSize = true;
            this.LblBuchenBundesland.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenBundesland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenBundesland.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenBundesland.Location = new System.Drawing.Point(36, 142);
            this.LblBuchenBundesland.Name = "LblBuchenBundesland";
            this.LblBuchenBundesland.Size = new System.Drawing.Size(99, 25);
            this.LblBuchenBundesland.TabIndex = 10;
            this.LblBuchenBundesland.Text = "Passwort:";
            // 
            // LblBuchenName
            // 
            this.LblBuchenName.AutoSize = true;
            this.LblBuchenName.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenName.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenName.Location = new System.Drawing.Point(65, 89);
            this.LblBuchenName.Name = "LblBuchenName";
            this.LblBuchenName.Size = new System.Drawing.Size(70, 25);
            this.LblBuchenName.TabIndex = 9;
            this.LblBuchenName.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(158, 87);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(199, 27);
            this.TxtName.TabIndex = 11;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswort.Location = new System.Drawing.Point(158, 142);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(199, 27);
            this.TxtPasswort.TabIndex = 12;
            this.TxtPasswort.TextChanged += new System.EventHandler(this.TxtPasswort_TextChanged);
            // 
            // BtnAnmelden
            // 
            this.BtnAnmelden.BackColor = System.Drawing.Color.Linen;
            this.BtnAnmelden.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAnmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnmelden.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnmelden.Location = new System.Drawing.Point(91, 214);
            this.BtnAnmelden.Name = "BtnAnmelden";
            this.BtnAnmelden.Size = new System.Drawing.Size(256, 43);
            this.BtnAnmelden.TabIndex = 17;
            this.BtnAnmelden.Text = "Anmelden";
            this.BtnAnmelden.UseVisualStyleBackColor = false;
            this.BtnAnmelden.Click += new System.EventHandler(this.BtnAnmelden_Click);
            // 
            // BtnRegistrieren
            // 
            this.BtnRegistrieren.BackColor = System.Drawing.Color.Linen;
            this.BtnRegistrieren.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrieren.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrieren.Location = new System.Drawing.Point(91, 288);
            this.BtnRegistrieren.Name = "BtnRegistrieren";
            this.BtnRegistrieren.Size = new System.Drawing.Size(256, 43);
            this.BtnRegistrieren.TabIndex = 18;
            this.BtnRegistrieren.Text = "Registrieren";
            this.BtnRegistrieren.UseVisualStyleBackColor = false;
            this.BtnRegistrieren.Click += new System.EventHandler(this.BtnRegistrieren_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(431, 343);
            this.Controls.Add(this.BtnRegistrieren);
            this.Controls.Add(this.BtnAnmelden);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblBuchenBundesland);
            this.Controls.Add(this.LblBuchenName);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 382);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LOGIN_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblBuchenBundesland;
        private System.Windows.Forms.Label LblBuchenName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Button BtnAnmelden;
        private System.Windows.Forms.Button BtnRegistrieren;
    }
}