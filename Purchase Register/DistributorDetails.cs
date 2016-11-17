using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Purchase_Register
{
    class DistributorDetails
    {
        public ObjectId _id { get; set; }
        public int ID { get; set; }
        public string distributorName { get; set; }
        public string TIN { get; set; }
    }
}
