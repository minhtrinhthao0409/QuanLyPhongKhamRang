using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    class Logging
    {
        public string LoggingID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }

        public string Content { get; set; }
        public string DateTime { get; set; }

        public Logging() { } // Constructor mặc định cần có


        public Logging(string LoggingID, string UserID, string UserName, string Content, string DateTime)
        {
            this.LoggingID = LoggingID;
            this.UserID = UserID;
            this.UserName = UserName;
            this.Content = Content;
            this.DateTime = DateTime;
        }
    }
}
