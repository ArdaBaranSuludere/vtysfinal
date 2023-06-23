namespace arda_baran_suludere_360122030
{
    partial class adminkiralanmis
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
            this.btnTeslim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KiraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiralanmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KiraID,
            this.KiralanmaTarihi,
            this.TeslimTarihi,
            this.FilmAdi,
            this.UyeAdi,
            this.UyeTel,
            this.Musait});
            this.dgv.Location = new System.Drawing.Point(131, 108);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(644, 275);
            this.dgv.TabIndex = 0;
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(39)))));
            this.btnTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslim.Location = new System.Drawing.Point(635, 415);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(140, 34);
            this.btnTeslim.TabIndex = 1;
            this.btnTeslim.Text = "Teslim Edildi";
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(345, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "KİRALANMIŞ FİLMLER";
            // 
            // KiraID
            // 
            this.KiraID.DataPropertyName = "KiraID";
            this.KiraID.HeaderText = "KiraID";
            this.KiraID.Name = "KiraID";
            this.KiraID.ReadOnly = true;
            this.KiraID.Width = 50;
            // 
            // KiralanmaTarihi
            // 
            this.KiralanmaTarihi.DataPropertyName = "KiralanmaTarihi";
            this.KiralanmaTarihi.HeaderText = "Kiralanma Tarihi";
            this.KiralanmaTarihi.Name = "KiralanmaTarihi";
            this.KiralanmaTarihi.ReadOnly = true;
            this.KiralanmaTarihi.Width = 70;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.DataPropertyName = "TeslimTarihi";
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.ReadOnly = true;
            this.TeslimTarihi.Width = 70;
            // 
            // FilmAdi
            // 
            this.FilmAdi.DataPropertyName = "FilmAdi";
            this.FilmAdi.HeaderText = "Film Adı";
            this.FilmAdi.Name = "FilmAdi";
            this.FilmAdi.ReadOnly = true;
            this.FilmAdi.Width = 150;
            // 
            // UyeAdi
            // 
            this.UyeAdi.DataPropertyName = "UyeAdi";
            this.UyeAdi.HeaderText = "Üye Adı";
            this.UyeAdi.Name = "UyeAdi";
            this.UyeAdi.ReadOnly = true;
            // 
            // UyeTel
            // 
            this.UyeTel.DataPropertyName = "UyeTel";
            this.UyeTel.HeaderText = "Üye Tel";
            this.UyeTel.Name = "UyeTel";
            this.UyeTel.ReadOnly = true;
            this.UyeTel.Width = 75;
            // 
            // Musait
            // 
            this.Musait.DataPropertyName = "Musait";
            this.Musait.HeaderText = "Müsait";
            this.Musait.Name = "Musait";
            this.Musait.ReadOnly = true;
            this.Musait.Width = 70;
            // 
            // adminkiralanmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arda_baran_suludere_360122030.Properties.Resources.pattern_369543_960_720__1_;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.dgv);
            this.Name = "adminkiralanmis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kiralanmis";
            this.Load += new System.EventHandler(this.kiralanmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralanmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musait;
    }
}