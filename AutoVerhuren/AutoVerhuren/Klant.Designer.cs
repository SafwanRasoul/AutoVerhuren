namespace AutoVerhuren {
    partial class klant {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label huis_nrLabel;
            System.Windows.Forms.Label document_idLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label woonplaatsLabel;
            System.Windows.Forms.Label achternaamLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label klant_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchByDocId = new System.Windows.Forms.TextBox();
            this.chkActieveKlanten = new System.Windows.Forms.CheckBox();
            this.btnKlantWijzigen = new System.Windows.Forms.Button();
            this.btnKlantToevoegen = new System.Windows.Forms.Button();
            this.btnAddKlant = new System.Windows.Forms.Button();
            this.klantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achternaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huisnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woonplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klantstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.klant_statusCheckBox = new System.Windows.Forms.CheckBox();
            this.klantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autosVerhurenDataSet = new AutoVerhuren.AutosVerhurenDataSet();
            this.huis_nrTextBox = new System.Windows.Forms.TextBox();
            this.document_idTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.woonplaatsTextBox = new System.Windows.Forms.TextBox();
            this.achternaamTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.klant_idTextBox = new System.Windows.Forms.TextBox();
            this.klantTableAdapter = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.klantTableAdapter();
            this.tableAdapterManager = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.TableAdapterManager();
            this.klantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            huis_nrLabel = new System.Windows.Forms.Label();
            document_idLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            woonplaatsLabel = new System.Windows.Forms.Label();
            achternaamLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            klant_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // huis_nrLabel
            // 
            huis_nrLabel.AutoSize = true;
            huis_nrLabel.Location = new System.Drawing.Point(658, 100);
            huis_nrLabel.Name = "huis_nrLabel";
            huis_nrLabel.Size = new System.Drawing.Size(43, 13);
            huis_nrLabel.TabIndex = 28;
            huis_nrLabel.Text = "Huis nr:";
            // 
            // document_idLabel
            // 
            document_idLabel.AutoSize = true;
            document_idLabel.Location = new System.Drawing.Point(452, 153);
            document_idLabel.Name = "document_idLabel";
            document_idLabel.Size = new System.Drawing.Size(70, 13);
            document_idLabel.TabIndex = 34;
            document_idLabel.Text = "Document id:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(452, 100);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 26;
            adresLabel.Text = "Adres:";
            // 
            // woonplaatsLabel
            // 
            woonplaatsLabel.AutoSize = true;
            woonplaatsLabel.Location = new System.Drawing.Point(240, 153);
            woonplaatsLabel.Name = "woonplaatsLabel";
            woonplaatsLabel.Size = new System.Drawing.Size(67, 13);
            woonplaatsLabel.TabIndex = 32;
            woonplaatsLabel.Text = "Woonplaats:";
            // 
            // achternaamLabel
            // 
            achternaamLabel.AutoSize = true;
            achternaamLabel.Location = new System.Drawing.Point(240, 100);
            achternaamLabel.Name = "achternaamLabel";
            achternaamLabel.Size = new System.Drawing.Size(67, 13);
            achternaamLabel.TabIndex = 24;
            achternaamLabel.Text = "Achternaam:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(36, 153);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(55, 13);
            postcodeLabel.TabIndex = 30;
            postcodeLabel.Text = "Postcode:";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(36, 100);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(38, 13);
            naamLabel.TabIndex = 22;
            naamLabel.Text = "Naam:";
            // 
            // klant_idLabel
            // 
            klant_idLabel.AutoSize = true;
            klant_idLabel.Location = new System.Drawing.Point(36, 127);
            klant_idLabel.Name = "klant_idLabel";
            klant_idLabel.Size = new System.Drawing.Size(48, 13);
            klant_idLabel.TabIndex = 20;
            klant_idLabel.Text = "Klant ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnZoeken);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SearchByDocId);
            this.panel1.Controls.Add(this.chkActieveKlanten);
            this.panel1.Controls.Add(this.btnKlantWijzigen);
            this.panel1.Controls.Add(this.btnKlantToevoegen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 73);
            this.panel1.TabIndex = 5;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(942, 27);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 23);
            this.btnZoeken.TabIndex = 12;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(728, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Zoeken";
            // 
            // SearchByDocId
            // 
            this.SearchByDocId.Location = new System.Drawing.Point(787, 29);
            this.SearchByDocId.Name = "SearchByDocId";
            this.SearchByDocId.Size = new System.Drawing.Size(120, 20);
            this.SearchByDocId.TabIndex = 10;
            this.SearchByDocId.Text = "Document ID";
            this.SearchByDocId.Enter += new System.EventHandler(this.SearchByDocId_Enter_1);
            this.SearchByDocId.Leave += new System.EventHandler(this.SearchByDocId_Leave_1);
            // 
            // chkActieveKlanten
            // 
            this.chkActieveKlanten.AutoSize = true;
            this.chkActieveKlanten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActieveKlanten.Location = new System.Drawing.Point(479, 31);
            this.chkActieveKlanten.Name = "chkActieveKlanten";
            this.chkActieveKlanten.Size = new System.Drawing.Size(101, 17);
            this.chkActieveKlanten.TabIndex = 9;
            this.chkActieveKlanten.Text = "Actieve Klanten";
            this.chkActieveKlanten.UseVisualStyleBackColor = true;
            this.chkActieveKlanten.CheckedChanged += new System.EventHandler(this.chkActieveKlanten_CheckedChanged_1);
            // 
            // btnKlantWijzigen
            // 
            this.btnKlantWijzigen.Location = new System.Drawing.Point(194, 22);
            this.btnKlantWijzigen.Name = "btnKlantWijzigen";
            this.btnKlantWijzigen.Size = new System.Drawing.Size(83, 32);
            this.btnKlantWijzigen.TabIndex = 7;
            this.btnKlantWijzigen.Text = "Wijzigen";
            this.btnKlantWijzigen.UseVisualStyleBackColor = true;
            this.btnKlantWijzigen.Click += new System.EventHandler(this.btnKlantWijzigen_Click_1);
            // 
            // btnKlantToevoegen
            // 
            this.btnKlantToevoegen.Location = new System.Drawing.Point(48, 22);
            this.btnKlantToevoegen.Name = "btnKlantToevoegen";
            this.btnKlantToevoegen.Size = new System.Drawing.Size(83, 32);
            this.btnKlantToevoegen.TabIndex = 6;
            this.btnKlantToevoegen.Text = "Toevoegen";
            this.btnKlantToevoegen.UseVisualStyleBackColor = true;
            this.btnKlantToevoegen.Click += new System.EventHandler(this.btnKlantToevoegen_Click);
            // 
            // btnAddKlant
            // 
            this.btnAddKlant.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKlant.Image")));
            this.btnAddKlant.Location = new System.Drawing.Point(12, 200);
            this.btnAddKlant.Name = "btnAddKlant";
            this.btnAddKlant.Size = new System.Drawing.Size(28, 27);
            this.btnAddKlant.TabIndex = 18;
            this.btnAddKlant.UseVisualStyleBackColor = true;
            this.btnAddKlant.Click += new System.EventHandler(this.btnAddKlant_Click_1);
            // 
            // klantidDataGridViewTextBoxColumn
            // 
            this.klantidDataGridViewTextBoxColumn.DataPropertyName = "klant_id";
            this.klantidDataGridViewTextBoxColumn.HeaderText = "klant_id";
            this.klantidDataGridViewTextBoxColumn.Name = "klantidDataGridViewTextBoxColumn";
            this.klantidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "naam";
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            // 
            // achternaamDataGridViewTextBoxColumn
            // 
            this.achternaamDataGridViewTextBoxColumn.DataPropertyName = "achternaam";
            this.achternaamDataGridViewTextBoxColumn.HeaderText = "achternaam";
            this.achternaamDataGridViewTextBoxColumn.Name = "achternaamDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // huisnrDataGridViewTextBoxColumn
            // 
            this.huisnrDataGridViewTextBoxColumn.DataPropertyName = "huis_nr";
            this.huisnrDataGridViewTextBoxColumn.HeaderText = "huis_nr";
            this.huisnrDataGridViewTextBoxColumn.Name = "huisnrDataGridViewTextBoxColumn";
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            // 
            // woonplaatsDataGridViewTextBoxColumn
            // 
            this.woonplaatsDataGridViewTextBoxColumn.DataPropertyName = "woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.HeaderText = "woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.Name = "woonplaatsDataGridViewTextBoxColumn";
            // 
            // documentidDataGridViewTextBoxColumn
            // 
            this.documentidDataGridViewTextBoxColumn.DataPropertyName = "document_id";
            this.documentidDataGridViewTextBoxColumn.HeaderText = "document_id";
            this.documentidDataGridViewTextBoxColumn.Name = "documentidDataGridViewTextBoxColumn";
            // 
            // klantstatusDataGridViewCheckBoxColumn
            // 
            this.klantstatusDataGridViewCheckBoxColumn.DataPropertyName = "klant_status";
            this.klantstatusDataGridViewCheckBoxColumn.HeaderText = "klant_status";
            this.klantstatusDataGridViewCheckBoxColumn.Name = "klantstatusDataGridViewCheckBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // klant_statusCheckBox
            // 
            this.klant_statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.klantBindingSource1, "klant_status", true));
            this.klant_statusCheckBox.Location = new System.Drawing.Point(715, 148);
            this.klant_statusCheckBox.Name = "klant_statusCheckBox";
            this.klant_statusCheckBox.Size = new System.Drawing.Size(104, 24);
            this.klant_statusCheckBox.TabIndex = 37;
            this.klant_statusCheckBox.Text = "Actief";
            this.klant_statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // klantBindingSource1
            // 
            this.klantBindingSource1.DataMember = "klant";
            this.klantBindingSource1.DataSource = this.autosVerhurenDataSet;
            // 
            // autosVerhurenDataSet
            // 
            this.autosVerhurenDataSet.DataSetName = "AutosVerhurenDataSet";
            this.autosVerhurenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huis_nrTextBox
            // 
            this.huis_nrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "huis_nr", true));
            this.huis_nrTextBox.Location = new System.Drawing.Point(715, 97);
            this.huis_nrTextBox.Name = "huis_nrTextBox";
            this.huis_nrTextBox.Size = new System.Drawing.Size(104, 20);
            this.huis_nrTextBox.TabIndex = 29;
            // 
            // document_idTextBox
            // 
            this.document_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "document_id", true));
            this.document_idTextBox.Location = new System.Drawing.Point(526, 150);
            this.document_idTextBox.Name = "document_idTextBox";
            this.document_idTextBox.Size = new System.Drawing.Size(104, 20);
            this.document_idTextBox.TabIndex = 35;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(526, 97);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(104, 20);
            this.adresTextBox.TabIndex = 27;
            // 
            // woonplaatsTextBox
            // 
            this.woonplaatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "woonplaats", true));
            this.woonplaatsTextBox.Location = new System.Drawing.Point(314, 150);
            this.woonplaatsTextBox.Name = "woonplaatsTextBox";
            this.woonplaatsTextBox.Size = new System.Drawing.Size(104, 20);
            this.woonplaatsTextBox.TabIndex = 33;
            // 
            // achternaamTextBox
            // 
            this.achternaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "achternaam", true));
            this.achternaamTextBox.Location = new System.Drawing.Point(314, 97);
            this.achternaamTextBox.Name = "achternaamTextBox";
            this.achternaamTextBox.Size = new System.Drawing.Size(104, 20);
            this.achternaamTextBox.TabIndex = 25;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(102, 150);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.postcodeTextBox.TabIndex = 31;
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(102, 97);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(104, 20);
            this.naamTextBox.TabIndex = 23;
            // 
            // klant_idTextBox
            // 
            this.klant_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klantBindingSource1, "klant_id", true));
            this.klant_idTextBox.Location = new System.Drawing.Point(102, 124);
            this.klant_idTextBox.Name = "klant_idTextBox";
            this.klant_idTextBox.ReadOnly = true;
            this.klant_idTextBox.Size = new System.Drawing.Size(55, 20);
            this.klant_idTextBox.TabIndex = 21;
            // 
            // klantTableAdapter
            // 
            this.klantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.klantTableAdapter = null;
            this.tableAdapterManager.reserverenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoVerhuren.AutosVerhurenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klantDataGridView
            // 
            this.klantDataGridView.AutoGenerateColumns = false;
            this.klantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.klantDataGridView.DataSource = this.klantBindingSource1;
            this.klantDataGridView.Location = new System.Drawing.Point(54, 200);
            this.klantDataGridView.Name = "klantDataGridView";
            this.klantDataGridView.Size = new System.Drawing.Size(963, 328);
            this.klantDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "klant_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "klant_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naam";
            this.dataGridViewTextBoxColumn2.HeaderText = "naam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "achternaam";
            this.dataGridViewTextBoxColumn3.HeaderText = "achternaam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adres";
            this.dataGridViewTextBoxColumn4.HeaderText = "adres";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "huis_nr";
            this.dataGridViewTextBoxColumn5.HeaderText = "huis_nr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "postcode";
            this.dataGridViewTextBoxColumn6.HeaderText = "postcode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "woonplaats";
            this.dataGridViewTextBoxColumn7.HeaderText = "woonplaats";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "document_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "document_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "klant_status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "klant_status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // klant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 584);
            this.Controls.Add(this.klantDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(klant_idLabel);
            this.Controls.Add(this.klant_idTextBox);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(achternaamLabel);
            this.Controls.Add(this.achternaamTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(huis_nrLabel);
            this.Controls.Add(this.huis_nrTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(woonplaatsLabel);
            this.Controls.Add(this.woonplaatsTextBox);
            this.Controls.Add(document_idLabel);
            this.Controls.Add(this.document_idTextBox);
            this.Controls.Add(this.klant_statusCheckBox);
            this.Controls.Add(this.btnAddKlant);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "klant";
            this.Text = "klant";
            this.Load += new System.EventHandler(this.klant_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKlantWijzigen;
        private System.Windows.Forms.Button btnKlantToevoegen;
        private AutosVerhurenDataSet autosVerhurenDataSet;
        private AutosVerhurenDataSetTableAdapters.klantTableAdapter klantTableAdapter;
        private AutosVerhurenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAddKlant;
        private System.Windows.Forms.CheckBox chkActieveKlanten;
        private System.Windows.Forms.TextBox SearchByDocId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huisnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woonplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn klantstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource klantBindingSource1;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox klant_statusCheckBox;
        private System.Windows.Forms.TextBox huis_nrTextBox;
        private System.Windows.Forms.TextBox document_idTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox woonplaatsTextBox;
        private System.Windows.Forms.TextBox achternaamTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox klant_idTextBox;
        private System.Windows.Forms.DataGridView klantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}