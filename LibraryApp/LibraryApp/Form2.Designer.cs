namespace LibraryApp
{
    partial class Form2
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
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAutorIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKnjiga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnPrikaziKnjigu = new System.Windows.Forms.Button();
            this.btnPrikaziAutora = new System.Windows.Forms.Button();
            this.btnSkini = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAutorPrezime = new System.Windows.Forms.TextBox();
            this.btnPrikaziAutor = new System.Windows.Forms.Button();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbZanr
            // 
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Location = new System.Drawing.Point(44, 52);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(178, 24);
            this.cbZanr.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(228, 52);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(107, 24);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(44, 206);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(313, 220);
            this.dgv1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga po zanrovima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pretraga po autorima";
            // 
            // tbAutorIme
            // 
            this.tbAutorIme.Location = new System.Drawing.Point(44, 125);
            this.tbAutorIme.Name = "tbAutorIme";
            this.tbAutorIme.Size = new System.Drawing.Size(86, 22);
            this.tbAutorIme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informacije o knjizi";
            // 
            // tbKnjiga
            // 
            this.tbKnjiga.Location = new System.Drawing.Point(395, 52);
            this.tbKnjiga.Name = "tbKnjiga";
            this.tbKnjiga.Size = new System.Drawing.Size(180, 22);
            this.tbKnjiga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Informacije o autoru";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(395, 188);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(79, 22);
            this.tbIme.TabIndex = 9;
            // 
            // btnPrikaziKnjigu
            // 
            this.btnPrikaziKnjigu.Location = new System.Drawing.Point(395, 93);
            this.btnPrikaziKnjigu.Name = "btnPrikaziKnjigu";
            this.btnPrikaziKnjigu.Size = new System.Drawing.Size(102, 26);
            this.btnPrikaziKnjigu.TabIndex = 10;
            this.btnPrikaziKnjigu.Text = "Prikazi";
            this.btnPrikaziKnjigu.UseVisualStyleBackColor = true;
            this.btnPrikaziKnjigu.Click += new System.EventHandler(this.btnPrikaziKnjigu_Click);
            // 
            // btnPrikaziAutora
            // 
            this.btnPrikaziAutora.Location = new System.Drawing.Point(395, 235);
            this.btnPrikaziAutora.Name = "btnPrikaziAutora";
            this.btnPrikaziAutora.Size = new System.Drawing.Size(102, 25);
            this.btnPrikaziAutora.TabIndex = 11;
            this.btnPrikaziAutora.Text = "Prikazi";
            this.btnPrikaziAutora.UseVisualStyleBackColor = true;
            this.btnPrikaziAutora.Click += new System.EventHandler(this.btnPrikaziAutora_Click);
            // 
            // btnSkini
            // 
            this.btnSkini.Location = new System.Drawing.Point(518, 93);
            this.btnSkini.Name = "btnSkini";
            this.btnSkini.Size = new System.Drawing.Size(100, 26);
            this.btnSkini.TabIndex = 12;
            this.btnSkini.Text = "Skini";
            this.btnSkini.UseVisualStyleBackColor = true;
            this.btnSkini.Click += new System.EventHandler(this.btnSkini_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryApp.Properties.Resources.book2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(395, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 148);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbAutorPrezime
            // 
            this.tbAutorPrezime.Location = new System.Drawing.Point(137, 124);
            this.tbAutorPrezime.Name = "tbAutorPrezime";
            this.tbAutorPrezime.Size = new System.Drawing.Size(147, 22);
            this.tbAutorPrezime.TabIndex = 14;
            // 
            // btnPrikaziAutor
            // 
            this.btnPrikaziAutor.Location = new System.Drawing.Point(44, 153);
            this.btnPrikaziAutor.Name = "btnPrikaziAutor";
            this.btnPrikaziAutor.Size = new System.Drawing.Size(86, 24);
            this.btnPrikaziAutor.TabIndex = 15;
            this.btnPrikaziAutor.Text = "Prikazi";
            this.btnPrikaziAutor.UseVisualStyleBackColor = true;
            this.btnPrikaziAutor.Click += new System.EventHandler(this.btnPrikaziAutor_Click);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(494, 187);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(136, 22);
            this.tbPrezime.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 453);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.btnPrikaziAutor);
            this.Controls.Add(this.tbAutorPrezime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSkini);
            this.Controls.Add(this.btnPrikaziAutora);
            this.Controls.Add(this.btnPrikaziKnjigu);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKnjiga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAutorIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cbZanr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAutorIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKnjiga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnPrikaziKnjigu;
        private System.Windows.Forms.Button btnPrikaziAutora;
        private System.Windows.Forms.Button btnSkini;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAutorPrezime;
        private System.Windows.Forms.Button btnPrikaziAutor;
        private System.Windows.Forms.TextBox tbPrezime;
    }
}