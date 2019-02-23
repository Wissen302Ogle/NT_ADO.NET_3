namespace Disconnected_Urun_Kategori_Listele
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
            this.btnUrunDoldur = new System.Windows.Forms.Button();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.btnKategoriDoldur = new System.Windows.Forms.Button();
            this.btnKategoriGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunDoldur
            // 
            this.btnUrunDoldur.Location = new System.Drawing.Point(24, 23);
            this.btnUrunDoldur.Name = "btnUrunDoldur";
            this.btnUrunDoldur.Size = new System.Drawing.Size(147, 41);
            this.btnUrunDoldur.TabIndex = 0;
            this.btnUrunDoldur.Text = "Ürün Doldur";
            this.btnUrunDoldur.UseVisualStyleBackColor = true;
            this.btnUrunDoldur.Click += new System.EventHandler(this.btnUrunDoldur_Click);
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.Location = new System.Drawing.Point(24, 81);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(147, 41);
            this.btnUrunGetir.TabIndex = 1;
            this.btnUrunGetir.Text = "Ürünleri Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = true;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // btnKategoriDoldur
            // 
            this.btnKategoriDoldur.Location = new System.Drawing.Point(520, 23);
            this.btnKategoriDoldur.Name = "btnKategoriDoldur";
            this.btnKategoriDoldur.Size = new System.Drawing.Size(147, 41);
            this.btnKategoriDoldur.TabIndex = 2;
            this.btnKategoriDoldur.Text = "Kategori Doldur";
            this.btnKategoriDoldur.UseVisualStyleBackColor = true;
            this.btnKategoriDoldur.Click += new System.EventHandler(this.btnKategoriDoldur_Click);
            // 
            // btnKategoriGetir
            // 
            this.btnKategoriGetir.Location = new System.Drawing.Point(520, 81);
            this.btnKategoriGetir.Name = "btnKategoriGetir";
            this.btnKategoriGetir.Size = new System.Drawing.Size(147, 41);
            this.btnKategoriGetir.TabIndex = 3;
            this.btnKategoriGetir.Text = "Kategorileri Getir";
            this.btnKategoriGetir.UseVisualStyleBackColor = true;
            this.btnKategoriGetir.Click += new System.EventHandler(this.btnKategoriGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 297);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKategoriGetir);
            this.Controls.Add(this.btnKategoriDoldur);
            this.Controls.Add(this.btnUrunGetir);
            this.Controls.Add(this.btnUrunDoldur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunDoldur;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Button btnKategoriDoldur;
        private System.Windows.Forms.Button btnKategoriGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

