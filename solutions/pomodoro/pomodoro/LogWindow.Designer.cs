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
            System.Windows.Forms.Label entryIDLabel;
            System.Windows.Forms.Label timestampLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tLPEntryList = new System.Windows.Forms.TableLayoutPanel();
            this.entryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pomodoroDataSet = new pomodoro.pomodoroDataSet();
            this.tLPDetails = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.entryIDTextBox = new System.Windows.Forms.TextBox();
            this.timestampTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBTags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.entryTableAdapter = new pomodoro.pomodoroDataSetTableAdapters.EntryTableAdapter();
            this.tableAdapterManager = new pomodoro.pomodoroDataSetTableAdapters.TableAdapterManager();
            entryIDLabel = new System.Windows.Forms.Label();
            timestampLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.tLPMain.SuspendLayout();
            this.tLPEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDataSet)).BeginInit();
            this.tLPDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryIDLabel
            // 
            entryIDLabel.AutoSize = true;
            entryIDLabel.Location = new System.Drawing.Point(3, 9);
            entryIDLabel.Name = "entryIDLabel";
            entryIDLabel.Size = new System.Drawing.Size(48, 13);
            entryIDLabel.TabIndex = 0;
            entryIDLabel.Text = "Entry ID:";
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Location = new System.Drawing.Point(146, 9);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new System.Drawing.Size(61, 13);
            timestampLabel.TabIndex = 2;
            timestampLabel.Text = "Timestamp:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 33);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
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
            this.tLPMain.Size = new System.Drawing.Size(780, 438);
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
            this.tLPEntryList.Size = new System.Drawing.Size(774, 213);
            this.tLPEntryList.TabIndex = 0;
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
            this.entryDataGridView.Size = new System.Drawing.Size(768, 207);
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
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.pomodoroDataSet;
            // 
            // pomodoroDataSet
            // 
            this.pomodoroDataSet.DataSetName = "pomodoroDataSet";
            this.pomodoroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLPDetails
            // 
            this.tLPDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPDetails.ColumnCount = 2;
            this.tLPDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.Controls.Add(this.panel1, 0, 0);
            this.tLPDetails.Controls.Add(this.panel2, 0, 1);
            this.tLPDetails.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tLPDetails.Controls.Add(this.buttonExport, 1, 1);
            this.tLPDetails.Location = new System.Drawing.Point(3, 222);
            this.tLPDetails.Name = "tLPDetails";
            this.tLPDetails.RowCount = 2;
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPDetails.Size = new System.Drawing.Size(774, 213);
            this.tLPDetails.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(entryIDLabel);
            this.panel1.Controls.Add(this.entryIDTextBox);
            this.panel1.Controls.Add(timestampLabel);
            this.panel1.Controls.Add(this.timestampTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 141);
            this.panel1.TabIndex = 0;
            // 
            // entryIDTextBox
            // 
            this.entryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "EntryID", true));
            this.entryIDTextBox.Location = new System.Drawing.Point(72, 6);
            this.entryIDTextBox.Name = "entryIDTextBox";
            this.entryIDTextBox.ReadOnly = true;
            this.entryIDTextBox.Size = new System.Drawing.Size(68, 20);
            this.entryIDTextBox.TabIndex = 1;
            this.entryIDTextBox.TextChanged += new System.EventHandler(this.entryIDTextBox_TextChanged);
            // 
            // timestampTextBox
            // 
            this.timestampTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Timestamp", true));
            this.timestampTextBox.Location = new System.Drawing.Point(213, 6);
            this.timestampTextBox.Name = "timestampTextBox";
            this.timestampTextBox.ReadOnly = true;
            this.timestampTextBox.Size = new System.Drawing.Size(165, 20);
            this.timestampTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(72, 33);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(306, 105);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Enter += new System.EventHandler(this.descriptionTextBox_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBTags);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 57);
            this.panel2.TabIndex = 1;
            // 
            // tBTags
            // 
            this.tBTags.Location = new System.Drawing.Point(72, 0);
            this.tBTags.Multiline = true;
            this.tBTags.Name = "tBTags";
            this.tBTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBTags.Size = new System.Drawing.Size(306, 54);
            this.tBTags.TabIndex = 1;
            this.tBTags.Enter += new System.EventHandler(this.tBTags_Enter);
            this.tBTags.Validating += new System.ComponentModel.CancelEventHandler(this.tBTags_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tags:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(390, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 144);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(100, 15);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(100, 15, 100, 15);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(181, 42);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(100, 87);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(100, 15, 100, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(181, 42);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(487, 165);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(100, 15, 100, 15);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(187, 33);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
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
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.tLPMain);
            this.MaximumSize = new System.Drawing.Size(820, 501);
            this.MinimumSize = new System.Drawing.Size(820, 501);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.tLPMain.ResumeLayout(false);
            this.tLPEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomodoroDataSet)).EndInit();
            this.tLPDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox entryIDTextBox;
        private System.Windows.Forms.TextBox timestampTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
    }
}