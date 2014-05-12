using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public MainWindow()
        {
            InitializeComponent();
            myUpdater = new Updater(Update_tBCounter_Text);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tBCounter.Text = "25:00";
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            this.StartCounterAt = DateTime.Now;

            DateTime parsedTime = DateTime.ParseExact("25:00", "mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            string timeStringFromCounter = tBCounter.Text;
            try
            {
                parsedTime = DateTime.ParseExact(timeStringFromCounter, "mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (System.FormatException)
            {
                tBCounter.Text = "25:00";
            }

            TimeSpan time = new TimeSpan(0, 0, 0, parsedTime.Minute * 60 + parsedTime.Second);

            this.StopCounterAt = StartCounterAt.Add(time);

            this.bStart.Enabled = false;

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

        private void Update_tBCounter_Text(string newValue)
        {
            tBCounter.Text = newValue;
        }

        private void bWCounter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.bStart.Enabled = true;
            MessageBox.Show("Game over!");
            this.tBCounter.Text = "25:00";
        }

        private void bLogs_Click(object sender, EventArgs e)
        {
            var logWindow = new LogWindow();
            logWindow.Show();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
