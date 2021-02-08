using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    class Order_Model
    {
        public int id { set; get; }
        public string uuid { set; get; }
        public string customerName { set; get; }
        public string customerPhone { set; get; }
        public string address { set; get; }
        public string note { set; get; }
        public int state { set; get; }
        public string order_general_deatils_uuid { set; get; }
        public string useruuid { set; get; }
        public double noItem { set; get; }
        public double amount { set; get; }
        public int user { set; get; }
        public DateTime date { set; get; }

    }
}
