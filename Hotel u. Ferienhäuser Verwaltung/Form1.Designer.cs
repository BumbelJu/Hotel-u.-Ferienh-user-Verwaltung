
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CmbBundesländer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RbAlleAnzeigen = new System.Windows.Forms.RadioButton();
            this.PBuchen = new System.Windows.Forms.Panel();
            this.BtnBuchungabbrechen = new System.Windows.Forms.Button();
            this.BtnBuchen = new System.Windows.Forms.Button();
            this.LblPreis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NudAnzahlNächte = new System.Windows.Forms.NumericUpDown();
            this.LblBuchenStadt = new System.Windows.Forms.Label();
            this.LblBuchenBundesland = new System.Windows.Forms.Label();
            this.LblBuchenStraße = new System.Windows.Forms.Label();
            this.LblBuchenName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAbmelden = new System.Windows.Forms.Button();
            this.DgvBewertung = new System.Windows.Forms.DataGridView();
            this.PBewertung = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.NuBewertung = new System.Windows.Forms.NumericUpDown();
            this.BtnBewerten = new System.Windows.Forms.Button();
            this.LblBewertenName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHotelBewerten = new System.Windows.Forms.Button();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaten)).BeginInit();
            this.panel1.SuspendLayout();
            this.PBuchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahlNächte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBewertung)).BeginInit();
            this.PBewertung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuBewertung)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDaten
            // 
            this.DgvDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDaten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.DgvDaten.Location = new System.Drawing.Point(12, 57);
            this.DgvDaten.Name = "DgvDaten";
            this.DgvDaten.ReadOnly = true;
            this.DgvDaten.Size = new System.Drawing.Size(1202, 234);
            this.DgvDaten.TabIndex = 2;
            this.DgvDaten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDaten_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nummer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Art";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "PreisproNacht";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Wlan";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Haustiere";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Parkplatz";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bundesland";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Stadt";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Straße";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotels und Ferienwohnungen";
            // 
            // RbHotelsFiltern
            // 
            this.RbHotelsFiltern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbHotelsFiltern.AutoSize = true;
            this.RbHotelsFiltern.BackColor = System.Drawing.Color.Azure;
            this.RbHotelsFiltern.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RbHotelsFiltern.FlatAppearance.BorderSize = 2;
            this.RbHotelsFiltern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbHotelsFiltern.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHotelsFiltern.Location = new System.Drawing.Point(15, 348);
            this.RbHotelsFiltern.Name = "RbHotelsFiltern";
            this.RbHotelsFiltern.Size = new System.Drawing.Size(181, 24);
            this.RbHotelsFiltern.TabIndex = 3;
            this.RbHotelsFiltern.TabStop = true;
            this.RbHotelsFiltern.Text = "Alle Hotels Anzeigen";
            this.RbHotelsFiltern.UseVisualStyleBackColor = false;
            this.RbHotelsFiltern.CheckedChanged += new System.EventHandler(this.RbHotelsFiltern_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotels und Ferienwohnungen Filtermöglichkeiten";
            // 
            // RbFerienwohnungenFiltern
            // 
            this.RbFerienwohnungenFiltern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbFerienwohnungenFiltern.AutoSize = true;
            this.RbFerienwohnungenFiltern.BackColor = System.Drawing.Color.Azure;
            this.RbFerienwohnungenFiltern.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RbFerienwohnungenFiltern.FlatAppearance.BorderSize = 2;
            this.RbFerienwohnungenFiltern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbFerienwohnungenFiltern.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFerienwohnungenFiltern.Location = new System.Drawing.Point(214, 348);
            this.RbFerienwohnungenFiltern.Name = "RbFerienwohnungenFiltern";
            this.RbFerienwohnungenFiltern.Size = new System.Drawing.Size(269, 24);
            this.RbFerienwohnungenFiltern.TabIndex = 5;
            this.RbFerienwohnungenFiltern.TabStop = true;
            this.RbFerienwohnungenFiltern.Text = "Alle Ferienwohnungen Anzeigen";
            this.RbFerienwohnungenFiltern.UseVisualStyleBackColor = false;
            this.RbFerienwohnungenFiltern.CheckedChanged += new System.EventHandler(this.RbFerienwohnungenFiltern_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CmbBundesländer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(625, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 44);
            this.panel1.TabIndex = 6;
            // 
            // CmbBundesländer
            // 
            this.CmbBundesländer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBundesländer.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBundesländer.FormattingEnabled = true;
            this.CmbBundesländer.Items.AddRange(new object[] {
            "NRW",
            "Bremen",
            "Niedersachsen",
            "Hamburg",
            "Berlin",
            "Brandenburg",
            "Schleswig Holstein",
            "Mecklenburg Vorpommern",
            "Sachsen Anhalt",
            "Thüringen",
            "Sachsen",
            "Hessen",
            "Bayern",
            "Baden-Württemberg",
            "Saarland"});
            this.CmbBundesländer.Location = new System.Drawing.Point(204, 5);
            this.CmbBundesländer.Name = "CmbBundesländer";
            this.CmbBundesländer.Size = new System.Drawing.Size(197, 28);
            this.CmbBundesländer.TabIndex = 8;
            this.CmbBundesländer.SelectedIndexChanged += new System.EventHandler(this.CmbBundesländer_SelectedIndexChanged);
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
            // RbAlleAnzeigen
            // 
            this.RbAlleAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbAlleAnzeigen.AutoSize = true;
            this.RbAlleAnzeigen.BackColor = System.Drawing.Color.Azure;
            this.RbAlleAnzeigen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RbAlleAnzeigen.FlatAppearance.BorderSize = 2;
            this.RbAlleAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbAlleAnzeigen.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAlleAnzeigen.Location = new System.Drawing.Point(489, 348);
            this.RbAlleAnzeigen.Name = "RbAlleAnzeigen";
            this.RbAlleAnzeigen.Size = new System.Drawing.Size(130, 24);
            this.RbAlleAnzeigen.TabIndex = 7;
            this.RbAlleAnzeigen.TabStop = true;
            this.RbAlleAnzeigen.Text = "Alle Anzeigen";
            this.RbAlleAnzeigen.UseVisualStyleBackColor = false;
            this.RbAlleAnzeigen.CheckedChanged += new System.EventHandler(this.RbAlleAnzeigen_CheckedChanged);
            // 
            // PBuchen
            // 
            this.PBuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBuchen.AutoScroll = true;
            this.PBuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBuchen.Controls.Add(this.BtnBuchungabbrechen);
            this.PBuchen.Controls.Add(this.BtnBuchen);
            this.PBuchen.Controls.Add(this.LblPreis);
            this.PBuchen.Controls.Add(this.label7);
            this.PBuchen.Controls.Add(this.label5);
            this.PBuchen.Controls.Add(this.NudAnzahlNächte);
            this.PBuchen.Controls.Add(this.LblBuchenStadt);
            this.PBuchen.Controls.Add(this.LblBuchenBundesland);
            this.PBuchen.Controls.Add(this.LblBuchenStraße);
            this.PBuchen.Controls.Add(this.LblBuchenName);
            this.PBuchen.Controls.Add(this.label4);
            this.PBuchen.Location = new System.Drawing.Point(715, 420);
            this.PBuchen.Name = "PBuchen";
            this.PBuchen.Size = new System.Drawing.Size(517, 320);
            this.PBuchen.TabIndex = 8;
            // 
            // BtnBuchungabbrechen
            // 
            this.BtnBuchungabbrechen.BackColor = System.Drawing.Color.Linen;
            this.BtnBuchungabbrechen.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuchungabbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuchungabbrechen.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuchungabbrechen.Location = new System.Drawing.Point(12, 260);
            this.BtnBuchungabbrechen.Name = "BtnBuchungabbrechen";
            this.BtnBuchungabbrechen.Size = new System.Drawing.Size(204, 42);
            this.BtnBuchungabbrechen.TabIndex = 15;
            this.BtnBuchungabbrechen.Text = "Buchung abbrechen";
            this.BtnBuchungabbrechen.UseVisualStyleBackColor = false;
            this.BtnBuchungabbrechen.Click += new System.EventHandler(this.BtnBuchungabbrechen_Click);
            // 
            // BtnBuchen
            // 
            this.BtnBuchen.BackColor = System.Drawing.Color.Linen;
            this.BtnBuchen.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuchen.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuchen.Location = new System.Drawing.Point(307, 260);
            this.BtnBuchen.Name = "BtnBuchen";
            this.BtnBuchen.Size = new System.Drawing.Size(183, 42);
            this.BtnBuchen.TabIndex = 14;
            this.BtnBuchen.Text = "Buchen";
            this.BtnBuchen.UseVisualStyleBackColor = false;
            this.BtnBuchen.Click += new System.EventHandler(this.BtnBuchen_Click);
            // 
            // LblPreis
            // 
            this.LblPreis.AutoSize = true;
            this.LblPreis.BackColor = System.Drawing.Color.Bisque;
            this.LblPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPreis.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreis.Location = new System.Drawing.Point(76, 207);
            this.LblPreis.Name = "LblPreis";
            this.LblPreis.Size = new System.Drawing.Size(61, 25);
            this.LblPreis.TabIndex = 13;
            this.LblPreis.Text = "0,00€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anzahl der Nächte";
            // 
            // NudAnzahlNächte
            // 
            this.NudAnzahlNächte.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudAnzahlNächte.Location = new System.Drawing.Point(217, 160);
            this.NudAnzahlNächte.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudAnzahlNächte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAnzahlNächte.Name = "NudAnzahlNächte";
            this.NudAnzahlNächte.Size = new System.Drawing.Size(46, 30);
            this.NudAnzahlNächte.TabIndex = 10;
            this.NudAnzahlNächte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAnzahlNächte.ValueChanged += new System.EventHandler(this.NudAnzahlNächte_ValueChanged);
            // 
            // LblBuchenStadt
            // 
            this.LblBuchenStadt.AutoSize = true;
            this.LblBuchenStadt.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenStadt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenStadt.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenStadt.Location = new System.Drawing.Point(12, 95);
            this.LblBuchenStadt.Name = "LblBuchenStadt";
            this.LblBuchenStadt.Size = new System.Drawing.Size(65, 25);
            this.LblBuchenStadt.TabIndex = 9;
            this.LblBuchenStadt.Text = "Stadt:";
            // 
            // LblBuchenBundesland
            // 
            this.LblBuchenBundesland.AutoSize = true;
            this.LblBuchenBundesland.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenBundesland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenBundesland.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenBundesland.Location = new System.Drawing.Point(12, 70);
            this.LblBuchenBundesland.Name = "LblBuchenBundesland";
            this.LblBuchenBundesland.Size = new System.Drawing.Size(125, 25);
            this.LblBuchenBundesland.TabIndex = 8;
            this.LblBuchenBundesland.Text = "Bundesland:";
            // 
            // LblBuchenStraße
            // 
            this.LblBuchenStraße.AutoSize = true;
            this.LblBuchenStraße.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenStraße.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenStraße.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenStraße.Location = new System.Drawing.Point(12, 120);
            this.LblBuchenStraße.Name = "LblBuchenStraße";
            this.LblBuchenStraße.Size = new System.Drawing.Size(76, 25);
            this.LblBuchenStraße.TabIndex = 7;
            this.LblBuchenStraße.Text = "Straße:";
            // 
            // LblBuchenName
            // 
            this.LblBuchenName.AutoSize = true;
            this.LblBuchenName.BackColor = System.Drawing.Color.Linen;
            this.LblBuchenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBuchenName.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchenName.Location = new System.Drawing.Point(12, 45);
            this.LblBuchenName.Name = "LblBuchenName";
            this.LblBuchenName.Size = new System.Drawing.Size(70, 25);
            this.LblBuchenName.TabIndex = 6;
            this.LblBuchenName.Text = "Name:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hotel oder Ferienwohnung buchen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAbmelden
            // 
            this.BtnAbmelden.BackColor = System.Drawing.Color.Linen;
            this.BtnAbmelden.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAbmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbmelden.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbmelden.Location = new System.Drawing.Point(12, 701);
            this.BtnAbmelden.Name = "BtnAbmelden";
            this.BtnAbmelden.Size = new System.Drawing.Size(133, 37);
            this.BtnAbmelden.TabIndex = 18;
            this.BtnAbmelden.Text = "Abmelden";
            this.BtnAbmelden.UseVisualStyleBackColor = false;
            this.BtnAbmelden.Click += new System.EventHandler(this.BtnAbmelden_Click);
            // 
            // DgvBewertung
            // 
            this.DgvBewertung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBewertung.BackgroundColor = System.Drawing.Color.Linen;
            this.DgvBewertung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBewertung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            this.DgvBewertung.Location = new System.Drawing.Point(16, 40);
            this.DgvBewertung.Name = "DgvBewertung";
            this.DgvBewertung.Size = new System.Drawing.Size(277, 186);
            this.DgvBewertung.TabIndex = 19;
            // 
            // PBewertung
            // 
            this.PBewertung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBewertung.Controls.Add(this.label9);
            this.PBewertung.Controls.Add(this.NuBewertung);
            this.PBewertung.Controls.Add(this.BtnBewerten);
            this.PBewertung.Controls.Add(this.LblBewertenName);
            this.PBewertung.Controls.Add(this.label6);
            this.PBewertung.Controls.Add(this.DgvBewertung);
            this.PBewertung.Location = new System.Drawing.Point(15, 450);
            this.PBewertung.Name = "PBewertung";
            this.PBewertung.Size = new System.Drawing.Size(658, 245);
            this.PBewertung.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bewertung 1-5";
            // 
            // NuBewertung
            // 
            this.NuBewertung.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuBewertung.Location = new System.Drawing.Point(473, 90);
            this.NuBewertung.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NuBewertung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NuBewertung.Name = "NuBewertung";
            this.NuBewertung.Size = new System.Drawing.Size(57, 30);
            this.NuBewertung.TabIndex = 23;
            this.NuBewertung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnBewerten
            // 
            this.BtnBewerten.BackColor = System.Drawing.Color.Linen;
            this.BtnBewerten.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBewerten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBewerten.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBewerten.Location = new System.Drawing.Point(446, 173);
            this.BtnBewerten.Name = "BtnBewerten";
            this.BtnBewerten.Size = new System.Drawing.Size(203, 58);
            this.BtnBewerten.TabIndex = 22;
            this.BtnBewerten.Text = "Bewertung abgeben";
            this.BtnBewerten.UseVisualStyleBackColor = false;
            this.BtnBewerten.Click += new System.EventHandler(this.BtnBewerten_Click);
            // 
            // LblBewertenName
            // 
            this.LblBewertenName.AutoSize = true;
            this.LblBewertenName.BackColor = System.Drawing.Color.Linen;
            this.LblBewertenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBewertenName.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBewertenName.Location = new System.Drawing.Point(306, 41);
            this.LblBewertenName.Name = "LblBewertenName";
            this.LblBewertenName.Size = new System.Drawing.Size(70, 25);
            this.LblBewertenName.TabIndex = 21;
            this.LblBewertenName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(656, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hotel oder Ferienwohnung Bewerten";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnHotelBewerten
            // 
            this.BtnHotelBewerten.BackColor = System.Drawing.Color.Linen;
            this.BtnHotelBewerten.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnHotelBewerten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHotelBewerten.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHotelBewerten.Location = new System.Drawing.Point(12, 394);
            this.BtnHotelBewerten.Name = "BtnHotelBewerten";
            this.BtnHotelBewerten.Size = new System.Drawing.Size(266, 33);
            this.BtnHotelBewerten.TabIndex = 23;
            this.BtnHotelBewerten.Text = "Bewertung abschicken";
            this.BtnHotelBewerten.UseVisualStyleBackColor = false;
            this.BtnHotelBewerten.Click += new System.EventHandler(this.BtnHotelBewerten_Click);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Hotel oder Ferienwohnung Nr";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Bewertung 1-5";
            this.Column12.Name = "Column12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1244, 750);
            this.Controls.Add(this.BtnHotelBewerten);
            this.Controls.Add(this.BtnAbmelden);
            this.Controls.Add(this.PBuchen);
            this.Controls.Add(this.RbAlleAnzeigen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RbFerienwohnungenFiltern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RbHotelsFiltern);
            this.Controls.Add(this.DgvDaten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBewertung);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotels und Ferienwohnungen Übersicht";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDaten)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PBuchen.ResumeLayout(false);
            this.PBuchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnzahlNächte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBewertung)).EndInit();
            this.PBewertung.ResumeLayout(false);
            this.PBewertung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuBewertung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDaten;
        private System.Windows.Forms.RadioButton RbHotelsFiltern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbFerienwohnungenFiltern;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.RadioButton RbAlleAnzeigen;
        private System.Windows.Forms.ComboBox CmbBundesländer;
        private System.Windows.Forms.Panel PBuchen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudAnzahlNächte;
        private System.Windows.Forms.Label LblBuchenStadt;
        private System.Windows.Forms.Label LblBuchenBundesland;
        private System.Windows.Forms.Label LblBuchenStraße;
        private System.Windows.Forms.Label LblBuchenName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblPreis;
        private System.Windows.Forms.Button BtnBuchungabbrechen;
        private System.Windows.Forms.Button BtnBuchen;
        private System.Windows.Forms.Button BtnAbmelden;
        private System.Windows.Forms.DataGridView DgvBewertung;
        private System.Windows.Forms.Panel PBewertung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NuBewertung;
        private System.Windows.Forms.Button BtnBewerten;
        private System.Windows.Forms.Label LblBewertenName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnHotelBewerten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

