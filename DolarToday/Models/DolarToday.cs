using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DolarToday.Models
{
    public class DolarTodayResult
    {
        public DolarTodayApiResult result { get; set; }
        public class DolarTodayApiResult
        {
            public decimal value { get; set; }
        }
        public class DolarTodayResponse
        {
            //public DateTime updated { get; set; }
            //public string source { get; set; }
            //public string target { get; set; }
            public string moneda { get; set; }
            public decimal precio { get; set; }
            //public decimal quantity { get; set; }
            //public decimal amount { get; set; }
        }
    }
}