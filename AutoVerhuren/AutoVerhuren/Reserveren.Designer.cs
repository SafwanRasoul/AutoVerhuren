namespace AutoVerhuren {
    partial class Reserveren {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserveren));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchByKlantNaam = new System.Windows.Forms.TextBox();
            this.chkActieveRes = new System.Windows.Forms.CheckBox();
            this.btnReserveerWijzigen = new System.Windows.Forms.Button();
            this.btnReserveerToevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.reserverenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autosVerhurenDataSet = new AutoVerhuren.AutosVerhurenDataSet();
            this.tmResDatum = new System.Windows.Forms.DateTimePicker();
            this.tmEindDatum = new System.Windows.Forms.DateTimePicker();
            this.comboKlant = new System.Windows.Forms.ComboBox();
            this.comboAuto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reserverenTableAdapter = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.reserverenTableAdapter();
            this.tableAdapterManager = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.TableAdapterManager();
            this.AddRes = new System.Windows.Forms.Button();
            this.chkResBox = new System.Windows.Forms.CheckBox();
            this.reserverenDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserverenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserverenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.SearchByKlantNaam);
            this.panel1.Controls.Add(this.chkActieveRes);
            this.panel1.Controls.Add(this.btnReserveerWijzigen);
            this.panel1.Controls.Add(this.btnReserveerToevoegen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1940, 73);
            this.panel1.TabIndex = 0;
            // 
            // SearchByKlantNaam
            // 
            this.SearchByKlantNaam.Location = new System.Drawing.Point(877, 29);
            this.SearchByKlantNaam.Name = "SearchByKlantNaam";
            this.SearchByKlantNaam.Size = new System.Drawing.Size(119, 20);
            this.SearchByKlantNaam.TabIndex = 5;
            this.SearchByKlantNaam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchByKlantNaam_KeyDown);
            // 
            // chkActieveRes
            // 
            this.chkActieveRes.AutoSize = true;
            this.chkActieveRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActieveRes.Location = new System.Drawing.Point(569, 31);
            this.chkActieveRes.Name = "chkActieveRes";
            this.chkActieveRes.Size = new System.Drawing.Size(134, 17);
            this.chkActieveRes.TabIndex = 4;
            this.chkActieveRes.Text = "Actieve Reserveringen";
            this.chkActieveRes.UseVisualStyleBackColor = true;
            this.chkActieveRes.CheckedChanged += new System.EventHandler(this.chkActieveRes_CheckedChanged);
            // 
            // btnReserveerWijzigen
            // 
            this.btnReserveerWijzigen.Location = new System.Drawing.Point(194, 22);
            this.btnReserveerWijzigen.Name = "btnReserveerWijzigen";
            this.btnReserveerWijzigen.Size = new System.Drawing.Size(83, 32);
            this.btnReserveerWijzigen.TabIndex = 2;
            this.btnReserveerWijzigen.Text = "Wijzigen";
            this.btnReserveerWijzigen.UseVisualStyleBackColor = true;
            this.btnReserveerWijzigen.Click += new System.EventHandler(this.btnReserveerWijzigen_Click_1);
            // 
            // btnReserveerToevoegen
            // 
            this.btnReserveerToevoegen.Location = new System.Drawing.Point(48, 22);
            this.btnReserveerToevoegen.Name = "btnReserveerToevoegen";
            this.btnReserveerToevoegen.Size = new System.Drawing.Size(83, 32);
            this.btnReserveerToevoegen.TabIndex = 1;
            this.btnReserveerToevoegen.Text = "Toevoegen";
            this.btnReserveerToevoegen.UseVisualStyleBackColor = true;
            this.btnReserveerToevoegen.Click += new System.EventHandler(this.btnReserveerToevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reserveer Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eind Datum";
            // 
            // txtResId
            // 
            this.txtResId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserverenBindingSource, "res_id", true));
            this.txtResId.Enabled = false;
            this.txtResId.Location = new System.Drawing.Point(125, 131);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(60, 20);
            this.txtResId.TabIndex = 9;
            // 
            // reserverenBindingSource
            // 
            this.reserverenBindingSource.DataSource = this.autosVerhurenDataSet;
            this.reserverenBindingSource.Position = 0;
            // 
            // autosVerhurenDataSet
            // 
            this.autosVerhurenDataSet.DataSetName = "AutosVerhurenDataSet";
            this.autosVerhurenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmResDatum
            // 
            this.tmResDatum.Location = new System.Drawing.Point(456, 159);
            this.tmResDatum.Name = "tmResDatum";
            this.tmResDatum.Size = new System.Drawing.Size(200, 20);
            this.tmResDatum.TabIndex = 13;
            // 
            // tmEindDatum
            // 
            this.tmEindDatum.Location = new System.Drawing.Point(125, 159);
            this.tmEindDatum.Name = "tmEindDatum";
            this.tmEindDatum.Size = new System.Drawing.Size(200, 20);
            this.tmEindDatum.TabIndex = 14;
            // 
            // comboKlant
            // 
            this.comboKlant.FormattingEnabled = true;
            this.comboKlant.Location = new System.Drawing.Point(125, 101);
            this.comboKlant.Name = "comboKlant";
            this.comboKlant.Size = new System.Drawing.Size(132, 21);
            this.comboKlant.TabIndex = 15;
            // 
            // comboAuto
            // 
            this.comboAuto.FormattingEnabled = true;
            this.comboAuto.Location = new System.Drawing.Point(363, 101);
            this.comboAuto.Name = "comboAuto";
            this.comboAuto.Size = new System.Drawing.Size(176, 21);
            this.comboAuto.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Klant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Auto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Res ID";
            // 
            // reserverenTableAdapter
            // 
            this.reserverenTableAdapter.ClearBeforeFill = true;
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
            // AddRes
            // 
            this.AddRes.Image = ((System.Drawing.Image)(resources.GetObject("AddRes.Image")));
            this.AddRes.Location = new System.Drawing.Point(12, 202);
            this.AddRes.Name = "AddRes";
            this.AddRes.Size = new System.Drawing.Size(29, 26);
            this.AddRes.TabIndex = 4;
            this.AddRes.UseVisualStyleBackColor = true;
            this.AddRes.Click += new System.EventHandler(this.AddRes_Click);
            // 
            // chkResBox
            // 
            this.chkResBox.AutoSize = true;
            this.chkResBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.reserverenBindingSource, "status", true));
            this.chkResBox.Location = new System.Drawing.Point(600, 103);
            this.chkResBox.Name = "chkResBox";
            this.chkResBox.Size = new System.Drawing.Size(56, 17);
            this.chkResBox.TabIndex = 21;
            this.chkResBox.Text = "Status";
            this.chkResBox.UseVisualStyleBackColor = true;
            // 
            // reserverenDataGridView
            // 
            this.reserverenDataGridView.AutoGenerateColumns = false;
            this.reserverenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserverenDataGridView.DataSource = this.reserverenBindingSource;
            this.reserverenDataGridView.Location = new System.Drawing.Point(55, 202);
            this.reserverenDataGridView.Name = "reserverenDataGridView";
            this.reserverenDataGridView.Size = new System.Drawing.Size(544, 282);
            this.reserverenDataGridView.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // Reserveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1940, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reserverenDataGridView);
            this.Controls.Add(this.chkResBox);
            this.Controls.Add(this.AddRes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboAuto);
            this.Controls.Add(this.comboKlant);
            this.Controls.Add(this.tmEindDatum);
            this.Controls.Add(this.tmResDatum);
            this.Controls.Add(this.txtResId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserveren";
            this.Text = "Reserveren";
            this.Load += new System.EventHandler(this.Reserveren_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserverenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserverenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReserveerWijzigen;
        private System.Windows.Forms.Button btnReserveerToevoegen;
        private AutosVerhurenDataSet autosVerhurenDataSet;
        private System.Windows.Forms.BindingSource reserverenBindingSource;
        private AutosVerhurenDataSetTableAdapters.reserverenTableAdapter reserverenTableAdapter;
        private AutosVerhurenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.DateTimePicker tmResDatum;
        private System.Windows.Forms.DateTimePicker tmEindDatum;
        private System.Windows.Forms.ComboBox comboKlant;
        private System.Windows.Forms.ComboBox comboAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddRes;
        private System.Windows.Forms.CheckBox chkResBox;
        private System.Windows.Forms.DataGridView reserverenDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox chkActieveRes;
        private System.Windows.Forms.TextBox SearchByKlantNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}