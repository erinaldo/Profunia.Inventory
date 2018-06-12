using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace Profunia.Inventory.Desktop.ClassFiles
{
    internal class SClass
    {
        public bool CheckFilesExists(string FileNameWithFullPath)
        {
            if (File.Exists(FileNameWithFullPath))
            {
                return true;
            }
            return false;
        }

        internal bool CheckMsSqlConnection(string serverName, string userId, string password, string ApplicationPath)
        {
            bool isTrue = false;
            if (serverName != null)
            {
                SqlConnection sqlcon = (userId != null && password != null) ? new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + ApplicationPath + "\\Data\\DBOpenmiracle.mdf;user id='" + userId + "';password='" + password + "'; Connect Timeout=30; User Instance=False") : new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + ApplicationPath + "\\Data\\DBOpenmiracle.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                try
                {
                    sqlcon.Open();
                    isTrue = true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 18493)
                    {
                        sqlcon = ((userId != null && password != null) ? new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + ApplicationPath + "\\Data\\DBOpenmiracle.mdf;user id='" + userId + "';password='" + password + "'; Connect Timeout=30") : new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + ApplicationPath + "\\Data\\DBOpenmiracle.mdf;Integrated Security=True;Connect Timeout=30"));
                        try
                        {
                            sqlcon.Open();
                            UpdateAppConfig("isServerConnection", "true");
                            isTrue = true;
                        }
                        catch (SqlException exa)
                        {
                            MessageBox.Show(exa.Message);
                            isTrue = false;
                        }
                        finally
                        {
                            if (sqlcon.State == ConnectionState.Open)
                            {
                                sqlcon.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        isTrue = false;
                    }
                }
                finally
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqlcon.Close();
                    }
                }
            }
            return isTrue;
        }

        public DataTable GetLocalInstance()
        {
            DataTable LocalInstanceNames = new DataTable();
            LocalInstanceNames.Columns.Add("Server", typeof(string));
            LocalInstanceNames.Columns.Add("Instance", typeof(string));
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL", false);
                if (instanceKey != null)
                {
                    string[] valueNames = instanceKey.GetValueNames();
                    foreach (string instanceName in valueNames)
                    {
                        LocalInstanceNames.Rows.Add(Environment.MachineName, instanceName);
                    }
                }
                else
                {
                    LocalInstanceNames.Rows.Add(Environment.MachineName, "");
                }
            }
            return LocalInstanceNames;
        }

        public void UpdateAppConfig(string key, string value)
        {
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch
            {
            }
        }

        internal DataTable GetOmPath(string serverName, string userId, string password)
        {
            DataTable dtbl3;
            if (serverName != null)
            {
                SqlConnection sqlcon = (userId != null && password != null) ? new SqlConnection("Data Source=" + serverName + ";user id='" + userId + "';password='" + password + "'; Connect Timeout=30; User Instance=False") : new SqlConnection("Data Source=" + serverName + ";Integrated Security=True;Connect Timeout=30;User Instance=True");
                try
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT name, cast(replace(physical_name, '\\Data\\DBOpenMiracle.mdf', '') as varchar(max)) AS [location] FROM sys.master_files WHERE physical_name like '%'+'\\Data\\DBOpenMiracle.mdf'", sqlcon);
                    sqlDa2.Fill(dtbl3 = new DataTable());
                    if (dtbl3.Rows.Count == 0 && serverName.Split('\\')[0].ToString() == Environment.MachineName)
                    {
                        dtbl3.Rows.Add("MyPath", Application.StartupPath);
                    }
                    return dtbl3;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 18493)
                    {
                        sqlcon = ((userId != null && password != null) ? new SqlConnection("Data Source=" + serverName + ";user id='" + userId + "';password='" + password + "'; Connect Timeout=30") : new SqlConnection("Data Source=" + serverName + ";Integrated Security=True;Connect Timeout=30"));
                        try
                        {
                            sqlcon.Open();
                            SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT name, cast(replace(physical_name, '\\Data\\DBOpenMiracle.mdf', '') as varchar(max)) AS [location] FROM sys.master_files WHERE physical_name like '%'+'\\Data\\DBOpenMiracle.mdf'", sqlcon);
                            sqlDa2.Fill(dtbl3 = new DataTable());
                            if (dtbl3.Rows.Count == 0 && serverName.Split('\\')[0].ToString() == Environment.MachineName)
                            {
                                dtbl3.Rows.Add("MyPath", Application.StartupPath);
                            }
                            return dtbl3;
                        }
                        catch (SqlException exa)
                        {
                            MessageBox.Show(exa.Message);
                        }
                        finally
                        {
                            if (sqlcon.State == ConnectionState.Open)
                            {
                                sqlcon.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqlcon.Close();
                    }
                }
            }
            return dtbl3 = new DataTable();
        }
    }
}