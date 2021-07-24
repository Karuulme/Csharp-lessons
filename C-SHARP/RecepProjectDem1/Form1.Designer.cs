
namespace RecepProjectDem1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxcatagori = new System.Windows.Forms.GroupBox();
            this.cbxCatagori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgbProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxcatagori.SuspendLayout();
            this.txbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxcatagori
            // 
            this.gbxcatagori.Controls.Add(this.label1);
            this.gbxcatagori.Controls.Add(this.cbxCatagori);
            this.gbxcatagori.Location = new System.Drawing.Point(12, 12);
            this.gbxcatagori.Name = "gbxcatagori";
            this.gbxcatagori.Size = new System.Drawing.Size(970, 126);
            this.gbxcatagori.TabIndex = 0;
            this.gbxcatagori.TabStop = false;
            this.gbxcatagori.Text = "Kategoriye göre listele";
            // 
            // cbxCatagori
            // 
            this.cbxCatagori.FormattingEnabled = true;
            this.cbxCatagori.Location = new System.Drawing.Point(80, 32);
            this.cbxCatagori.Name = "cbxCatagori";
            this.cbxCatagori.Size = new System.Drawing.Size(202, 21);
            this.cbxCatagori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori";
            // 
            // txbName
            // 
            this.txbName.Controls.Add(this.tbxSearch);
            this.txbName.Controls.Add(this.label2);
            this.txbName.Location = new System.Drawing.Point(12, 154);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(970, 100);
            this.txbName.TabIndex = 1;
            this.txbName.TabStop = false;
            this.txbName.Text = "ürün ismine göre ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsme Göre";
            // 
            // dgbProducts
            // 
            this.dgbProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbProducts.Location = new System.Drawing.Point(12, 260);
            this.dgbProducts.Name = "dgbProducts";
            this.dgbProducts.Size = new System.Drawing.Size(970, 256);
            this.dgbProducts.TabIndex = 2;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(87, 36);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(202, 20);
            this.tbxSearch.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 642);
            this.Controls.Add(this.dgbProducts);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.gbxcatagori);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxcatagori.ResumeLayout(false);
            this.gbxcatagori.PerformLayout();
            this.txbName.ResumeLayout(false);
            this.txbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxcatagori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCatagori;
        private System.Windows.Forms.GroupBox txbName;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgbProducts;
    }
}

