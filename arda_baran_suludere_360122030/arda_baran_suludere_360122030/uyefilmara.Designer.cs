namespace arda_baran_suludere_360122030
{
    partial class uyefilmara
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyefilmara));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YonetmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dgv.Location = new System.Drawing.Point(43, 98);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Size = new System.Drawing.Size(556, 243);
            this.dgv.TabIndex = 2;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
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
            this.YonetmenID.Width = 75;
            // 
            // YonetmenAdi
            // 
            this.YonetmenAdi.DataPropertyName = "YonetmenAdi";
            this.YonetmenAdi.HeaderText = "Yönetmen Adı";
            this.YonetmenAdi.Name = "YonetmenAdi";
            this.YonetmenAdi.ReadOnly = true;
            this.YonetmenAdi.Width = 150;
            // 
            // Musait
            // 
            this.Musait.DataPropertyName = "Musait";
            this.Musait.HeaderText = "Müsait";
            this.Musait.Name = "Musait";
            this.Musait.ReadOnly = true;
            this.Musait.Width = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "arama.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(472, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "arama.png");
            this.ımageList2.Images.SetKeyName(1, "arama2.png");
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(152, 34);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(292, 37);
            this.txtAra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "FİLM ARA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(39)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(195, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "FİLMİ KİRALAMAK İSTİYORUM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uyefilmara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arda_baran_suludere_360122030.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(638, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Name = "uyefilmara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "üyeAnaSayfa";
            this.Load += new System.EventHandler(this.uyeAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YonetmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musait;
    }
}