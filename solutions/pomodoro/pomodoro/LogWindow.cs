using System;
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
    public partial class LogWindow : Form
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        private void entryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pomodoroDataSet);

        }

        private void LogWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pomodoroDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.pomodoroDataSet.Entry);

        }
    }
}
