using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop.ClassFiles
{
    internal class CommandlineInstaller : MSSQLInstalling
    {
        public int Install32(string saPassword, string instanceName)
        {
            string MSSQL_INSTALLER_APP = Application.StartupPath + "\\SQLEXPR32_x86_ENU.exe";
            string configFileName = Directory.GetCurrentDirectory() + "\\MSSQLInstallationConfig.ini";
            base.CreateMsSQLConfigurationFile32Single(configFileName, instanceName);
            return StartInstallation(MSSQL_INSTALLER_APP, saPassword, configFileName);
        }

        public int Install32Multi(string saPassword, string instanceName)
        {
            string MSSQL_INSTALLER_APP = Application.StartupPath + "\\SQLEXPR32_x86_ENU.exe";
            string configFileName = Directory.GetCurrentDirectory() + "\\MSSQLInstallationConfig.ini";
            base.CreateMsSQLConfigurationFile32Multi(configFileName, instanceName);
            return StartInstallation(MSSQL_INSTALLER_APP, saPassword, configFileName);
        }

        public int Install64(string saPassword, string instanceName)
        {
            string MSSQL_INSTALLER_APP = Application.StartupPath + "\\SQLEXPR_x64_ENU.exe";
            string configFileName = Directory.GetCurrentDirectory() + "\\MSSQLInstallationConfig.ini";
            base.CreateMsSQLConfigurationFile64Single(configFileName, instanceName);
            return StartInstallation(MSSQL_INSTALLER_APP, saPassword, configFileName);
        }

        public int Install64Multi(string saPassword, string instanceName)
        {
            string MSSQL_INSTALLER_APP = Application.StartupPath + "\\SQLEXPR_x64_ENU.exe";
            string configFileName = Directory.GetCurrentDirectory() + "\\MSSQLInstallationConfig.ini";
            base.CreateMsSQLConfigurationFile64Multi(configFileName, instanceName);
            return StartInstallation(MSSQL_INSTALLER_APP, saPassword, configFileName);
        }

        private int StartInstallation(string installerApplication, string saPassword, string configFileName)
        {
            int exitCode = 0;
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo(installerApplication);
                    process.StartInfo.Arguments = "/Q /HIDECONSOLE=\"True\" /SAPWD=\"" + saPassword + "\" /CONFIGURATIONFILE=\"" + configFileName + "\"";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();
                    exitCode = process.ExitCode;
                    process.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return exitCode;
        }
    }
}
