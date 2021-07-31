using System;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SilentDevNull.Utilities.Mail
{
    public class SendEmail
    {
        private String _to { get; set; }
        private String _from { get; set; }
        private String _fromDisplayName { get; set; }
        private String _subject { get; set; }
        private String _messageBody { get; set; }
        private String _smtpServer { get; set; }
        private int _smtpPort { get; set; } = 25;
        private String _username { get; set; }
        private String _password { get; set; }
        private Boolean _useDefaultCredentials { get; set; } = true;
        private Boolean _useAnonymousAuthentication { get; set; } = true;
        private Boolean _isBodyHtml { get; set; } = false;
        private Boolean _enableSSL { get; set; } = false;

        public String To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }
        public String From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
            }
        }
        public String FromDisplayName
        {
            get
            {
                return _fromDisplayName;
            }
            set
            {
                _fromDisplayName = value;
            }
        }

        public String Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }

        public String MessageBody
        {
            get
            {
                return _messageBody;
            }
            set
            {
                _messageBody = value;
            }
        }

        public String STMPServer
        {
            get
            {
                return _smtpServer;
            }
            set
            {
                _smtpServer = value;
            }
        }
        public int STMPPort
        {
            get
            {
                return _smtpPort;
            }
            set
            {
                _smtpPort = value;
            }
        }
        private String Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private String Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public SendEmail()
        {
            if(File.Exists("mailconfig.json"))
            {
            }
        }

        public void SendMessage()
        {
            using (var smtpClient = new SmtpClient(_smtpServer, _smtpPort))
            {
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = _useDefaultCredentials;
                smtpClient.EnableSsl = _enableSSL;
                MailMessage mailMessage = new MailMessage();
                mailMessage.IsBodyHtml = _isBodyHtml;
                mailMessage.From = new MailAddress(_from, _fromDisplayName);
                mailMessage.To.Add(_to);
                mailMessage.Subject = _subject;
                mailMessage.Body = _messageBody;
                mailMessage.BodyEncoding = Encoding.UTF8;
                smtpClient.Send(mailMessage);
            }
        }
    }
}