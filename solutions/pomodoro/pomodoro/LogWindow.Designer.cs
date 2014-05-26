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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWindow));
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
            resources.ApplyResources(entryIDLabel, "entryIDLabel");
            entryIDLabel.Name = "entryIDLabel";
            // 
            // timestampLabel
            // 
            resources.ApplyResources(timestampLabel, "timestampLabel");
            timestampLabel.Name = "timestampLabel";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.Name = "descriptionLabel";
            // 
            // tLPMain
            // 
            resources.ApplyResources(this.tLPMain, "tLPMain");
            this.tLPMain.Controls.Add(this.tLPEntryList, 0, 0);
            this.tLPMain.Controls.Add(this.tLPDetails, 0, 1);
            this.tLPMain.Name = "tLPMain";
            // 
            // tLPEntryList
            // 
            resources.ApplyResources(this.tLPEntryList, "tLPEntryList");
            this.tLPEntryList.Controls.Add(this.entryDataGridView, 0, 0);
            this.tLPEntryList.Name = "tLPEntryList";
            // 
            // entryDataGridView
            // 
            resources.ApplyResources(this.entryDataGridView, "entryDataGridView");
            this.entryDataGridView.AllowUserToAddRows = false;
            this.entryDataGridView.AllowUserToDeleteRows = false;
            this.entryDataGridView.AutoGenerateColumns = false;
            this.entryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.entryDataGridView.DataSource = this.entryBindingSource;
            this.entryDataGridView.Name = "entryDataGridView";
            this.entryDataGridView.ReadOnly = true;
            this.entryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EntryID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Timestamp";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
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
            resources.ApplyResources(this.tLPDetails, "tLPDetails");
            this.tLPDetails.Controls.Add(this.panel1, 0, 0);
            this.tLPDetails.Controls.Add(this.panel2, 0, 1);
            this.tLPDetails.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tLPDetails.Controls.Add(this.buttonExport, 1, 1);
            this.tLPDetails.Name = "tLPDetails";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(entryIDLabel);
            this.panel1.Controls.Add(this.entryIDTextBox);
            this.panel1.Controls.Add(timestampLabel);
            this.panel1.Controls.Add(this.timestampTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Name = "panel1";
            // 
            // entryIDTextBox
            // 
            resources.ApplyResources(this.entryIDTextBox, "entryIDTextBox");
            this.entryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "EntryID", true));
            this.entryIDTextBox.Name = "entryIDTextBox";
            this.entryIDTextBox.ReadOnly = true;
            this.entryIDTextBox.TextChanged += new System.EventHandler(this.entryIDTextBox_TextChanged);
            // 
            // timestampTextBox
            // 
            resources.ApplyResources(this.timestampTextBox, "timestampTextBox");
            this.timestampTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Timestamp", true));
            this.timestampTextBox.Name = "timestampTextBox";
            this.timestampTextBox.ReadOnly = true;
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entryBindingSource, "Description", true));
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Enter += new System.EventHandler(this.descriptionTextBox_Enter);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.tBTags);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            // 
            // tBTags
            // 
            resources.ApplyResources(this.tBTags, "tBTags");
            this.tBTags.Name = "tBTags";
            this.tBTags.Enter += new System.EventHandler(this.tBTags_Enter);
            this.tBTags.Validating += new System.ComponentModel.CancelEventHandler(this.tBTags_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExport
            // 
            resources.ApplyResources(this.buttonExport, "buttonExport");
            this.buttonExport.Name = "buttonExport";
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLPMain);
            this.Name = "LogWindow";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}