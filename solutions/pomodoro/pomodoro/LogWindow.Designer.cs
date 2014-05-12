namespace pomodoro
{
    partial class LogWindow
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
            this.components = new System.ComponentModel.Container();
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tLPEntryList = new System.Windows.Forms.TableLayoutPanel();
            this.tLPDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pomodoroDataSet = new pomodoro.pomodoroDataSet();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryTableAdapter = new pomodoro.pomodoroDataSetTableAdapters.EntryTableAdapter();
            this.tableAdapterManager = new pomodoro.pomodoroDataSetTableAdapters.TableAdapterManager();
            this.entryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLPMain.SuspendLayout();
            this.tLPEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.Controls.Add(this.tLPEntryList, 0, 0);
            this.tLPMain.Controls.Add(this.tLPDetails, 0, 1);
            this.tLPMain.Location = new System.Drawing.Point(12, 12);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 2;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.Size = new System.Drawing.Size(780, 393);
            this.tLPMain.TabIndex = 0;
            // 
            // tLPEntryList
            // 
            this.tLPEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPEntryList.AutoScroll = true;
            this.tLPEntryList.ColumnCount = 1;
            this.tLPEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPEntryList.Controls.Add(this.entryDataGridView, 0, 0);
            this.tLPEntryList.Location = new System.Drawing.Point(3, 3);
            this.tLPEntryList.Name = "tLPEntryList";
            this.tLPEntryList.RowCount = 1;
            this.tLPEntryList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPEntryList.Size = new System.Drawing.Size(774, 190);
            this.tLPEntryList.TabIndex = 0;
            // 
            // tLPDetails
            // 
            this.tLPDetails.ColumnCount = 2;
            this.tLPDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.Location = new System.Drawing.Point(3, 199);
            this.tLPDetails.Name = "tLPDetails";
            this.tLPDetails.RowCount = 2;
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.Size = new System.Drawing.Size(200, 100);
            this.tLPDetails.TabIndex = 1;
            // 
            // pomodoroDataSet
            // 
            this.pomodoroDataSet.DataSetName = "pomodoroDataSet";
            this.pomodoroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.pomodoroDataSet;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Entry_TagTableAdapter = null;
            this.tableAdapterManager.EntryTableAdapter = this.entryTableAdapter;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pomodoro.pomodoroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entryDataGridView
            // 
            this.entryDataGridView.AllowUserToAddRows = false;
            this.entryDataGridView.AllowUserToDeleteRows = false;
            this.entryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryDataGridView.AutoGenerateColumns = false;
            this.entryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.entryDataGridView.DataSource = this.entryBindingSource;
            this.entryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.entryDataGridView.Name = "entryDataGridView";
            this.entryDataGridView.ReadOnly = true;
            this.entryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entryDataGridView.Size = new System.Drawing.Size(768, 184);
            this.entryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EntryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entry ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Timestamp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Timestamp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 417);
            this.Controls.Add(this.tLPMain);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.tLPMain.ResumeLayout(false);
            this.tLPEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.TableLayoutPanel tLPEntryList;
        private System.Windows.Forms.TableLayoutPanel tLPDetails;
        private pomodoroDataSet pomodoroDataSet;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private pomodoroDataSetTableAdapters.EntryTableAdapter entryTableAdapter;
        private pomodoroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView entryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}