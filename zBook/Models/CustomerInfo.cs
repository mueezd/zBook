using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zBook.Models
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string CompanyName { get; set; }
        public string emailId { get; set; }
        public string phoneNo { get; set; }
    }
}
