
namespace Hotel_u.Ferienhäuser_Verwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDaten = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.RbHotelsFiltern = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RbFerienwohnungenFiltern = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBundeslandFiltern = new System.Windows.Forms.TextBox();
            this.BtnBundeslandSuchen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaten)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDaten
            // 
            this.DgvDaten.BackgroundColor = System.Drawing.Color.Linen;
            this.DgvDaten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DgvDaten.Location = new System.Drawing.Point(12, 58);
            this.DgvDaten.Name = "DgvDaten";
            this.DgvDaten.Size = new System.Drawing.Size(1044, 195);
            this.DgvDaten.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nummer";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Art";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PreisproNacht";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Wlan";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Haustiere";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Parkplatz";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bundesland";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Stadt";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Straße";
            this.Column10.Name = "Column10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotels und Ferienwohnungen";
            // 
            // RbHotelsFiltern
            // 
            this.RbHotelsFiltern.AutoSize = true;
            this.RbHotelsFiltern.BackColor = System.Drawing.Color.Azure;
            this.RbHotelsFiltern.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RbHotelsFiltern.FlatAppearance.BorderSize = 2;
            this.RbHotelsFiltern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbHotelsFiltern.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHotelsFiltern.Location = new System.Drawing.Point(29, 314);
            this.RbHotelsFiltern.Name = "RbHotelsFiltern";
            this.RbHotelsFiltern.Size = new System.Drawing.Size(181, 24);
            this.RbHotelsFiltern.TabIndex = 3;
            this.RbHotelsFiltern.TabStop = true;
            this.RbHotelsFiltern.Text = "Alle Hotels Anzeigen";
            this.RbHotelsFiltern.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotels und Ferienwohnungen Filtermöglichkeiten";
            // 
            // RbFerienwohnungenFiltern
            // 
            this.RbFerienwohnungenFiltern.AutoSize = true;
            this.RbFerienwohnungenFiltern.BackColor = System.Drawing.Color.Azure;
            this.RbFerienwohnungenFiltern.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RbFerienwohnungenFiltern.FlatAppearance.BorderSize = 2;
            this.RbFerienwohnungenFiltern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbFerienwohnungenFiltern.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFerienwohnungenFiltern.Location = new System.Drawing.Point(228, 314);
            this.RbFerienwohnungenFiltern.Name = "RbFerienwohnungenFiltern";
            this.RbFerienwohnungenFiltern.Size = new System.Drawing.Size(269, 24);
            this.RbFerienwohnungenFiltern.TabIndex = 5;
            this.RbFerienwohnungenFiltern.TabStop = true;
            this.RbFerienwohnungenFiltern.Text = "Alle Ferienwohnungen Anzeigen";
            this.RbFerienwohnungenFiltern.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnBundeslandSuchen);
            this.panel1.Controls.Add(this.TxtBundeslandFiltern);
            this.panel1.Location = new System.Drawing.Point(26, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 44);
            this.panel1.TabIndex = 6;
            // 
            // TxtBundeslandFiltern
            // 
            this.TxtBundeslandFiltern.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBundeslandFiltern.Location = new System.Drawing.Point(204, 3);
            this.TxtBundeslandFiltern.Name = "TxtBundeslandFiltern";
            this.TxtBundeslandFiltern.Size = new System.Drawing.Size(197, 30);
            this.TxtBundeslandFiltern.TabIndex = 0;
            this.TxtBundeslandFiltern.TextChanged += new System.EventHandler(this.TxtBundeslandFiltern_TextChanged);
            // 
            // BtnBundeslandSuchen
            // 
            this.BtnBundeslandSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBundeslandSuchen.Image = global::Hotel_u.Ferienhäuser_Verwaltung.Properties.Resources.search_500px1;
            this.BtnBundeslandSuchen.Location = new System.Drawing.Point(407, 2);
            this.BtnBundeslandSuchen.Name = "BtnBundeslandSuchen";
            this.BtnBundeslandSuchen.Size = new System.Drawing.Size(38, 30);
            this.BtnBundeslandSuchen.TabIndex = 1;
            this.BtnBundeslandSuchen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nach Bundesland:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1068, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RbFerienwohnungenFiltern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RbHotelsFiltern);
            this.Controls.Add(this.DgvDaten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotels und Ferienwohnungen Übersicht";
            
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaten)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.RadioButton RbHotelsFiltern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbFerienwohnungenFiltern;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBundeslandSuchen;
        private System.Windows.Forms.TextBox TxtBundeslandFiltern;
        private System.Windows.Forms.Label label3;
    }
}

