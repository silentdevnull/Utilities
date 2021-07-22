using System;
using System.Net.Mail;

namespace SilentDevNull.Utilities.Mail
{
    public class SendEmail
    {
        private String _to { get; set; }
        private String _from { get; set; }
        private String _fromDisplayName { get; set; }
        private String _subject { get; set; }
        private String _smtpServer { get; set; }
        private String _username { get; set; }
        private String _password { get; set; }

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

        public String Username
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

        public String Password
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
        }
    }
}