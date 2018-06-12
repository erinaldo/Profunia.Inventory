using Profunia.Inventory.Desktop.ClassFiles.Info;
using Profunia.Inventory.Desktop.ClassFiles.SP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    public partial class frmErrorReporter : Form
    {
        private Thread oThread;
        public frmErrorReporter(string infoError)
        {
            try
            {
                InitializeComponent();
                txtError.Text = infoError;
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "err-R1" + ex.Message;
            }
        }
        private void threadStart()
        {
            //try
            //{
            //    CompanySP spCompany = new CompanySP();
            //    CompanyInfo infoCompany = new CompanyInfo();
            //    try
            //    {
            //        infoCompany = spCompany.CompanyView(1m);
            //    }
            //    catch (Exception)
            //    {
            //    }
            //    MailMessage mailMsg = new MailMessage();
            //    mailMsg.From = "openmiracleuserfeedback@gmail.com";
            //    mailMsg.To = "openmiraclefeedback@gmail.com";
            //    mailMsg.Subject = "Openmiracle MsSql Error! Version : " + Application.ProductVersion;
            //    mailMsg.BodyFormat = MailFormat.Text;
            //    mailMsg.Body = infoCompany.EmailId + " - " + txtError.Text;
            //    mailMsg.Priority = MailPriority.High;
            //    SmtpMail.SmtpServer = "smtp.gmail.com";
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "openmiracleuserfeedback@gmail.com");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "openmiraclecop");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
            //    mailMsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
            //    SmtpMail.Send(mailMsg);
            //    Cursor.Current = Cursors.Default;
            //    base.Invoke((MethodInvoker)delegate
            //    {
            //        base.Close();
            //    });
            //}
            //catch
            //{
            //}
        }

        private void btnSendError_Click(object sender, EventArgs e)
        {
            try
            {
                base.Hide();
                oThread = new Thread(threadStart);
                oThread.Start();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "err-R2" + ex.Message;
            }
        }

        private void btnSendErrorReport_Click(object sender, EventArgs e)
        {
            try
            {
                base.Close();
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "err-R3" + ex.Message;
            }
        }

        private void frmErrorReporter_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (oThread != null && oThread.IsAlive)
                {
                    oThread.Abort();
                }
            }
            catch (Exception ex)
            {
                formMDI.infoError.ErrorString = "err-R4" + ex.Message;
            }
        }

    }
}
