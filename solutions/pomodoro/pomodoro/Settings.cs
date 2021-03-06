﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class Settings : Form
    {
        private ConfigManager configManager;

        public Settings(ConfigManager configManager)
        {
            InitializeComponent();

            comboBoxLanguage.SelectedItem = configManager.Configuration.getLanguage();
            checkBoxXLSX.Checked = configManager.Configuration.ExportToXLSX;
            checkBoxMSSQL.Checked = configManager.Configuration.ExportToMSSQL;             

            this.configManager = configManager;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            configManager.Configuration.setLanguage(comboBoxLanguage.SelectedItem.ToString());
            configManager.Configuration.ExportToMSSQL = checkBoxMSSQL.Checked;
            configManager.Configuration.ExportToXLSX = checkBoxXLSX.Checked;

            configManager.SaveConfig();

            this.DialogResult = DialogResult.OK;

        }
    }
}
