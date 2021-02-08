using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Models
{
    class UserProfile_Model
    {
        public int id { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public int roleUser { set; get; }
        public int stateUser { set; get; }
        public DateTime dateValidate { set; get; }
        public int user { set; get; }
        public DateTime date { set; get; }
        public string uuid { set; get; }
        public int state { set; get; }

    }
}
