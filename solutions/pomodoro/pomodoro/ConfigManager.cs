using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace pomodoro
{
    public class Config
    {
        private string dbFile;
        private int sessionLenghtInMin;

        public int SessionLenghtInMin
        {
            get { return sessionLenghtInMin; }
            set { sessionLenghtInMin = value; }
        }
        

        public string DbFile
        {
            get { return dbFile; }
            set { dbFile = value; }
        }

        public override string ToString()
        {
            return this.dbFile;
        }

    }


    class ConfigManager
    {
        private string configFile;
        public Tracer tracer;

        public string ConfigFile
        {
            get { return configFile; }
            set { configFile = value; }
        }

        private Config configuration;

        public Config Configuration
        {
            get { return configuration; }
            set { configuration = value; }
        }

        public ConfigManager(Tracer tracer)
        {
            this.tracer = tracer;
            Init();
        }

        public void LoadConfig()
        {
            tracer.PutEvent(TraceEventType.Information, 1, "ConfigManager.LoadConfig() has been started");
            Config result = new Config();
            try
            {

                using (FileStream fs = new FileStream(this.ConfigFile, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    result = xs.Deserialize(fs) as Config;
                }
            }
            catch (System.IO.IOException exception)
            {
                Console.WriteLine("{0}, {1}", exception.Source, exception.Message);
            }

            configuration = result;

        }

        public void Init()
        {
            var applicationPath = Environment.CurrentDirectory;
            this.ConfigFile = Path.Combine(applicationPath, "pomodoro.config.xml");

            XmlSerializer xs = new XmlSerializer(typeof(Config));
            var config = new Config { DbFile = Path.Combine(applicationPath, "pomodoro.db") };

            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            var xml = sw.ToString();

            try
            {
                using (FileStream fs = new FileStream(this.ConfigFile, FileMode.CreateNew))
                {
                    xs.Serialize(fs, config);
                }
            }
            catch (System.IO.IOException exception)
            {
                Console.WriteLine("{0}, {1}", exception.Source, exception.Message);
            }

            LoadConfig();
        }
    }
}
