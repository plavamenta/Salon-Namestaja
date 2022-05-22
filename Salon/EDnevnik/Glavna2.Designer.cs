namespace EDnevnik
{
    partial class Glavna2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskeGodineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MagacinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_korisnik = new System.Windows.Forms.Label();
            this.proizvodjacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem,
            this.sifarniciToolStripMenuItem,
            this.MagacinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem,
            this.osobeToolStripMenuItem1});
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.obradaToolStripMenuItem.Text = "Obrada";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Narudzbine";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // osobeToolStripMenuItem1
            // 
            this.osobeToolStripMenuItem1.Name = "osobeToolStripMenuItem1";
            this.osobeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem1.Text = "Korisnici";
            this.osobeToolStripMenuItem1.Click += new System.EventHandler(this.osobeToolStripMenuItem1_Click);
            // 
            // sifarniciToolStripMenuItem
            // 
            this.sifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem,
            this.smeroviToolStripMenuItem,
            this.skolskeGodineToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.proizvodjacToolStripMenuItem,
            this.korisnikToolStripMenuItem});
            this.sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            this.sifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sifarniciToolStripMenuItem.Text = "Sifarnici";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobeToolStripMenuItem.Text = "Boja";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // smeroviToolStripMenuItem
            // 
            this.smeroviToolStripMenuItem.Name = "smeroviToolStripMenuItem";
            this.smeroviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeroviToolStripMenuItem.Text = "Kategorija";
            this.smeroviToolStripMenuItem.Click += new System.EventHandler(this.smeroviToolStripMenuItem_Click);
            // 
            // skolskeGodineToolStripMenuItem
            // 
            this.skolskeGodineToolStripMenuItem.Name = "skolskeGodineToolStripMenuItem";
            this.skolskeGodineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skolskeGodineToolStripMenuItem.Text = "Materijal";
            this.skolskeGodineToolStripMenuItem.Click += new System.EventHandler(this.skolskeGodineToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetiToolStripMenuItem.Text = "Proizvodi";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // MagacinToolStripMenuItem
            // 
            this.MagacinToolStripMenuItem.Name = "MagacinToolStripMenuItem";
            this.MagacinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.MagacinToolStripMenuItem.Text = "Magacin";
            this.MagacinToolStripMenuItem.Click += new System.EventHandler(this.izvestajToolStripMenuItem_Click);
            // 
            // lbl_korisnik
            // 
            this.lbl_korisnik.AutoSize = true;
            this.lbl_korisnik.Location = new System.Drawing.Point(676, 9);
            this.lbl_korisnik.Name = "lbl_korisnik";
            this.lbl_korisnik.Size = new System.Drawing.Size(0, 13);
            this.lbl_korisnik.TabIndex = 1;
            // 
            // proizvodjacToolStripMenuItem
            // 
            this.proizvodjacToolStripMenuItem.Name = "proizvodjacToolStripMenuItem";
            this.proizvodjacToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proizvodjacToolStripMenuItem.Text = "Proizvodjac";
            this.proizvodjacToolStripMenuItem.Click += new System.EventHandler(this.proizvodjacToolStripMenuItem_Click);
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            this.korisnikToolStripMenuItem.Click += new System.EventHandler(this.korisnikToolStripMenuItem_Click);
            // 
            // Glavna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_korisnik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna2";
            this.Text = "Izvestaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna2_FormClosed);
            this.Load += new System.EventHandler(this.Glavna2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskeGodineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MagacinToolStripMenuItem;
        private System.Windows.Forms.Label lbl_korisnik;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proizvodjacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
    }
}