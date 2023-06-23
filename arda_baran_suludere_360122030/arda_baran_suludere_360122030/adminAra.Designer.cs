namespace arda_baran_suludere_360122030
{
    partial class adminAra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAra));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musait = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(127, 156);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(652, 308);
            this.dgv.TabIndex = 2;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "FİLM ARA:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(308, 76);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(283, 24);
            this.txtAra.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(615, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 56);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arama.png");
            this.ımageList1.Images.SetKeyName(1, "arama2.png");
            // 
            // FilmID
            // 
            this.FilmID.DataPropertyName = "FilmID";
            this.FilmID.HeaderText = "FilmID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            this.FilmID.Width = 60;
            // 
            // FilmAdi
            // 
            this.FilmAdi.DataPropertyName = "FilmAdi";
            this.FilmAdi.HeaderText = "Film Adı";
            this.FilmAdi.Name = "FilmAdi";
            this.FilmAdi.ReadOnly = true;
            this.FilmAdi.Width = 220;
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
            this.YonetmenAdi.Width = 170;
            // 
            // Musait
            // 
            this.Musait.DataPropertyName = "Musait";
            this.Musait.HeaderText = "Müsait";
            this.Musait.Name = "Musait";
            this.Musait.ReadOnly = true;
            this.Musait.Width = 70;
            // 
            // adminAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arda_baran_suludere_360122030.Properties.Resources.pattern_369543_960_720__1_;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "adminAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminAra";
            this.Load += new System.EventHandler(this.adminAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musait;
    }
}