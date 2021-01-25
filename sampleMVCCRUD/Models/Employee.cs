using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleMVCCRUD.Models
{
    public class Employee
    {

        public decimal serialNo { get; set; }
        public string empid { get; set; }
        public string empname { get; set; }
        public string empadd { get; set; }
        public string desgn { get; set; }
        public int salary { get; set; }
    }
}