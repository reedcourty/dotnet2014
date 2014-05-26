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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tLPCounter = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBoxCounter = new System.Windows.Forms.MaskedTextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bWCounter = new System.ComponentModel.BackgroundWorker();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.tBTags = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lTags = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.tLPEntry = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.bLogs = new System.Windows.Forms.Button();
            this.tLPCounter.SuspendLayout();
            this.tLPEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPCounter
            // 
            resources.ApplyResources(this.tLPCounter, "tLPCounter");
            this.tLPCounter.Controls.Add(this.maskedTextBoxCounter, 0, 0);
            this.tLPCounter.Controls.Add(this.bStart, 4, 0);
            this.tLPCounter.Name = "tLPCounter";
            // 
            // maskedTextBoxCounter
            // 
            resources.ApplyResources(this.maskedTextBoxCounter, "maskedTextBoxCounter");
            this.tLPCounter.SetColumnSpan(this.maskedTextBoxCounter, 3);
            this.maskedTextBoxCounter.Name = "maskedTextBoxCounter";
            // 
            // bStart
            // 
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.Name = "bStart";
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
            this.tLPEntry.SetColumnSpan(this.tBDescription, 3);
            resources.ApplyResources(this.tBDescription, "tBDescription");
            this.tBDescription.Name = "tBDescription";
            // 
            // tBTags
            // 
            resources.ApplyResources(this.tBTags, "tBTags");
            this.tLPEntry.SetColumnSpan(this.tBTags, 2);
            this.tBTags.Name = "tBTags";
            this.tBTags.Validating += new System.ComponentModel.CancelEventHandler(this.tBTags_Validating);
            // 
            // lDescription
            // 
            resources.ApplyResources(this.lDescription, "lDescription");
            this.lDescription.Name = "lDescription";
            // 
            // lTags
            // 
            resources.ApplyResources(this.lTags, "lTags");
            this.lTags.Name = "lTags";
            // 
            // bSave
            // 
            resources.ApplyResources(this.bSave, "bSave");
            this.bSave.Name = "bSave";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tLPEntry
            // 
            resources.ApplyResources(this.tLPEntry, "tLPEntry");
            this.tLPEntry.Controls.Add(this.lDescription, 0, 0);
            this.tLPEntry.Controls.Add(this.bSave, 2, 5);
            this.tLPEntry.Controls.Add(this.tBDescription, 0, 1);
            this.tLPEntry.Controls.Add(this.lTags, 0, 3);
            this.tLPEntry.Controls.Add(this.tBTags, 1, 3);
            this.tLPEntry.Controls.Add(this.buttonSettings, 0, 5);
            this.tLPEntry.Name = "tLPEntry";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::pomodoro.Properties.Resources._16px_Preferences_system_svg;
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // bLogs
            // 
            resources.ApplyResources(this.bLogs, "bLogs");
            this.bLogs.Name = "bLogs";
            this.bLogs.UseVisualStyleBackColor = true;
            this.bLogs.Click += new System.EventHandler(this.bLogs_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bLogs);
            this.Controls.Add(this.tLPEntry);
            this.Controls.Add(this.tLPCounter);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tLPCounter.ResumeLayout(false);
            this.tLPCounter.PerformLayout();
            this.tLPEntry.ResumeLayout(false);
            this.tLPEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPCounter;
        private System.Windows.Forms.Button bStart;
        private System.ComponentModel.BackgroundWorker bWCounter;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.TableLayoutPanel tLPEntry;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lTags;
        private System.Windows.Forms.TextBox tBTags;
        private System.Windows.Forms.Button bLogs;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCounter;
        private System.Windows.Forms.Button buttonSettings;
    }
}

