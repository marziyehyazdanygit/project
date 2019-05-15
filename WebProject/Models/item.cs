using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class item
    {
        public int id { get; set; }
        public int repository_code { get; set; }
        public int item_category_id { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public string buy_price { get; set; }
        public string sell_price { get; set; }
        public string buy_date { get; set; }
        public string description { get; set; }
    }
}