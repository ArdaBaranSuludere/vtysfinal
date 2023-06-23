namespace arda_baran_suludere_360122030
{
    partial class adminEkle
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFAdi = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtYEkle = new System.Windows.Forms.Button();
            this.txtYAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmID,
            this.FilmAdi,
            this.YonetmenID,
            this.YonetmenAdi,
            this.Musait});
            this.dgv.Location = new System.Drawing.Point(282, 66);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(595, 355);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // FilmID
            // 
            this.FilmID.DataPropertyName = "FilmID";
            this.FilmID.HeaderText = "FilmID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            this.FilmID.Width = 50;
            // 
            // FilmAdi
            // 
            this.FilmAdi.DataPropertyName = "FilmAdi";
            this.FilmAdi.HeaderText = "Film Adı";
            this.FilmAdi.Name = "FilmAdi";
            this.FilmAdi.ReadOnly = true;
            this.FilmAdi.Width = 150;
            // 
            // YonetmenID
            // 
            this.YonetmenID.DataPropertyName = "YonetmenID";
            this.YonetmenID.HeaderText = "YönetmenID";
            this.YonetmenID.Name = "YonetmenID";
            this.YonetmenID.ReadOnly = true;
            this.YonetmenID.Width = 70;
            // 
            // YonetmenAdi
            // 
            this.YonetmenAdi.DataPropertyName = "YonetmenAdi";
            this.YonetmenAdi.HeaderText = "Yönetmen Adı";
            this.YonetmenAdi.Name = "YonetmenAdi";
            this.YonetmenAdi.ReadOnly = true;
            this.YonetmenAdi.Width = 120;
            // 
            // Musait
            // 
            this.Musait.DataPropertyName = "Musait";
            this.Musait.HeaderText = "Müsait";
            this.Musait.Name = "Musait";
            this.Musait.ReadOnly = true;
            this.Musait.Width = 60;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(39)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(101, 367);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 41);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "FİLM ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "YÖNETMEN ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "MÜSAİT:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(39)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(381, 449);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 33);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Müsait",
            "Kirada"});
            this.comboBox1.Location = new System.Drawing.Point(137, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // txtFAdi
            // 
            this.txtFAdi.Location = new System.Drawing.Point(137, 257);
            this.txtFAdi.Name = "txtFAdi";
            this.txtFAdi.Size = new System.Drawing.Size(134, 20);
            this.txtFAdi.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 288);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // txtYEkle
            // 
            this.txtYEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(39)))));
            this.txtYEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtYEkle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYEkle.Location = new System.Drawing.Point(193, 66);
            this.txtYEkle.Name = "txtYEkle";
            this.txtYEkle.Size = new System.Drawing.Size(73, 43);
            this.txtYEkle.TabIndex = 15;
            this.txtYEkle.Text = "EKLE";
            this.txtYEkle.UseVisualStyleBackColor = false;
            this.txtYEkle.Click += new System.EventHandler(this.txtYEkle_Click);
            // 
            // txtYAd
            // 
            this.txtYAd.Location = new System.Drawing.Point(53, 78);
            this.txtYAd.Name = "txtYAd";
            this.txtYAd.Size = new System.Drawing.Size(134, 20);
            this.txtYAd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yeni Yönetmen Ekle";
            // 
            // adminEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arda_baran_suludere_360122030.Properties.Resources.pattern_369543_960_720__1_;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYAd);
            this.Controls.Add(this.txtYEkle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtFAdi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgv);
            this.Name = "adminEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminEkle";
            this.Load += new System.EventHandler(this.adminEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFAdi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button txtYEkle;
        private System.Windows.Forms.TextBox txtYAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musait;
    }
}