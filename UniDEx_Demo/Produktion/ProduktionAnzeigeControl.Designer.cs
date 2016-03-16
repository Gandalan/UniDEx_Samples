namespace UniDEx_Demo.Produktion
{
    partial class ProduktionAnzeigeControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialbedarfItemDataGridView = new System.Windows.Forms.DataGridView();
            this.Einheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stueckzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laufmeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IstZuschnitt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.objectPropertyDataGridView = new System.Windows.Forms.DataGridView();
            this.containerGrid = new System.Windows.Forms.DataGridView();
            this.BelegPositionsNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialbedarfItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialbedarfItemDataGridView
            // 
            this.materialbedarfItemDataGridView.AllowUserToAddRows = false;
            this.materialbedarfItemDataGridView.AllowUserToDeleteRows = false;
            this.materialbedarfItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialbedarfItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialbedarfItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Einheit,
            this.Stueckzahl,
            this.Laufmeter,
            this.IstZuschnitt});
            this.materialbedarfItemDataGridView.Location = new System.Drawing.Point(3, 344);
            this.materialbedarfItemDataGridView.Name = "materialbedarfItemDataGridView";
            this.materialbedarfItemDataGridView.ReadOnly = true;
            this.materialbedarfItemDataGridView.Size = new System.Drawing.Size(864, 204);
            this.materialbedarfItemDataGridView.TabIndex = 6;
            // 
            // Einheit
            // 
            this.Einheit.DataPropertyName = "Einheit";
            this.Einheit.HeaderText = "Einheit";
            this.Einheit.Name = "Einheit";
            this.Einheit.ReadOnly = true;
            // 
            // Stueckzahl
            // 
            this.Stueckzahl.DataPropertyName = "Stueckzahl";
            this.Stueckzahl.HeaderText = "Stueckzahl";
            this.Stueckzahl.Name = "Stueckzahl";
            this.Stueckzahl.ReadOnly = true;
            this.Stueckzahl.Width = 80;
            // 
            // Laufmeter
            // 
            this.Laufmeter.DataPropertyName = "Laufmeter";
            this.Laufmeter.HeaderText = "Laufmeter";
            this.Laufmeter.Name = "Laufmeter";
            this.Laufmeter.ReadOnly = true;
            // 
            // IstZuschnitt
            // 
            this.IstZuschnitt.DataPropertyName = "IstZuschnitt";
            this.IstZuschnitt.HeaderText = "IstZuschnitt";
            this.IstZuschnitt.Name = "IstZuschnitt";
            this.IstZuschnitt.ReadOnly = true;
            this.IstZuschnitt.Width = 70;
            // 
            // objectPropertyDataGridView
            // 
            this.objectPropertyDataGridView.AllowUserToAddRows = false;
            this.objectPropertyDataGridView.AllowUserToDeleteRows = false;
            this.objectPropertyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectPropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectPropertyDataGridView.Location = new System.Drawing.Point(3, 113);
            this.objectPropertyDataGridView.Name = "objectPropertyDataGridView";
            this.objectPropertyDataGridView.ReadOnly = true;
            this.objectPropertyDataGridView.Size = new System.Drawing.Size(864, 225);
            this.objectPropertyDataGridView.TabIndex = 4;
            // 
            // containerGrid
            // 
            this.containerGrid.AllowUserToAddRows = false;
            this.containerGrid.AllowUserToDeleteRows = false;
            this.containerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BelegPositionsNummer});
            this.containerGrid.Location = new System.Drawing.Point(3, 3);
            this.containerGrid.Name = "containerGrid";
            this.containerGrid.ReadOnly = true;
            this.containerGrid.Size = new System.Drawing.Size(864, 104);
            this.containerGrid.TabIndex = 5;
            // 
            // BelegPositionsNummer
            // 
            this.BelegPositionsNummer.DataPropertyName = "BelegPositionsNummer";
            this.BelegPositionsNummer.HeaderText = "BelegPositionsNummer";
            this.BelegPositionsNummer.Name = "BelegPositionsNummer";
            this.BelegPositionsNummer.ReadOnly = true;
            // 
            // ProduktionAnzeigeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialbedarfItemDataGridView);
            this.Controls.Add(this.objectPropertyDataGridView);
            this.Controls.Add(this.containerGrid);
            this.Name = "ProduktionAnzeigeControl";
            this.Size = new System.Drawing.Size(870, 551);
            ((System.ComponentModel.ISupportInitialize)(this.materialbedarfItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialbedarfItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Einheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stueckzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laufmeter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IstZuschnitt;
        private System.Windows.Forms.DataGridView objectPropertyDataGridView;
        private System.Windows.Forms.DataGridView containerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelegPositionsNummer;
    }
}
