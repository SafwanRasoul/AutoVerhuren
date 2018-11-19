namespace AutoVerhuren {
    partial class Autos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autosVerhurenDataSet = new AutoVerhuren.AutosVerhurenDataSet();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBouwjaar = new System.Windows.Forms.TextBox();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.txtBrandstof = new System.Windows.Forms.TextBox();
            this.txtHuurPrijs = new System.Windows.Forms.TextBox();
            this.txtKenteken = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkActieveAutos = new System.Windows.Forms.CheckBox();
            this.btnAutoWijzigen = new System.Windows.Forms.Button();
            this.btnAutoToevoegen = new System.Windows.Forms.Button();
            this.chkAutoBox = new System.Windows.Forms.CheckBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.autoTableAdapter = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.autoTableAdapter();
            this.tableAdapterManager = new AutoVerhuren.AutosVerhurenDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bouwjaar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kleur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Brandstof";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarief";
            // 
            // txtMerk
            // 
            this.txtMerk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "merk", true));
            this.txtMerk.Location = new System.Drawing.Point(100, 104);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(110, 20);
            this.txtMerk.TabIndex = 7;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.autosVerhurenDataSet;
            // 
            // autosVerhurenDataSet
            // 
            this.autosVerhurenDataSet.DataSetName = "AutosVerhurenDataSet";
            this.autosVerhurenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "model", true));
            this.txtModel.Location = new System.Drawing.Point(319, 104);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(118, 20);
            this.txtModel.TabIndex = 8;
            // 
            // txtBouwjaar
            // 
            this.txtBouwjaar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "bouwjaar", true));
            this.txtBouwjaar.Location = new System.Drawing.Point(540, 104);
            this.txtBouwjaar.Name = "txtBouwjaar";
            this.txtBouwjaar.Size = new System.Drawing.Size(69, 20);
            this.txtBouwjaar.TabIndex = 9;
            // 
            // txtKleur
            // 
            this.txtKleur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "kleur", true));
            this.txtKleur.Location = new System.Drawing.Point(100, 154);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(110, 20);
            this.txtKleur.TabIndex = 10;
            // 
            // txtBrandstof
            // 
            this.txtBrandstof.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "brandstof", true));
            this.txtBrandstof.Location = new System.Drawing.Point(319, 154);
            this.txtBrandstof.Name = "txtBrandstof";
            this.txtBrandstof.Size = new System.Drawing.Size(118, 20);
            this.txtBrandstof.TabIndex = 11;
            // 
            // txtHuurPrijs
            // 
            this.txtHuurPrijs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "huurprijs", true));
            this.txtHuurPrijs.Location = new System.Drawing.Point(540, 154);
            this.txtHuurPrijs.Name = "txtHuurPrijs";
            this.txtHuurPrijs.Size = new System.Drawing.Size(69, 20);
            this.txtHuurPrijs.TabIndex = 12;
            // 
            // txtKenteken
            // 
            this.txtKenteken.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "kenteken", true));
            this.txtKenteken.Enabled = false;
            this.txtKenteken.Location = new System.Drawing.Point(726, 154);
            this.txtKenteken.Name = "txtKenteken";
            this.txtKenteken.Size = new System.Drawing.Size(100, 20);
            this.txtKenteken.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kenteken";
            // 
            // autoDataGridView
            // 
            this.autoDataGridView.AutoGenerateColumns = false;
            this.autoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.autoDataGridView.DataSource = this.autoBindingSource;
            this.autoDataGridView.Location = new System.Drawing.Point(54, 200);
            this.autoDataGridView.Name = "autoDataGridView";
            this.autoDataGridView.RowTemplate.ReadOnly = true;
            this.autoDataGridView.Size = new System.Drawing.Size(943, 285);
            this.autoDataGridView.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.chkActieveAutos);
            this.panel1.Controls.Add(this.btnAutoWijzigen);
            this.panel1.Controls.Add(this.btnAutoToevoegen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1940, 73);
            this.panel1.TabIndex = 0;
            // 
            // chkActieveAutos
            // 
            this.chkActieveAutos.AutoSize = true;
            this.chkActieveAutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActieveAutos.Location = new System.Drawing.Point(569, 31);
            this.chkActieveAutos.Name = "chkActieveAutos";
            this.chkActieveAutos.Size = new System.Drawing.Size(94, 17);
            this.chkActieveAutos.TabIndex = 6;
            this.chkActieveAutos.Text = "Actieve Auto\'s";
            this.chkActieveAutos.UseVisualStyleBackColor = true;
            this.chkActieveAutos.CheckedChanged += new System.EventHandler(this.chkActieveKlanten_CheckedChanged);
            // 
            // btnAutoWijzigen
            // 
            this.btnAutoWijzigen.Location = new System.Drawing.Point(194, 22);
            this.btnAutoWijzigen.Name = "btnAutoWijzigen";
            this.btnAutoWijzigen.Size = new System.Drawing.Size(83, 32);
            this.btnAutoWijzigen.TabIndex = 4;
            this.btnAutoWijzigen.Text = "Wijzigen";
            this.btnAutoWijzigen.UseVisualStyleBackColor = true;
            this.btnAutoWijzigen.Click += new System.EventHandler(this.btnAutoWijzigen_Click_1);
            // 
            // btnAutoToevoegen
            // 
            this.btnAutoToevoegen.Location = new System.Drawing.Point(48, 22);
            this.btnAutoToevoegen.Name = "btnAutoToevoegen";
            this.btnAutoToevoegen.Size = new System.Drawing.Size(83, 32);
            this.btnAutoToevoegen.TabIndex = 1;
            this.btnAutoToevoegen.Text = "Toevoegen";
            this.btnAutoToevoegen.UseVisualStyleBackColor = true;
            this.btnAutoToevoegen.Click += new System.EventHandler(this.btnAutoToevoegen_Click_1);
            // 
            // chkAutoBox
            // 
            this.chkAutoBox.AutoSize = true;
            this.chkAutoBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.autoBindingSource, "status", true));
            this.chkAutoBox.Location = new System.Drawing.Point(874, 156);
            this.chkAutoBox.Name = "chkAutoBox";
            this.chkAutoBox.Size = new System.Drawing.Size(53, 17);
            this.chkAutoBox.TabIndex = 14;
            this.chkAutoBox.Text = "Actief";
            this.chkAutoBox.UseVisualStyleBackColor = true;
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAuto.Image")));
            this.btnAddAuto.Location = new System.Drawing.Point(12, 200);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(31, 28);
            this.btnAddAuto.TabIndex = 15;
            this.btnAddAuto.UseVisualStyleBackColor = true;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autoTableAdapter = this.autoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.klantTableAdapter = null;
            this.tableAdapterManager.reserverenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoVerhuren.AutosVerhurenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "kenteken";
            this.dataGridViewTextBoxColumn8.HeaderText = "kenteken";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "huurprijs";
            this.dataGridViewTextBoxColumn7.HeaderText = "huurprijs";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "brandstof";
            this.dataGridViewTextBoxColumn6.HeaderText = "brandstof";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kleur";
            this.dataGridViewTextBoxColumn5.HeaderText = "kleur";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bouwjaar";
            this.dataGridViewTextBoxColumn4.HeaderText = "bouwjaar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "merk";
            this.dataGridViewTextBoxColumn2.HeaderText = "merk";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "auto_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "auto_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1940, 981);
            this.Controls.Add(this.btnAddAuto);
            this.Controls.Add(this.chkAutoBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoDataGridView);
            this.Controls.Add(this.txtKenteken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHuurPrijs);
            this.Controls.Add(this.txtBrandstof);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.txtBouwjaar);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Autos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosVerhurenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutosVerhurenDataSet autosVerhurenDataSet;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private AutosVerhurenDataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private AutosVerhurenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBouwjaar;
        private System.Windows.Forms.TextBox txtKleur;
        private System.Windows.Forms.TextBox txtBrandstof;
        private System.Windows.Forms.TextBox txtHuurPrijs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKenteken;
        private System.Windows.Forms.DataGridView autoDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAutoToevoegen;
        private System.Windows.Forms.Button btnAutoWijzigen;
        private System.Windows.Forms.CheckBox chkAutoBox;
        private System.Windows.Forms.CheckBox chkActieveAutos;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}