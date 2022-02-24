using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btl_embedded.Models
{
    public class Account : BsonData.Document
    {
        public string AccId { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string Birth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string avt { get; set; }
        public string duty { get; set; }


    }
    public class JsonObj
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
