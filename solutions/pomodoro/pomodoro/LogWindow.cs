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
        public DataManager dataManager;

        private bool dataFieldsAreSaved;
        private string oldEntryDescription;
        private string oldTags;

        public LogWindow(DataManager dataManager)
        {
            InitializeComponent();

            this.dataManager = dataManager;
            this.dataFieldsAreSaved = false;
        }

        private void LogWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pomodoroDataSet.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.pomodoroDataSet.Entry);

        }

        private void entryIDTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFieldsAreSaved = false;

            List<string> tags = dataManager.getTagsByEntry(entryIDTextBox.Text);

            string tagsString = "";

            foreach (var item in tags)
            {
                tagsString = tagsString + item + ", ";
            }

            if (tagsString.Length > 0)
            {
                tBTags.Text = tagsString.Remove(tagsString.Length - 2);
            }
            else
            {
                tBTags.Text = tagsString;
            }
        }

        private void saveDataFields(object sender)
        {
            if (!dataFieldsAreSaved)
            {
                oldEntryDescription = descriptionTextBox.Text;
                oldTags = tBTags.Text;

                //Console.WriteLine((sender as TextBox).Name);
                dataFieldsAreSaved = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string newEntryDescription = descriptionTextBox.Text;
            string newTagsAsString = tBTags.Text;

            Console.WriteLine("Old: {0} - {1}, New: {2}, {3}", oldEntryDescription, oldTags, newEntryDescription, newTagsAsString);

            dataManager.OptimisticUpdate(entryIDTextBox.Text, oldEntryDescription, oldTags, newEntryDescription, newTagsAsString);

            dataManager.UpdateTags(entryIDTextBox.Text, oldTags, newTagsAsString);

            dataFieldsAreSaved = false;
            this.entryTableAdapter.Fill(this.pomodoroDataSet.Entry);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            long entryID = long.Parse(entryIDTextBox.Text);
            dataManager.deleteEntryByID(entryID);
            dataManager.deleteTagsByEntryID(entryID);

            this.entryTableAdapter.Fill(this.pomodoroDataSet.Entry);
        }

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            saveDataFields(sender);
        }

        private void tBTags_Enter(object sender, EventArgs e)
        {
            saveDataFields(sender);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            List<List<string>> table = new List<List<string>>();

            foreach (var row in entryDataGridView.Rows)
            {
                string id = Convert.ToString((row as DataGridViewRow).Cells[0].Value);
                string timestamp = (row as DataGridViewRow).Cells[1].Value as string;
                string description = (row as DataGridViewRow).Cells[2].Value as string;

                List<string> rowAsStringList = new List<string>();
                
                rowAsStringList.Add(id);
                rowAsStringList.Add(timestamp);
                rowAsStringList.Add(description);

                List<string> tags = dataManager.getTagsByEntry(id);

                rowAsStringList.Add(String.Join(",", tags));

                Console.WriteLine("rowAsStringList: {0}", rowAsStringList.Count);

                table.Add(rowAsStringList);
            }

            ExportToXLS(table);
        }

        private void ExportToXLS(List<List<string>> table)
        {
            object missing = Type.Missing;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[1, 1]).Value = "Entry ID";
            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[1, 2]).Value = "Timestamp";
            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[1, 3]).Value = "Description";
            ((Microsoft.Office.Interop.Excel.Range)excel.Cells[1, 4]).Value = "Tags";

            int index = 1;
            foreach (var row in table)
            {
                ((Microsoft.Office.Interop.Excel.Range)excel.Cells[index, 1]).Value = row[0] as string;
                ((Microsoft.Office.Interop.Excel.Range)excel.Cells[index, 2]).Value = row[1] as string;
                ((Microsoft.Office.Interop.Excel.Range)excel.Cells[index, 3]).Value = row[2] as string;
                ((Microsoft.Office.Interop.Excel.Range)excel.Cells[index, 4]).Value = row[3] as string;

                index++;
            }

            wb.SaveAs(@"c:\Users\reedcourty\export.xlsx", missing, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missing, missing, missing, missing);
            excel.Quit();
        }
    }
}
