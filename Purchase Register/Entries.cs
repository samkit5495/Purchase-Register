using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace Purchase_Register
{
    class Entries
    {
        public ObjectId _id { get; set; }
        public string date { get; set; }
        public int ID { get; set; }
        public int grossPurchase5 { get; set; }
        public int vat5 { get; set; }
        public int grossPurchase125 { get; set; }
        public int vat125 { get; set; }
        public int grossPurchase0 { get; set; }
        public int total { get; set; }
    }
}
