using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace storedata.Models
{
    public class store
    {
        public int storeid { get; set; }
        public string storename { get; set; }
        public  string storeownername { get; set; }
        public string storelocation { get; set; }
        public Int64 storecontactno { get; set; }
    }
}