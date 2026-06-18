using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    
        public class IssueReturn
        {
            public int IssueID { get; set; }
            public int BookID { get; set; }
            public int MemberID { get; set; }
            public string BookTitle { get; set; }  
            public string MemberName { get; set; }  
            public DateTime IssueDate { get; set; }
            public DateTime? ReturnDate { get; set; }
        }
    
}
