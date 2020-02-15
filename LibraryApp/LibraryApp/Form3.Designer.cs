namespace LibraryApp
{
    partial class Form3
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
            this.lNaziv = new System.Windows.Forms.Label();
            this.lAutor = new System.Windows.Forms.Label();
            this.lZanr = new System.Windows.Forms.Label();
            this.lOcena = new System.Windows.Forms.Label();
            this.lOpis = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.RichTextBox();
            this.cbOcena = new System.Windows.Forms.ComboBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.tbKomentar = new System.Windows.Forms.RichTextBox();
            this.btnKomentarisi = new System.Windows.Forms.Button();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNaziv
            // 
            this.lNaziv.AutoSize = true;
            this.lNaziv.Location = new System.Drawing.Point(35, 36);
            this.lNaziv.Name = "lNaziv";
            this.lNaziv.Size = new System.Drawing.Size(58, 17);
            this.lNaziv.TabIndex = 0;
            this.lNaziv.Text = "Naziv: ";
            // 
            // lAutor
            // 
            this.lAutor.AutoSize = true;
            this.lAutor.Location = new System.Drawing.Point(35, 78);
            this.lAutor.Name = "lAutor";
            this.lAutor.Size = new System.Drawing.Size(52, 17);
            this.lAutor.TabIndex = 1;
            this.lAutor.Text = "Autor:";
            // 
            // lZanr
            // 
            this.lZanr.AutoSize = true;
            this.lZanr.Location = new System.Drawing.Point(35, 115);
            this.lZanr.Name = "lZanr";
            this.lZanr.Size = new System.Drawing.Size(47, 17);
            this.lZanr.TabIndex = 2;
            this.lZanr.Text = "Zanr:";
            // 
            // lOcena
            // 
            this.lOcena.AutoSize = true;
            this.lOcena.Location = new System.Drawing.Point(35, 150);
            this.lOcena.Name = "lOcena";
            this.lOcena.Size = new System.Drawing.Size(60, 17);
            this.lOcena.TabIndex = 3;
            this.lOcena.Text = "Ocena:";
            // 
            // lOpis
            // 
            this.lOpis.AutoSize = true;
            this.lOpis.Location = new System.Drawing.Point(35, 186);
            this.lOpis.Name = "lOpis";
            this.lOpis.Size = new System.Drawing.Size(46, 17);
            this.lOpis.TabIndex = 4;
            this.lOpis.Text = "Opis:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(38, 219);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(270, 96);
            this.tbOpis.TabIndex = 5;
            this.tbOpis.Text = "";
            // 
            // cbOcena
            // 
            this.cbOcena.FormattingEnabled = true;
            this.cbOcena.Location = new System.Drawing.Point(325, 27);
            this.cbOcena.Name = "cbOcena";
            this.cbOcena.Size = new System.Drawing.Size(59, 24);
            this.cbOcena.TabIndex = 6;
            // 
            // btnOceni
            // 
            this.btnOceni.Location = new System.Drawing.Point(451, 27);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(100, 23);
            this.btnOceni.TabIndex = 7;
            this.btnOceni.Text = "Oceni";
            this.btnOceni.UseVisualStyleBackColor = true;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click);
            // 
            // tbKomentar
            // 
            this.tbKomentar.Location = new System.Drawing.Point(325, 78);
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(226, 96);
            this.tbKomentar.TabIndex = 8;
            this.tbKomentar.Text = "";
            // 
            // btnKomentarisi
            // 
            this.btnKomentarisi.Location = new System.Drawing.Point(435, 186);
            this.btnKomentarisi.Name = "btnKomentarisi";
            this.btnKomentarisi.Size = new System.Drawing.Size(116, 31);
            this.btnKomentarisi.TabIndex = 9;
            this.btnKomentarisi.Text = "Komentarisi";
            this.btnKomentarisi.UseVisualStyleBackColor = true;
            this.btnKomentarisi.Click += new System.EventHandler(this.btnKomentarisi_Click);
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Location = new System.Drawing.Point(38, 332);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.RowHeadersWidth = 51;
            this.dgvKomentari.RowTemplate.Height = 24;
            this.dgvKomentari.Size = new System.Drawing.Size(270, 150);
            this.dgvKomentari.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryApp.Properties.Resources.book2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(367, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 164);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvKomentari);
            this.Controls.Add(this.btnKomentarisi);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.cbOcena);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lOpis);
            this.Controls.Add(this.lOcena);
            this.Controls.Add(this.lZanr);
            this.Controls.Add(this.lAutor);
            this.Controls.Add(this.lNaziv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNaziv;
        private System.Windows.Forms.Label lAutor;
        private System.Windows.Forms.Label lZanr;
        private System.Windows.Forms.Label lOcena;
        private System.Windows.Forms.Label lOpis;
        private System.Windows.Forms.RichTextBox tbOpis;
        private System.Windows.Forms.ComboBox cbOcena;
        private System.Windows.Forms.Button btnOceni;
        private System.Windows.Forms.RichTextBox tbKomentar;
        private System.Windows.Forms.Button btnKomentarisi;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}