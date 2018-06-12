using Profunia.Inventory.Desktop.ClassFiles;
using Profunia.Inventory.Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            lblVersion.Text = Application.ProductVersion;
        }

        private bool CheckDataBase()
        {
            bool isTrue = false;
            string serverName = (ConfigurationManager.AppSettings["MsSqlServer"] == null || ConfigurationManager.AppSettings["MsSqlServer"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlServer"].ToString();
            string userId = (ConfigurationManager.AppSettings["MsSqlUserId"] == null || ConfigurationManager.AppSettings["MsSqlUserId"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlUserId"].ToString();
            string password = (ConfigurationManager.AppSettings["MsSqlPassword"] == null || ConfigurationManager.AppSettings["MsSqlPassword"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlPassword"].ToString();
            string ApplicationPath = (ConfigurationManager.AppSettings["ApplicationPath"] == null || ConfigurationManager.AppSettings["ApplicationPath"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["ApplicationPath"].ToString();
            string isSqlServer = (ConfigurationManager.AppSettings["isServerConnection"] == null || ConfigurationManager.AppSettings["isServerConnection"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["isServerConnection"].ToString();
            SClass objDb = new SClass();
            if (objDb.CheckMsSqlConnection(serverName, userId, password, ApplicationPath))
            {
                return true;
            }
            return false;
        }

        public void CheckNewVersionComesOfOpenmiracle()
        {
            DateTime dtLastCheckDate = DateTime.Today;
            int inInterval = 0;
            try
            {
                dtLastCheckDate = DateTime.Parse(ConfigurationManager.AppSettings["LastCheckDay"].ToString());
                inInterval = int.Parse(ConfigurationManager.AppSettings["UpdateCheck"].ToString());
            }
            catch
            {
            }
            if (DateTime.Today >= dtLastCheckDate.AddDays((double)inInterval) && CheckForInternetConnection())
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                    string version = fileVersionInfo.ProductVersion;
                    string result = string.Empty;
                    using (WebClient client = new WebClient())
                    {
                        string htmlCode = client.DownloadString("http://www.openmiracle.com/open_miracle_mysql_version.htm");
                        Regex regex = new Regex("<span id=\"version\" class=\"version\">(.*?)</span>");
                        Match match = regex.Match("?S_" + htmlCode);
                        result = match.Groups[1].Value;
                        Regex msg = new Regex("<span id=\"msg\" class=\"msg\">(.*?)</span>");
                        Match message = msg.Match("?S_" + htmlCode);
                        string messageToShow = message.Groups[1].Value;
                        Regex head = new Regex("<span id=\"heading\" class=\"heading\">(.*?)</span>");
                        Match check = head.Match("?S_" + htmlCode);
                        string heading = check.Groups[1].Value;
                        if (messageToShow.ToString().Trim() != string.Empty)
                        {
                            PublicVariables.MessageToShow = messageToShow.ToString();
                            PublicVariables.MessageHeadear = heading.ToString().Trim();
                        }
                    }
                    if (Test(version, result, -1) == "New")
                    {
                        ntfyVersionUpdate.Visible = true;
                        ntfyVersionUpdate.BalloonTipIcon = ToolTipIcon.Info;
                        ntfyVersionUpdate.BalloonTipText = "New version available";
                        ntfyVersionUpdate.BalloonTipTitle = "Openmiracle";
                        ntfyVersionUpdate.ShowBalloonTip(1000);
                        ntfyVersionUpdate.Text = "Update Openmiracle from " + version + " to " + result;
                    }
                    UpdateSetting("LastCheckDay", DateTime.Today.ToString("dd-MMM-yyyy"));
                }
                catch
                {
                }
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private static string Test(string lhs, string rhs, int expected)
        {
            int result = 0;
            try
            {
                result = CompareVersions(lhs, rhs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result.Equals(expected) ? "New" : "Same";
        }

        private void UpdateSetting(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            {
            }
        }

        public static int CompareVersions(string strA, string strB)
        {
            Version vA = new Version(strA.Replace(",", "."));
            Version vB = new Version(strB.Replace(",", "."));
            return vA.CompareTo(vB);
        }

        private void ntfyVersionUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.openmiracle.com/update.aspx");
                ntfyVersionUpdate.Visible = false;
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            CheckNewVersionComesOfOpenmiracle();
            if (CheckDataBase())
            {
                Environment.ExitCode = 565568;
                base.Close();
            }
            else
            {
                Environment.ExitCode = 565556;
                base.Close();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
