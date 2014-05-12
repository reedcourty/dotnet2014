namespace pomodoro
{
    partial class MainWindow
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
            this.tLPCounter = new System.Windows.Forms.TableLayoutPanel();
            this.tBCounter = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bWCounter = new System.ComponentModel.BackgroundWorker();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.tBTags = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lTags = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.tLPEntry = new System.Windows.Forms.TableLayoutPanel();
            this.bLogs = new System.Windows.Forms.Button();
            this.tLPCounter.SuspendLayout();
            this.tLPEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPCounter
            // 
            this.tLPCounter.ColumnCount = 5;
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tLPCounter.Controls.Add(this.tBCounter, 0, 0);
            this.tLPCounter.Controls.Add(this.bStart, 4, 0);
            this.tLPCounter.Location = new System.Drawing.Point(12, 12);
            this.tLPCounter.Name = "tLPCounter";
            this.tLPCounter.RowCount = 1;
            this.tLPCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPCounter.Size = new System.Drawing.Size(259, 57);
            this.tLPCounter.TabIndex = 0;
            // 
            // tBCounter
            // 
            this.tBCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPCounter.SetColumnSpan(this.tBCounter, 3);
            this.tBCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBCounter.Location = new System.Drawing.Point(3, 3);
            this.tBCounter.Name = "tBCounter";
            this.tBCounter.Size = new System.Drawing.Size(149, 50);
            this.tBCounter.TabIndex = 1;
            this.tBCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bStart
            // 
            this.bStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bStart.Location = new System.Drawing.Point(173, 10);
            this.bStart.Margin = new System.Windows.Forms.Padding(10);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(76, 37);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bWCounter
            // 
            this.bWCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWCounter_DoWork);
            this.bWCounter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWCounter_RunWorkerCompleted);
            // 
            // tBDescription
            // 
            this.tBDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPEntry.SetColumnSpan(this.tBDescription, 3);
            this.tBDescription.Location = new System.Drawing.Point(3, 20);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBDescription.Size = new System.Drawing.Size(397, 88);
            this.tBDescription.TabIndex = 1;
            // 
            // tBTags
            // 
            this.tBTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPEntry.SetColumnSpan(this.tBTags, 2);
            this.tBTags.Location = new System.Drawing.Point(77, 122);
            this.tBTags.Name = "tBTags";
            this.tBTags.Size = new System.Drawing.Size(323, 20);
            this.tBTags.TabIndex = 2;
            // 
            // lDescription
            // 
            this.lDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(3, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(68, 17);
            this.lDescription.TabIndex = 3;
            this.lDescription.Text = "Description:";
            this.lDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTags
            // 
            this.lTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTags.AutoSize = true;
            this.lTags.Location = new System.Drawing.Point(3, 119);
            this.lTags.Name = "lTags";
            this.lTags.Size = new System.Drawing.Size(68, 26);
            this.lTags.TabIndex = 4;
            this.lTags.Text = "Tags:";
            this.lTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(313, 159);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(87, 22);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tLPEntry
            // 
            this.tLPEntry.ColumnCount = 3;
            this.tLPEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.88535F));
            this.tLPEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.11465F));
            this.tLPEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tLPEntry.Controls.Add(this.lDescription, 0, 0);
            this.tLPEntry.Controls.Add(this.bSave, 2, 5);
            this.tLPEntry.Controls.Add(this.tBDescription, 0, 1);
            this.tLPEntry.Controls.Add(this.lTags, 0, 3);
            this.tLPEntry.Controls.Add(this.tBTags, 1, 3);
            this.tLPEntry.Location = new System.Drawing.Point(12, 93);
            this.tLPEntry.Name = "tLPEntry";
            this.tLPEntry.RowCount = 6;
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31532F));
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.68468F));
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tLPEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPEntry.Size = new System.Drawing.Size(403, 184);
            this.tLPEntry.TabIndex = 6;
            // 
            // bLogs
            // 
            this.bLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogs.Location = new System.Drawing.Point(337, 29);
            this.bLogs.Name = "bLogs";
            this.bLogs.Size = new System.Drawing.Size(75, 23);
            this.bLogs.TabIndex = 7;
            this.bLogs.Text = "Logs";
            this.bLogs.UseVisualStyleBackColor = true;
            this.bLogs.Click += new System.EventHandler(this.bLogs_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 289);
            this.Controls.Add(this.bLogs);
            this.Controls.Add(this.tLPEntry);
            this.Controls.Add(this.tLPCounter);
            this.MaximumSize = new System.Drawing.Size(443, 328);
            this.MinimumSize = new System.Drawing.Size(443, 328);
            this.Name = "MainWindow";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tLPCounter.ResumeLayout(false);
            this.tLPCounter.PerformLayout();
            this.tLPEntry.ResumeLayout(false);
            this.tLPEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPCounter;
        private System.Windows.Forms.TextBox tBCounter;
        private System.Windows.Forms.Button bStart;
        private System.ComponentModel.BackgroundWorker bWCounter;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.TableLayoutPanel tLPEntry;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lTags;
        private System.Windows.Forms.TextBox tBTags;
        private System.Windows.Forms.Button bLogs;
    }
}

