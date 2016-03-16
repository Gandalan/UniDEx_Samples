namespace UniDEx_Demo.Etiketten
{
    partial class EtikettenAnzeigeControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialbedarfItemDataGridView = new System.Windows.Forms.DataGridView();
            this.objectPropertyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerGrid = new System.Windows.Forms.DataGridView();
            this.belegJahrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belegNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelegPositionsNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etikettenInfoContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Positionstext_Ausfuehrlich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etikettenInfoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materialbedarfItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etikettenInfoContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etikettenInfoItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialbedarfItemDataGridView
            // 
            this.materialbedarfItemDataGridView.AllowUserToAddRows = false;
            this.materialbedarfItemDataGridView.AllowUserToDeleteRows = false;
            this.materialbedarfItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialbedarfItemDataGridView.AutoGenerateColumns = false;
            this.materialbedarfItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialbedarfItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Positionstext_Ausfuehrlich});
            this.materialbedarfItemDataGridView.DataSource = this.etikettenInfoItemBindingSource;
            this.materialbedarfItemDataGridView.Location = new System.Drawing.Point(3, 344);
            this.materialbedarfItemDataGridView.Name = "materialbedarfItemDataGridView";
            this.materialbedarfItemDataGridView.ReadOnly = true;
            this.materialbedarfItemDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialbedarfItemDataGridView.RowTemplate.Height = 100;
            this.materialbedarfItemDataGridView.Size = new System.Drawing.Size(864, 204);
            this.materialbedarfItemDataGridView.TabIndex = 6;
            // 
            // objectPropertyDataGridView
            // 
            this.objectPropertyDataGridView.AllowUserToAddRows = false;
            this.objectPropertyDataGridView.AllowUserToDeleteRows = false;
            this.objectPropertyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectPropertyDataGridView.AutoGenerateColumns = false;
            this.objectPropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectPropertyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.objectPropertyDataGridView.DataSource = this.objectPropertyBindingSource;
            this.objectPropertyDataGridView.Location = new System.Drawing.Point(3, 113);
            this.objectPropertyDataGridView.Name = "objectPropertyDataGridView";
            this.objectPropertyDataGridView.ReadOnly = true;
            this.objectPropertyDataGridView.Size = new System.Drawing.Size(864, 225);
            this.objectPropertyDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ObjectPropertyGuid";
            this.dataGridViewTextBoxColumn1.HeaderText = "ObjectPropertyGuid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContainerGuid";
            this.dataGridViewTextBoxColumn2.HeaderText = "ContainerGuid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GroupGuid";
            this.dataGridViewTextBoxColumn4.HeaderText = "GroupGuid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Identifier";
            this.dataGridViewTextBoxColumn5.HeaderText = "Identifier";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // objectPropertyBindingSource
            // 
            this.objectPropertyBindingSource.DataSource = typeof(Gandalan.IDAS.UniDEx.Models.ObjectProperty);
            // 
            // containerGrid
            // 
            this.containerGrid.AllowUserToAddRows = false;
            this.containerGrid.AllowUserToDeleteRows = false;
            this.containerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerGrid.AutoGenerateColumns = false;
            this.containerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belegJahrDataGridViewTextBoxColumn,
            this.belegNummerDataGridViewTextBoxColumn,
            this.BelegPositionsNummer,
            this.containerGuidDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.containerGrid.DataSource = this.etikettenInfoContainerBindingSource;
            this.containerGrid.Location = new System.Drawing.Point(3, 3);
            this.containerGrid.Name = "containerGrid";
            this.containerGrid.ReadOnly = true;
            this.containerGrid.Size = new System.Drawing.Size(864, 104);
            this.containerGrid.TabIndex = 5;
            // 
            // belegJahrDataGridViewTextBoxColumn
            // 
            this.belegJahrDataGridViewTextBoxColumn.DataPropertyName = "BelegJahr";
            this.belegJahrDataGridViewTextBoxColumn.HeaderText = "BelegJahr";
            this.belegJahrDataGridViewTextBoxColumn.Name = "belegJahrDataGridViewTextBoxColumn";
            this.belegJahrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // belegNummerDataGridViewTextBoxColumn
            // 
            this.belegNummerDataGridViewTextBoxColumn.DataPropertyName = "BelegNummer";
            this.belegNummerDataGridViewTextBoxColumn.HeaderText = "BelegNummer";
            this.belegNummerDataGridViewTextBoxColumn.Name = "belegNummerDataGridViewTextBoxColumn";
            this.belegNummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BelegPositionsNummer
            // 
            this.BelegPositionsNummer.DataPropertyName = "BelegPositionsNummer";
            this.BelegPositionsNummer.HeaderText = "BelegPositionsNummer";
            this.BelegPositionsNummer.Name = "BelegPositionsNummer";
            this.BelegPositionsNummer.ReadOnly = true;
            // 
            // containerGuidDataGridViewTextBoxColumn
            // 
            this.containerGuidDataGridViewTextBoxColumn.DataPropertyName = "ContainerGuid";
            this.containerGuidDataGridViewTextBoxColumn.HeaderText = "ContainerGuid";
            this.containerGuidDataGridViewTextBoxColumn.Name = "containerGuidDataGridViewTextBoxColumn";
            this.containerGuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textInfoContainerBindingSource
            // 
            this.etikettenInfoContainerBindingSource.DataSource = typeof(Gandalan.IDAS.UniDEx.Provider.Materialbedarf.MaterialBedarfContainer);
            this.etikettenInfoContainerBindingSource.CurrentChanged += new System.EventHandler(this.etikettenInfoContainerBindingSource_CurrentChanged);
            // 
            // Positionstext_Ausfuehrlich
            // 
            this.Positionstext_Ausfuehrlich.DataPropertyName = "Positionstext_Ausfuehrlich";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Positionstext_Ausfuehrlich.DefaultCellStyle = dataGridViewCellStyle1;
            this.Positionstext_Ausfuehrlich.HeaderText = "Positionstext_Ausfuehrlich";
            this.Positionstext_Ausfuehrlich.Name = "Positionstext_Ausfuehrlich";
            this.Positionstext_Ausfuehrlich.ReadOnly = true;
            this.Positionstext_Ausfuehrlich.Width = 500;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kennzeichen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kennzeichen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // textInfoItemBindingSource
            // 
            this.etikettenInfoItemBindingSource.DataSource = typeof(UniDEx_Demo.Texte.TextItem);
            // 
            // TextAnzeigeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialbedarfItemDataGridView);
            this.Controls.Add(this.objectPropertyDataGridView);
            this.Controls.Add(this.containerGrid);
            this.Name = "TextAnzeigeControl";
            this.Size = new System.Drawing.Size(870, 551);
            ((System.ComponentModel.ISupportInitialize)(this.materialbedarfItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPropertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etikettenInfoContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etikettenInfoItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialbedarfItemDataGridView;
        private System.Windows.Forms.BindingSource etikettenInfoItemBindingSource;
        private System.Windows.Forms.DataGridView objectPropertyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource objectPropertyBindingSource;
        private System.Windows.Forms.DataGridView containerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn belegJahrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belegNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelegPositionsNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource etikettenInfoContainerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Positionstext_Ausfuehrlich;
    }
}
