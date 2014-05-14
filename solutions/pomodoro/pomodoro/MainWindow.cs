using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class MainWindow : Form
    {

        // TODO: Form validálás: 
        // http://msdn.microsoft.com/en-us/library/bbabas53(v=vs.110).aspx
        // http://msdn.microsoft.com/en-us/library/kkx4h3az(v=vs.110).aspx
        // http://msdn.microsoft.com/en-us/library/8aye673k(v=vs.110).aspx

        public DataManager dataManager;

        private DateTime startCounterAt;

        public DateTime StartCounterAt
        {
            get { return startCounterAt; }
            set { startCounterAt = value; }
        }

        private DateTime stopCounterAt;

        public DateTime StopCounterAt
        {
            get { return stopCounterAt; }
            set { stopCounterAt = value; }
        }

        public delegate void Updater(string newValue);
        public Updater myUpdater;

        public MainWindow(DataManager dataManager)
        {
            InitializeComponent();
            myUpdater = new Updater(Update_maskedTextBoxCounter_Text);

            this.dataManager = dataManager;
        }

        private void DisableEntryEditor()
        {
            tBDescription.Enabled = false;
            tBTags.Enabled = false;
            bSave.Enabled = false;
        }

        private void EnableEntryEditor()
        {
            tBDescription.Enabled = true;
            tBTags.Enabled = true;
            bSave.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            maskedTextBoxCounter.Text = "25:00";
            DisableEntryEditor();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            this.StartCounterAt = DateTime.Now;

            DateTime parsedTime = DateTime.ParseExact("25:00", "mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            string timeStringFromCounter = maskedTextBoxCounter.Text;
            try
            {
                parsedTime = DateTime.ParseExact(timeStringFromCounter, "mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (System.FormatException)
            {
                maskedTextBoxCounter.Text = "25:00";
            }

            TimeSpan time = new TimeSpan(0, 0, 0, parsedTime.Minute * 60 + parsedTime.Second);

            this.StopCounterAt = StartCounterAt.Add(time);

            this.bStart.Enabled = false;

            tBDescription.Text = "What have you done?";

            EnableEntryEditor();

            bWCounter.RunWorkerAsync();

        }

        private void bWCounter_DoWork(object sender, DoWorkEventArgs e)
        {

            bool running = true;
            while (running)
            {

                Thread.Sleep(10);

                if (this.StopCounterAt >= DateTime.Now)
                {
                    this.Invoke(myUpdater, new string[] { new DateTime((this.StopCounterAt - DateTime.Now).Ticks).ToString("mm:ss") });
                }
                else
                {
                    running = false;
                }

            }

        }

        private void Update_maskedTextBoxCounter_Text(string newValue)
        {
            maskedTextBoxCounter.Text = newValue;
        }

        private void bWCounter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.bStart.Enabled = true;
            MessageBox.Show("Game over!");
            this.maskedTextBoxCounter.Text = "25:00";
        }

        private void bLogs_Click(object sender, EventArgs e)
        {
            var logWindow = new LogWindow(dataManager);
            logWindow.Show();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            addNewEntry(startCounterAt, this.tBDescription.Text, this.tBTags.Text);
        }

        private void addNewEntry(DateTime timestamp, string description, string tagsString)
        {
            tagsString = tagsString.Replace(" ", string.Empty);
            HashSet<string> tags = new HashSet<string>(tagsString.Split(new Char[] { ',' }));
            HashSet<string> tagsInDB = dataManager.getTagsAsArray();

            foreach (var item in tags)
            {
                if (!tagsInDB.Contains(item)) {
                    dataManager.addNewTag(item);
                }
            }

            long newEntryID = dataManager.addNewEntry(timestamp, description);

            dataManager.addTagsToEntry(newEntryID, tags);
        }

        private void tBTags_Validating(object sender, CancelEventArgs e)
        {
            string input = (sender as TextBox).Text;

            //Regex r = new Regex("[^A-Z0-9.$ ]$");
            Regex r = new Regex("[^A-Za-z0-9., ]");
            if (r.IsMatch(input))
            {
                bSave.Enabled = false;
                (sender as TextBox).BackColor = Color.Salmon;
            }
            else
            {
                bSave.Enabled = true;
                (sender as TextBox).BackColor = Color.White;
            }
        }

    }
}
