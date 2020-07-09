using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using log4net;

namespace MTZCharacterGen
{
    public partial class MainForm : Form
    {
        private static readonly ILog m_log = LogManager.GetLogger(typeof(MainForm));

        private static DataSet m_settings = new DataSet();
        private static DataSet m_gameData = new DataSet();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"Data\settings.xml"))
            {
                try
                {
                    m_settings.ReadXml(@"Data\settings.xml");
                    m_log.Info("Loaded Data\\settings.xml");
                }
                catch(Exception ex)
                {
                    m_log.Error("Unable to open Data\\settigns.xml file.", ex);
                    Application.Exit();
                }
            }
            else
            {
                DataTable settings = new DataTable("Settings");
                DataColumn col = new DataColumn("Key");
                settings.Columns.Add(col);
                col = new DataColumn("Value");
                settings.Columns.Add(col);
                DataRow row = settings.NewRow();
                row["Key"] = "DataFile";
                row["Value"] = @"Data\gamedata.xml";
                settings.Rows.Add(row);
                m_settings.Tables.Add(settings);
                m_log.Info("Generated default Data\\settings.xml");
                if(!Directory.Exists("Data"))
                {
                    try
                    {
                        Directory.CreateDirectory("Data");
                    }
                    catch(Exception ex)
                    {
                        m_log.Error("Unable to create Data directory.", ex);
                        Application.Exit();
                    }
                }
                try
                {
                    m_settings.WriteXml(@"Data\settings.xml");
                    m_log.Info("Saved Data\\settings.xml");
                }
                catch (Exception ex)
                {
                    m_log.Error("Unable to write generated Data\\settings.xml file.", ex);
                    Application.Exit();
                }
            }
            string datafile = @"Data\gamedata.xml";
            try
            {
                DataRow[] datfilerow = m_settings.Tables["Settings"].Select("Key = 'DataFile'");
                if (datfilerow.Length < 1)
                {
                    m_log.Warn("Unable to retrieve game data filename from settings.  Using default " + datafile);
                }
                else
                {
                    datafile = datfilerow[0]["Value"].ToString();
                }
                try
                {
                    m_gameData.ReadXml(datafile);
                    m_log.Info("Loaded " + datafile);
                }
                catch (Exception ex)
                {
                    m_log.Error("Unable to read data from " + datafile, ex);
                    Application.Exit();
                }
            }
            catch(Exception oex)
            {
                m_log.Error("Error retrieving dame data filename.", oex);
                Application.Exit();
            }
        }
    }
}
