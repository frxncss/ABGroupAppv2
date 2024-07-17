using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Models
{
    public class MailCompDTO
    {
        public List<string> ToEmails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string? SenderEmail { get; set; }
    }
}
