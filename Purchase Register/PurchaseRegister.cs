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
    public partial class frmPurchaseRegister : Form
    {
        public frmPurchaseRegister()
        {
            InitializeComponent();
        }
        public int ID;
        public UInt64 _id;
        public bool update=false;
        private void PurchaseRegister_Load(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCursor<Entries> put = db.GetCollection<Entries>("Entries").Find(Query.EQ("_id",_id));
            if (update)
            {
                foreach(Entries i in put)
                {
                    date.Text = i.date;
                    MongoCursor<DistributorDetails> dis = db.GetCollection<DistributorDetails>("DistributorDetails").Find(Query.EQ("ID",i.ID));
                    foreach(DistributorDetails j in dis)
                    {
                        cmbDistributorName.Text = j.distributorName;
                        lblTIN.Text = j.TIN;
                        break;
                    }
                    txtGrossPurchase5.Text = i.grossPurchase5.ToString();
                    txtVat5.Text = i.vat5.ToString();
                    txtGrossPurchase125.Text = i.grossPurchase125.ToString();
                    txtVat125.Text = i.vat125.ToString();
                    txtGrossPurchase0.Text = i.grossPurchase0.ToString();
                    txtTotalPurchase.Text = i.total.ToString();
                    break;
                }
                btnAdd.Text = "Update";
            }
            else
            {
                clear();
                MongoCursor<DistributorDetails> dis = db.GetCollection<DistributorDetails>("DistributorDetails").FindAll();
                foreach (DistributorDetails i in dis)
                {
                    if (!cmbDistributorName.Items.Contains(i.distributorName))
                        cmbDistributorName.Items.Add(i.distributorName);
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbDistributorName.Text.Trim() == "")
            {
                MessageBox.Show("Enter Distributor");
                cmbDistributorName.Focus();
                return;
            }
            else
            {
                if (txtGrossPurchase5.Text != "0.00" && txtGrossPurchase125.Text != "0.00")
                {
                    txtVat5.Text = Math.Round((Convert.ToDouble(txtGrossPurchase5.Text) * 0.05), 2).ToString();
                    txtVat125.Text = Math.Round((Convert.ToDouble(txtGrossPurchase125.Text) * 0.125), 2).ToString();
                    txtTotalPurchase.Text = Math.Round((Convert.ToDouble(txtGrossPurchase5.Text) + Convert.ToDouble(txtVat5.Text) + Convert.ToDouble(txtGrossPurchase125.Text) + Convert.ToDouble(txtVat125.Text) + Convert.ToDouble(txtGrossPurchase0.Text)), 2).ToString();
                }

                else if (txtVat5.Text.Trim() != "0.00" || txtVat125.Text.Trim() != "0.00")
                {
                    if (txtVat5.Text.Trim() != "0.00")
                    {
                        txtGrossPurchase5.Text = Math.Round((Convert.ToDouble(txtVat5.Text.Trim()) / 0.05), 2).ToString();
                        txtTotalPurchase.Text = Math.Round((Convert.ToDouble(txtGrossPurchase5.Text) + Convert.ToDouble(txtVat5.Text) + Convert.ToDouble(txtGrossPurchase125.Text) + Convert.ToDouble(txtVat125.Text) + Convert.ToDouble(txtGrossPurchase0.Text)), 2).ToString();
                    }
                    if (txtVat125.Text.Trim() != "0.00")
                    {
                        txtGrossPurchase125.Text = Math.Round((Convert.ToDouble(txtVat125.Text.Trim()) / 0.125), 2).ToString();
                        txtTotalPurchase.Text = Math.Round((Convert.ToDouble(txtGrossPurchase5.Text) + Convert.ToDouble(txtVat5.Text) + Convert.ToDouble(txtGrossPurchase125.Text) + Convert.ToDouble(txtVat125.Text) + Convert.ToDouble(txtGrossPurchase0.Text)), 2).ToString();
                    }
                }
                else if (txtTotalPurchase.Text.Trim() != "0.00")
                {
                    if (rdCal5.Checked == true)
                    {
                        txtGrossPurchase5.Text = Math.Round((Convert.ToDouble(txtTotalPurchase.Text.Trim()) / 1.05), 2).ToString();
                        txtVat5.Text = Math.Round((Convert.ToDouble(txtGrossPurchase5.Text) * 0.05), 2).ToString();
                    }
                    else
                    {
                        txtGrossPurchase125.Text = Math.Round((Convert.ToDouble(txtTotalPurchase.Text.Trim()) / 1.125), 2).ToString();
                        txtVat125.Text = Math.Round((Convert.ToDouble(txtGrossPurchase125.Text) * 0.125), 2).ToString();
                    }
                }
                else
                    MessageBox.Show("Error");
            }
        }
        private void clear()
        {
            lblTIN.Text = "";
            txtGrossPurchase5.Text = "0.00";
            txtGrossPurchase125.Text = "0.00";
            txtVat5.Text = "0.00";
            txtVat125.Text = "0.00";
            txtTotalPurchase.Text = "0.00";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmbDistributorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCursor<DistributorDetails> put = db.GetCollection<DistributorDetails>("DistributorDetails").FindAll();
            foreach (DistributorDetails i in put)
            {
                if (i.distributorName == cmbDistributorName.Text.Trim())
                {
                    ID = i.ID;
                    lblTIN.Text = i.TIN;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            if (update)
            {
                MongoCollection<Entries> entries = db.GetCollection<Entries>("Entries");
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("date", date.Text));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("ID", ID));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("grossPurchase5", Convert.ToInt32(txtGrossPurchase5.Text.Trim())));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("vat5", Convert.ToInt32(txtVat5.Text.Trim())));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("grossPurchase125", Convert.ToInt32(txtGrossPurchase125.Text.Trim())));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("vat5", Convert.ToInt32(txtVat125.Text.Trim())));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("grossPurchase0", Convert.ToInt32(txtGrossPurchase0.Text.Trim())));
                entries.Update(Query.EQ("_id", _id), MongoDB.Driver.Builders.Update.Set("total", Convert.ToInt32(txtTotalPurchase.Text.Trim())));
                MessageBox.Show("Entry Updated");
            }
            else
            {
                MongoCollection<BsonDocument> entries = db.GetCollection<BsonDocument>("Entries");
                BsonDocument entry = new BsonDocument
                {
                    {"date",date.Text},
                    {"ID",ID },
                    {"grossPurchase5",Convert.ToInt32(txtGrossPurchase5.Text.Trim()) },
                    {"vat5",Convert.ToInt32(txtVat5.Text.Trim()) },
                    {"grossPurchase125",Convert.ToInt32(txtGrossPurchase5.Text.Trim()) },
                    {"vat125",Convert.ToInt32(txtVat5.Text.Trim()) },
                    {"grossPurchase0",Convert.ToInt32(txtGrossPurchase5.Text.Trim()) },
                    {"total",Convert.ToInt32(txtTotalPurchase.Text.Trim()) }
                };
                entries.Insert(entry);
                MessageBox.Show("Entry Added");
            }     
        }
    }
}
