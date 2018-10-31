using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseConfirmed.Models
{
    public class Cases
    {
        public int IntID { get; set; }
        public string Subject { get; set; }
        public string CaseNo { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

    }
}