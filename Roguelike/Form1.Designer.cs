namespace Roguelike
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSpielfeld = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSpielfeld = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusleiste = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusleisteEinblendenausblendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielfeld)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbSpielfeld
            // 
            this.rtbSpielfeld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbSpielfeld.Location = new System.Drawing.Point(13, 27);
            this.rtbSpielfeld.Name = "rtbSpielfeld";
            this.rtbSpielfeld.Size = new System.Drawing.Size(242, 388);
            this.rtbSpielfeld.TabIndex = 0;
            this.rtbSpielfeld.Text = "";
            this.rtbSpielfeld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSpielfeld_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.opionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielfeldLadenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // spielfeldLadenToolStripMenuItem
            // 
            this.spielfeldLadenToolStripMenuItem.Name = "spielfeldLadenToolStripMenuItem";
            this.spielfeldLadenToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.spielfeldLadenToolStripMenuItem.Text = "Spielfeld laden";
            this.spielfeldLadenToolStripMenuItem.Click += new System.EventHandler(this.spielfeldLadenToolStripMenuItem_Click);
            // 
            // opionenToolStripMenuItem
            // 
            this.opionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem,
            this.statusleisteEinblendenausblendenToolStripMenuItem});
            this.opionenToolStripMenuItem.Name = "opionenToolStripMenuItem";
            this.opionenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.opionenToolStripMenuItem.Text = "Opionen";
            // 
            // grafischeAnsichtAnzeigenverbergenToolStripMenuItem
            // 
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem.Name = "grafischeAnsichtAnzeigenverbergenToolStripMenuItem";
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem.Text = "Grafische Ansicht anzeigen/verbergen";
            this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem.Click += new System.EventHandler(this.grafischeAnsichtAnzeigenverbergenToolStripMenuItem_Click);
            // 
            // pbSpielfeld
            // 
            this.pbSpielfeld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSpielfeld.Location = new System.Drawing.Point(257, 27);
            this.pbSpielfeld.Name = "pbSpielfeld";
            this.pbSpielfeld.Size = new System.Drawing.Size(269, 388);
            this.pbSpielfeld.TabIndex = 2;
            this.pbSpielfeld.TabStop = false;
            this.pbSpielfeld.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSpielfeld_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusleiste});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(541, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusleiste
            // 
            this.lblStatusleiste.Name = "lblStatusleiste";
            this.lblStatusleiste.Size = new System.Drawing.Size(79, 17);
            this.lblStatusleiste.Text = "lblStatusleiste";
            // 
            // statusleisteEinblendenausblendenToolStripMenuItem
            // 
            this.statusleisteEinblendenausblendenToolStripMenuItem.Name = "statusleisteEinblendenausblendenToolStripMenuItem";
            this.statusleisteEinblendenausblendenToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.statusleisteEinblendenausblendenToolStripMenuItem.Text = "Statusleiste einblenden/ausblenden";
            this.statusleisteEinblendenausblendenToolStripMenuItem.Click += new System.EventHandler(this.statusleisteEinblendenausblendenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbSpielfeld);
            this.Controls.Add(this.rtbSpielfeld);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielfeld)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSpielfeld;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldLadenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSpielfeld;
        private System.Windows.Forms.ToolStripMenuItem opionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafischeAnsichtAnzeigenverbergenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusleiste;
        private System.Windows.Forms.ToolStripMenuItem statusleisteEinblendenausblendenToolStripMenuItem;
    }
}

