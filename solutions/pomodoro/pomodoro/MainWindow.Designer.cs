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
            this.bStart = new System.Windows.Forms.Button();
            this.tBCounter = new System.Windows.Forms.TextBox();
            this.bWCounter = new System.ComponentModel.BackgroundWorker();
            this.tLPCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPCounter
            // 
            this.tLPCounter.ColumnCount = 3;
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLPCounter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLPCounter.Controls.Add(this.tBCounter, 0, 0);
            this.tLPCounter.Controls.Add(this.bStart, 1, 2);
            this.tLPCounter.Location = new System.Drawing.Point(12, 72);
            this.tLPCounter.Name = "tLPCounter";
            this.tLPCounter.RowCount = 3;
            this.tLPCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPCounter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPCounter.Size = new System.Drawing.Size(260, 128);
            this.tLPCounter.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bStart.Location = new System.Drawing.Point(89, 77);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(80, 48);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
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
            this.tBCounter.Size = new System.Drawing.Size(254, 50);
            this.tBCounter.TabIndex = 1;
            this.tBCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bWCounter
            // 
            this.bWCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWCounter_DoWork);
            this.bWCounter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWCounter_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tLPCounter);
            this.Name = "MainWindow";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tLPCounter.ResumeLayout(false);
            this.tLPCounter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPCounter;
        private System.Windows.Forms.TextBox tBCounter;
        private System.Windows.Forms.Button bStart;
        private System.ComponentModel.BackgroundWorker bWCounter;
    }
}

