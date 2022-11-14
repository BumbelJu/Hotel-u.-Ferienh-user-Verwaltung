
namespace Hotel_u.Ferienhäuser_Verwaltung
{
    partial class Buchung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchung));
            this.PBuchungsVorlage = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPreis = new System.Windows.Forms.Label();
            this.lblKunde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBundesland = new System.Windows.Forms.Label();
            this.lblStadt = new System.Windows.Forms.Label();
            this.lblStraße = new System.Windows.Forms.Label();
            this.lblAnzahlderNächte = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPDF = new System.Windows.Forms.Button();
            this.BtnWeiterSuchen = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PBuchungsVorlage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBuchungsVorlage
            // 
            this.PBuchungsVorlage.BackColor = System.Drawing.Color.White;
            this.PBuchungsVorlage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuchungsVorlage.Controls.Add(this.label6);
            this.PBuchungsVorlage.Controls.Add(this.lblPreis);
            this.PBuchungsVorlage.Controls.Add(this.lblKunde);
            this.PBuchungsVorlage.Controls.Add(this.label4);
            this.PBuchungsVorlage.Controls.Add(this.label3);
            this.PBuchungsVorlage.Controls.Add(this.lblBundesland);
            this.PBuchungsVorlage.Controls.Add(this.lblStadt);
            this.PBuchungsVorlage.Controls.Add(this.lblStraße);
            this.PBuchungsVorlage.Controls.Add(this.lblAnzahlderNächte);
            this.PBuchungsVorlage.Controls.Add(this.lblName);
            this.PBuchungsVorlage.Location = new System.Drawing.Point(12, 119);
            this.PBuchungsVorlage.Name = "PBuchungsVorlage";
            this.PBuchungsVorlage.Size = new System.Drawing.Size(562, 640);
            this.PBuchungsVorlage.TabIndex = 0;
            this.PBuchungsVorlage.Paint += new System.Windows.Forms.PaintEventHandler(this.PBuchungsVorlage_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 140);
            this.label6.TabIndex = 10;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // lblPreis
            // 
            this.lblPreis.AutoSize = true;
            this.lblPreis.BackColor = System.Drawing.Color.Linen;
            this.lblPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreis.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreis.Location = new System.Drawing.Point(56, 320);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(63, 23);
            this.lblPreis.TabIndex = 9;
            this.lblPreis.Text = "Preis:";
            // 
            // lblKunde
            // 
            this.lblKunde.AutoSize = true;
            this.lblKunde.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKunde.Location = new System.Drawing.Point(31, 395);
            this.lblKunde.Name = "lblKunde";
            this.lblKunde.Size = new System.Drawing.Size(228, 20);
            this.lblKunde.TabIndex = 8;
            this.lblKunde.Text = "Sehr geehrte/r Kundin/Kunde";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Rockwell", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hotel und Ferienwohnung Verwaltung Buchung\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Übersicht";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBundesland
            // 
            this.lblBundesland.AutoSize = true;
            this.lblBundesland.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundesland.Location = new System.Drawing.Point(52, 174);
            this.lblBundesland.Name = "lblBundesland";
            this.lblBundesland.Size = new System.Drawing.Size(120, 21);
            this.lblBundesland.TabIndex = 4;
            this.lblBundesland.Text = "Bundesland:";
            // 
            // lblStadt
            // 
            this.lblStadt.AutoSize = true;
            this.lblStadt.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadt.Location = new System.Drawing.Point(52, 208);
            this.lblStadt.Name = "lblStadt";
            this.lblStadt.Size = new System.Drawing.Size(60, 21);
            this.lblStadt.TabIndex = 3;
            this.lblStadt.Text = "Stadt:";
            // 
            // lblStraße
            // 
            this.lblStraße.AutoSize = true;
            this.lblStraße.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStraße.Location = new System.Drawing.Point(52, 242);
            this.lblStraße.Name = "lblStraße";
            this.lblStraße.Size = new System.Drawing.Size(73, 21);
            this.lblStraße.TabIndex = 2;
            this.lblStraße.Text = "Straße:";
            // 
            // lblAnzahlderNächte
            // 
            this.lblAnzahlderNächte.AutoSize = true;
            this.lblAnzahlderNächte.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahlderNächte.Location = new System.Drawing.Point(52, 277);
            this.lblAnzahlderNächte.Name = "lblAnzahlderNächte";
            this.lblAnzahlderNächte.Size = new System.Drawing.Size(179, 21);
            this.lblAnzahlderNächte.TabIndex = 1;
            this.lblAnzahlderNächte.Text = "Anzahl der Nächte:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vorschau";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnPDF
            // 
            this.BtnPDF.BackColor = System.Drawing.Color.Linen;
            this.BtnPDF.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPDF.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPDF.Location = new System.Drawing.Point(580, 633);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(311, 55);
            this.BtnPDF.TabIndex = 16;
            this.BtnPDF.Text = "Buchung herunterladen";
            this.BtnPDF.UseVisualStyleBackColor = false;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // BtnWeiterSuchen
            // 
            this.BtnWeiterSuchen.BackColor = System.Drawing.Color.Linen;
            this.BtnWeiterSuchen.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnWeiterSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWeiterSuchen.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWeiterSuchen.Location = new System.Drawing.Point(580, 704);
            this.BtnWeiterSuchen.Name = "BtnWeiterSuchen";
            this.BtnWeiterSuchen.Size = new System.Drawing.Size(311, 55);
            this.BtnWeiterSuchen.TabIndex = 17;
            this.BtnWeiterSuchen.Text = "Weiter Suchen";
            this.BtnWeiterSuchen.UseVisualStyleBackColor = false;
            this.BtnWeiterSuchen.Click += new System.EventHandler(this.BtnWeiterSuchen_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(899, 771);
            this.Controls.Add(this.BtnWeiterSuchen);
            this.Controls.Add(this.BtnPDF);
            this.Controls.Add(this.PBuchungsVorlage);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(915, 810);
            this.Name = "Buchung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Buchung_FormClosed);
            this.PBuchungsVorlage.ResumeLayout(false);
            this.PBuchungsVorlage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PBuchungsVorlage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPDF;
        private System.Windows.Forms.Button BtnWeiterSuchen;
        private System.Windows.Forms.Label lblBundesland;
        private System.Windows.Forms.Label lblStadt;
        private System.Windows.Forms.Label lblStraße;
        private System.Windows.Forms.Label lblAnzahlderNächte;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKunde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}