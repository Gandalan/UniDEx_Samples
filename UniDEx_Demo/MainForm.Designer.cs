namespace UniDEx_Demo
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaterialBedarf = new System.Windows.Forms.TabPage();
            this.tabTexte = new System.Windows.Forms.TabPage();
            this.tabEtiketten = new System.Windows.Forms.TabPage();
            this.tabPreise = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aktualisierenButton = new System.Windows.Forms.Button();
            this.materialBedarfAnzeigeControl = new UniDEx_Demo.Materialbedarf.MaterialBedarfAnzeigeControl();
            this.textAnzeigeControl = new UniDEx_Demo.Texte.TextAnzeigeControl();
            this.etikettenAnzeigeControl = new UniDEx_Demo.Etiketten.EtikettenAnzeigeControl();
            this.preisAnzeigeControl = new UniDEx_Demo.Preise.PreisAnzeigeControl();
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.jobsControl = new UniDEx_Demo.Jobs.JobsControl();
            this.tabControl1.SuspendLayout();
            this.tabMaterialBedarf.SuspendLayout();
            this.tabTexte.SuspendLayout();
            this.tabEtiketten.SuspendLayout();
            this.tabPreise.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaterialBedarf);
            this.tabControl1.Controls.Add(this.tabTexte);
            this.tabControl1.Controls.Add(this.tabEtiketten);
            this.tabControl1.Controls.Add(this.tabPreise);
            this.tabControl1.Controls.Add(this.tabJobs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMaterialBedarf
            // 
            this.tabMaterialBedarf.Controls.Add(this.materialBedarfAnzeigeControl);
            this.tabMaterialBedarf.Location = new System.Drawing.Point(4, 22);
            this.tabMaterialBedarf.Name = "tabMaterialBedarf";
            this.tabMaterialBedarf.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterialBedarf.Size = new System.Drawing.Size(953, 632);
            this.tabMaterialBedarf.TabIndex = 0;
            this.tabMaterialBedarf.Text = "Materialbedarf";
            this.tabMaterialBedarf.UseVisualStyleBackColor = true;
            // 
            // tabTexte
            // 
            this.tabTexte.Controls.Add(this.textAnzeigeControl);
            this.tabTexte.Location = new System.Drawing.Point(4, 22);
            this.tabTexte.Name = "tabTexte";
            this.tabTexte.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexte.Size = new System.Drawing.Size(953, 632);
            this.tabTexte.TabIndex = 1;
            this.tabTexte.Text = "Texte";
            this.tabTexte.UseVisualStyleBackColor = true;
            // 
            // tabEtiketten
            // 
            this.tabEtiketten.Controls.Add(this.etikettenAnzeigeControl);
            this.tabEtiketten.Location = new System.Drawing.Point(4, 22);
            this.tabEtiketten.Name = "tabEtiketten";
            this.tabEtiketten.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtiketten.Size = new System.Drawing.Size(953, 632);
            this.tabEtiketten.TabIndex = 2;
            this.tabEtiketten.Text = "Etiketten";
            this.tabEtiketten.UseVisualStyleBackColor = true;
            // 
            // tabPreise
            // 
            this.tabPreise.Controls.Add(this.preisAnzeigeControl);
            this.tabPreise.Location = new System.Drawing.Point(4, 22);
            this.tabPreise.Name = "tabPreise";
            this.tabPreise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreise.Size = new System.Drawing.Size(953, 632);
            this.tabPreise.TabIndex = 3;
            this.tabPreise.Text = "Preise";
            this.tabPreise.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aktualisierenButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 45);
            this.panel1.TabIndex = 1;
            // 
            // aktualisierenButton
            // 
            this.aktualisierenButton.Location = new System.Drawing.Point(7, 3);
            this.aktualisierenButton.Name = "aktualisierenButton";
            this.aktualisierenButton.Size = new System.Drawing.Size(92, 23);
            this.aktualisierenButton.TabIndex = 0;
            this.aktualisierenButton.Text = "Aktualisieren";
            this.aktualisierenButton.UseVisualStyleBackColor = true;
            this.aktualisierenButton.Click += new System.EventHandler(this.aktualisierenButton_Click);
            // 
            // materialBedarfAnzeigeControl
            // 
            this.materialBedarfAnzeigeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialBedarfAnzeigeControl.Location = new System.Drawing.Point(3, 3);
            this.materialBedarfAnzeigeControl.Name = "materialBedarfAnzeigeControl";
            this.materialBedarfAnzeigeControl.Size = new System.Drawing.Size(947, 626);
            this.materialBedarfAnzeigeControl.TabIndex = 0;
            // 
            // textAnzeigeControl
            // 
            this.textAnzeigeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAnzeigeControl.Location = new System.Drawing.Point(3, 3);
            this.textAnzeigeControl.Name = "textAnzeigeControl";
            this.textAnzeigeControl.Size = new System.Drawing.Size(947, 626);
            this.textAnzeigeControl.TabIndex = 0;
            // 
            // etikettenAnzeigeControl
            // 
            this.etikettenAnzeigeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etikettenAnzeigeControl.Location = new System.Drawing.Point(3, 3);
            this.etikettenAnzeigeControl.Name = "etikettenAnzeigeControl";
            this.etikettenAnzeigeControl.Size = new System.Drawing.Size(947, 626);
            this.etikettenAnzeigeControl.TabIndex = 0;
            // 
            // preisAnzeigeControl
            // 
            this.preisAnzeigeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preisAnzeigeControl.Location = new System.Drawing.Point(3, 3);
            this.preisAnzeigeControl.Name = "preisAnzeigeControl";
            this.preisAnzeigeControl.Size = new System.Drawing.Size(947, 626);
            this.preisAnzeigeControl.TabIndex = 0;
            // 
            // tabJobs
            // 
            this.tabJobs.Controls.Add(this.jobsControl);
            this.tabJobs.Location = new System.Drawing.Point(4, 22);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobs.Size = new System.Drawing.Size(953, 632);
            this.tabJobs.TabIndex = 4;
            this.tabJobs.Text = "Jobs";
            this.tabJobs.UseVisualStyleBackColor = true;
            // 
            // jobsControl1
            // 
            this.jobsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsControl.Location = new System.Drawing.Point(3, 3);
            this.jobsControl.Name = "jobsControl1";
            this.jobsControl.Size = new System.Drawing.Size(947, 626);
            this.jobsControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 719);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Gandalan UniDEx - Demoprojekt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMaterialBedarf.ResumeLayout(false);
            this.tabTexte.ResumeLayout(false);
            this.tabEtiketten.ResumeLayout(false);
            this.tabPreise.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabJobs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaterialBedarf;
        private Materialbedarf.MaterialBedarfAnzeigeControl materialBedarfAnzeigeControl;
        private System.Windows.Forms.TabPage tabTexte;
        private Texte.TextAnzeigeControl textAnzeigeControl;
        private System.Windows.Forms.TabPage tabEtiketten;
        private Etiketten.EtikettenAnzeigeControl etikettenAnzeigeControl;
        private System.Windows.Forms.TabPage tabPreise;
        private Preise.PreisAnzeigeControl preisAnzeigeControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aktualisierenButton;
        private System.Windows.Forms.TabPage tabJobs;
        private Jobs.JobsControl jobsControl;
    }
}

