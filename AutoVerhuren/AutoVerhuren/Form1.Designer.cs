namespace AutoVerhuren
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnAutos = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnRes);
            this.panel1.Controls.Add(this.btnAutos);
            this.panel1.Controls.Add(this.btnKlanten);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnRes
            // 
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(230, 3);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(57, 55);
            this.btnRes.TabIndex = 3;
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnAutos
            // 
            this.btnAutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAutos.Image")));
            this.btnAutos.Location = new System.Drawing.Point(147, 3);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(57, 55);
            this.btnAutos.TabIndex = 2;
            this.btnAutos.UseVisualStyleBackColor = true;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.Image = ((System.Drawing.Image)(resources.GetObject("btnKlanten.Image")));
            this.btnKlanten.Location = new System.Drawing.Point(63, 3);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(57, 55);
            this.btnKlanten.TabIndex = 1;
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 61);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1087, 573);
            this.content.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 634);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Panel content;
    }
}

