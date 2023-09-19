namespace uebung_auto_in_oo
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
            this.btn_erzeugen = new System.Windows.Forms.Button();
            this.btn_setze_werte = new System.Windows.Forms.Button();
            this.btn_gib_werte = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_preis = new System.Windows.Forms.TextBox();
            this.tb_farbe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_erzeugen
            // 
            this.btn_erzeugen.Location = new System.Drawing.Point(25, 41);
            this.btn_erzeugen.Name = "btn_erzeugen";
            this.btn_erzeugen.Size = new System.Drawing.Size(75, 23);
            this.btn_erzeugen.TabIndex = 0;
            this.btn_erzeugen.Text = "erzeugen";
            this.btn_erzeugen.UseVisualStyleBackColor = true;
            this.btn_erzeugen.Click += new System.EventHandler(this.btn_erzeugen_Click);
            // 
            // btn_setze_werte
            // 
            this.btn_setze_werte.Location = new System.Drawing.Point(25, 70);
            this.btn_setze_werte.Name = "btn_setze_werte";
            this.btn_setze_werte.Size = new System.Drawing.Size(75, 23);
            this.btn_setze_werte.TabIndex = 1;
            this.btn_setze_werte.Text = "setze werte";
            this.btn_setze_werte.UseVisualStyleBackColor = true;
            this.btn_setze_werte.Click += new System.EventHandler(this.btn_setze_werte_Click);
            // 
            // btn_gib_werte
            // 
            this.btn_gib_werte.Location = new System.Drawing.Point(25, 99);
            this.btn_gib_werte.Name = "btn_gib_werte";
            this.btn_gib_werte.Size = new System.Drawing.Size(75, 23);
            this.btn_gib_werte.TabIndex = 2;
            this.btn_gib_werte.Text = "gib werte";
            this.btn_gib_werte.UseVisualStyleBackColor = true;
            this.btn_gib_werte.Click += new System.EventHandler(this.btn_gib_werte_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.Location = new System.Drawing.Point(25, 128);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(75, 23);
            this.btn_loeschen.TabIndex = 3;
            this.btn_loeschen.Text = "löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Farbe";
            // 
            // tb_preis
            // 
            this.tb_preis.Location = new System.Drawing.Point(120, 70);
            this.tb_preis.Name = "tb_preis";
            this.tb_preis.Size = new System.Drawing.Size(100, 20);
            this.tb_preis.TabIndex = 6;
            // 
            // tb_farbe
            // 
            this.tb_farbe.Location = new System.Drawing.Point(120, 130);
            this.tb_farbe.Name = "tb_farbe";
            this.tb_farbe.Size = new System.Drawing.Size(100, 20);
            this.tb_farbe.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_farbe);
            this.Controls.Add(this.tb_preis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_gib_werte);
            this.Controls.Add(this.btn_setze_werte);
            this.Controls.Add(this.btn_erzeugen);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_erzeugen;
        private System.Windows.Forms.Button btn_setze_werte;
        private System.Windows.Forms.Button btn_gib_werte;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_preis;
        private System.Windows.Forms.TextBox tb_farbe;
    }
}

