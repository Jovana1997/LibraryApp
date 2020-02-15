namespace LibraryApp
{
    partial class Form4
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
            this.lIme = new System.Windows.Forms.Label();
            this.lPrezime = new System.Windows.Forms.Label();
            this.lMesto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.tbBiografija = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcAutor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // lIme
            // 
            this.lIme.AutoSize = true;
            this.lIme.Location = new System.Drawing.Point(220, 39);
            this.lIme.Name = "lIme";
            this.lIme.Size = new System.Drawing.Size(38, 17);
            this.lIme.TabIndex = 1;
            this.lIme.Text = "Ime:";
            // 
            // lPrezime
            // 
            this.lPrezime.AutoSize = true;
            this.lPrezime.Location = new System.Drawing.Point(220, 73);
            this.lPrezime.Name = "lPrezime";
            this.lPrezime.Size = new System.Drawing.Size(71, 17);
            this.lPrezime.TabIndex = 2;
            this.lPrezime.Text = "Prezime:";
            // 
            // lMesto
            // 
            this.lMesto.AutoSize = true;
            this.lMesto.Location = new System.Drawing.Point(220, 107);
            this.lMesto.Name = "lMesto";
            this.lMesto.Size = new System.Drawing.Size(120, 17);
            this.lMesto.TabIndex = 3;
            this.lMesto.Text = "Mesto rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Biografija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lista knjiga";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(45, 228);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.RowHeadersWidth = 51;
            this.dgvKnjige.RowTemplate.Height = 24;
            this.dgvKnjige.Size = new System.Drawing.Size(270, 167);
            this.dgvKnjige.TabIndex = 6;
            // 
            // tbBiografija
            // 
            this.tbBiografija.Location = new System.Drawing.Point(484, 70);
            this.tbBiografija.Name = "tbBiografija";
            this.tbBiografija.Size = new System.Drawing.Size(310, 159);
            this.tbBiografija.TabIndex = 7;
            this.tbBiografija.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryApp.Properties.Resources.book2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(484, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pcAutor
            // 
            this.pcAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcAutor.Location = new System.Drawing.Point(45, 39);
            this.pcAutor.Name = "pcAutor";
            this.pcAutor.Size = new System.Drawing.Size(153, 119);
            this.pcAutor.TabIndex = 0;
            this.pcAutor.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbBiografija);
            this.Controls.Add(this.dgvKnjige);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lMesto);
            this.Controls.Add(this.lPrezime);
            this.Controls.Add(this.lIme);
            this.Controls.Add(this.pcAutor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcAutor;
        private System.Windows.Forms.Label lIme;
        private System.Windows.Forms.Label lPrezime;
        private System.Windows.Forms.Label lMesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.RichTextBox tbBiografija;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}