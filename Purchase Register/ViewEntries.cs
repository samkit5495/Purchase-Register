using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Purchase_Register
{
    public partial class frmViewEntries : Form
    {
        public frmViewEntries()
        {
            InitializeComponent();
        }
        public int ID;
        public void refresh()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCursor<DistributorDetails> put = db.GetCollection<DistributorDetails>("DistributorDetails").FindAll();
            foreach (DistributorDetails i in put)
            {
                if (!cmbDistributorName.Items.Contains(i.distributorName))
                    cmbDistributorName.Items.Add(i.distributorName);
            }
        }

        private void frmViewEntries_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void cmbDistributorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCursor<DistributorDetails> put = db.GetCollection<DistributorDetails>("DistributorDetails").Find(Query.EQ("distributorName", cmbDistributorName.Text.Trim()));
            foreach (DistributorDetails i in put)
            {
                ID = i.ID;
                break;
            }
            MongoCursor<Entries> entries = db.GetCollection<Entries>("Entries").Find(Query.EQ("ID", ID));
            foreach (Entries i in entries)
            {
                dgvEntries.Rows.Add(i._id, i.date, cmbDistributorName.Text.Trim(), i.grossPurchase5, i.vat5, i.grossPurchase125, i.vat125, i.grossPurchase0, i.total);
            }
       /*     MongoCollection<Entries> en = db.GetCollection<Entries>("Entries");
            var group = new BsonDocument
                {
                    { "$group",
                        new BsonDocument
                            {
                                { "_id", new BsonDocument
                                             {
                                                 {
                                                     "ID","$ID"
                                                 }
                                             }
                                },
                                {
                                    "totalGrossPurchase5", new BsonDocument
                                                 {
                                                     {
                                                         "$sum", "$totalGrossPurchase5"
                                                     }
                                                 }
                                }
                            }
                  }
                };
            var pipeline = new[] { group };
            var result = en.Aggregate(pipeline);
 */
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbDistributorName.Text.Trim() != "")
            {
                frmPurchaseRegister obj = new frmPurchaseRegister();
                obj._id = Convert.ToUInt64(dgvEntries.SelectedCells[0].Value.ToString());
                obj.update = true;
                obj.Show();
            }
            else
                MessageBox.Show("Duplicate Entry!!!");
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCollection<Entries> entries = db.GetCollection<Entries>("Entries");
            entries.Remove(Query.EQ("_id", Convert.ToUInt64(dgvEntries.SelectedCells[0].Value.ToString())));
            MessageBox.Show("Entry Deleted!");
        }
    }
}
