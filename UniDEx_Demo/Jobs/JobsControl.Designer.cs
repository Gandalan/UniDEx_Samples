namespace UniDEx_Demo.Jobs
{
    partial class JobsControl
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
            this.jobViewModelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobParameterViewModelDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richtungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatusViewModelDataGridView = new System.Windows.Forms.DataGridView();
            this.zeitstempelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobParameterViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobStatusViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobViewModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobParameterViewModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusViewModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobParameterViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobViewModelDataGridView
            // 
            this.jobViewModelDataGridView.AllowUserToAddRows = false;
            this.jobViewModelDataGridView.AllowUserToDeleteRows = false;
            this.jobViewModelDataGridView.AutoGenerateColumns = false;
            this.jobViewModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobViewModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.jobViewModelDataGridView.DataSource = this.jobViewModelBindingSource;
            this.jobViewModelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobViewModelDataGridView.Location = new System.Drawing.Point(4, 4);
            this.jobViewModelDataGridView.Name = "jobViewModelDataGridView";
            this.jobViewModelDataGridView.ReadOnly = true;
            this.jobViewModelDataGridView.RowHeadersVisible = false;
            this.jobViewModelDataGridView.Size = new System.Drawing.Size(833, 150);
            this.jobViewModelDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Erstellt";
            this.dataGridViewTextBoxColumn1.HeaderText = "Erstellt";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 63;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Geaendert";
            this.dataGridViewTextBoxColumn2.HeaderText = "Geaendert";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "JobId";
            this.dataGridViewTextBoxColumn3.HeaderText = "JobId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 58;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Recipient";
            this.dataGridViewTextBoxColumn4.HeaderText = "Recipient";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 66;
            // 
            // jobViewModelBindingSource
            // 
            this.jobViewModelBindingSource.DataSource = typeof(UniDEx_Demo.Jobs.JobViewModel);
            // 
            // jobParameterViewModelDataGridView
            // 
            this.jobParameterViewModelDataGridView.AllowUserToAddRows = false;
            this.jobParameterViewModelDataGridView.AllowUserToDeleteRows = false;
            this.jobParameterViewModelDataGridView.AutoGenerateColumns = false;
            this.jobParameterViewModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobParameterViewModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.richtungDataGridViewTextBoxColumn,
            this.wertDataGridViewTextBoxColumn,
            this.datenTypDataGridViewTextBoxColumn});
            this.jobParameterViewModelDataGridView.DataMember = "Parameter";
            this.jobParameterViewModelDataGridView.DataSource = this.jobViewModelBindingSource;
            this.jobParameterViewModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobParameterViewModelDataGridView.Location = new System.Drawing.Point(4, 293);
            this.jobParameterViewModelDataGridView.Name = "jobParameterViewModelDataGridView";
            this.jobParameterViewModelDataGridView.ReadOnly = true;
            this.jobParameterViewModelDataGridView.RowHeadersVisible = false;
            this.jobParameterViewModelDataGridView.Size = new System.Drawing.Size(833, 244);
            this.jobParameterViewModelDataGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // richtungDataGridViewTextBoxColumn
            // 
            this.richtungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.richtungDataGridViewTextBoxColumn.DataPropertyName = "Richtung";
            this.richtungDataGridViewTextBoxColumn.HeaderText = "Richtung";
            this.richtungDataGridViewTextBoxColumn.Name = "richtungDataGridViewTextBoxColumn";
            this.richtungDataGridViewTextBoxColumn.ReadOnly = true;
            this.richtungDataGridViewTextBoxColumn.Width = 75;
            // 
            // wertDataGridViewTextBoxColumn
            // 
            this.wertDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wertDataGridViewTextBoxColumn.DataPropertyName = "Wert";
            this.wertDataGridViewTextBoxColumn.HeaderText = "Wert";
            this.wertDataGridViewTextBoxColumn.Name = "wertDataGridViewTextBoxColumn";
            this.wertDataGridViewTextBoxColumn.ReadOnly = true;
            this.wertDataGridViewTextBoxColumn.Width = 55;
            // 
            // datenTypDataGridViewTextBoxColumn
            // 
            this.datenTypDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datenTypDataGridViewTextBoxColumn.DataPropertyName = "DatenTyp";
            this.datenTypDataGridViewTextBoxColumn.HeaderText = "DatenTyp";
            this.datenTypDataGridViewTextBoxColumn.Name = "datenTypDataGridViewTextBoxColumn";
            this.datenTypDataGridViewTextBoxColumn.ReadOnly = true;
            this.datenTypDataGridViewTextBoxColumn.Width = 79;
            // 
            // jobStatusViewModelDataGridView
            // 
            this.jobStatusViewModelDataGridView.AllowUserToAddRows = false;
            this.jobStatusViewModelDataGridView.AllowUserToDeleteRows = false;
            this.jobStatusViewModelDataGridView.AutoGenerateColumns = false;
            this.jobStatusViewModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobStatusViewModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zeitstempelDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.statusTextDataGridViewTextBoxColumn});
            this.jobStatusViewModelDataGridView.DataMember = "Stati";
            this.jobStatusViewModelDataGridView.DataSource = this.jobViewModelBindingSource;
            this.jobStatusViewModelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobStatusViewModelDataGridView.Location = new System.Drawing.Point(4, 154);
            this.jobStatusViewModelDataGridView.Name = "jobStatusViewModelDataGridView";
            this.jobStatusViewModelDataGridView.ReadOnly = true;
            this.jobStatusViewModelDataGridView.RowHeadersVisible = false;
            this.jobStatusViewModelDataGridView.Size = new System.Drawing.Size(833, 139);
            this.jobStatusViewModelDataGridView.TabIndex = 2;
            // 
            // zeitstempelDataGridViewTextBoxColumn
            // 
            this.zeitstempelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zeitstempelDataGridViewTextBoxColumn.DataPropertyName = "Zeitstempel";
            this.zeitstempelDataGridViewTextBoxColumn.HeaderText = "Zeitstempel";
            this.zeitstempelDataGridViewTextBoxColumn.Name = "zeitstempelDataGridViewTextBoxColumn";
            this.zeitstempelDataGridViewTextBoxColumn.ReadOnly = true;
            this.zeitstempelDataGridViewTextBoxColumn.Width = 86;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusCodeDataGridViewTextBoxColumn.Width = 87;
            // 
            // statusTextDataGridViewTextBoxColumn
            // 
            this.statusTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusTextDataGridViewTextBoxColumn.DataPropertyName = "StatusText";
            this.statusTextDataGridViewTextBoxColumn.HeaderText = "StatusText";
            this.statusTextDataGridViewTextBoxColumn.Name = "statusTextDataGridViewTextBoxColumn";
            this.statusTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusTextDataGridViewTextBoxColumn.Width = 83;
            // 
            // jobParameterViewModelBindingSource
            // 
            this.jobParameterViewModelBindingSource.DataSource = typeof(UniDEx_Demo.Jobs.JobParameterViewModel);
            // 
            // jobStatusViewModelBindingSource
            // 
            this.jobStatusViewModelBindingSource.DataSource = typeof(UniDEx_Demo.Jobs.JobStatusViewModel);
            // 
            // JobsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobParameterViewModelDataGridView);
            this.Controls.Add(this.jobStatusViewModelDataGridView);
            this.Controls.Add(this.jobViewModelDataGridView);
            this.Name = "JobsControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(841, 541);
            ((System.ComponentModel.ISupportInitialize)(this.jobViewModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobParameterViewModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusViewModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobParameterViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource jobViewModelBindingSource;
        private System.Windows.Forms.DataGridView jobViewModelDataGridView;
        private System.Windows.Forms.BindingSource jobParameterViewModelBindingSource;
        private System.Windows.Forms.DataGridView jobParameterViewModelDataGridView;
        private System.Windows.Forms.BindingSource jobStatusViewModelBindingSource;
        private System.Windows.Forms.DataGridView jobStatusViewModelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn richtungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeitstempelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTextDataGridViewTextBoxColumn;
    }
}
