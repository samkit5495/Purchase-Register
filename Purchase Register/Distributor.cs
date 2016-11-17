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
    public partial class frmDistributor: Form
    {
        public frmDistributor()
        {
            InitializeComponent();
        }

        void refresh()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("dbpurchaseregister");
            MongoCursor<DistributorDetails> put = db.GetCollection<DistributorDetails>("DistributorDetails").FindAll();
            lblID.Text = Convert.ToString(put.Count()+1);
            dgvDistributor.RowCount = 1;
            foreach (DistributorDetails i in put)
                dgvDistributor.Rows.Add(i.ID,i.distributorName, i.TIN);
        }

        private bool validateForm()
        {
            if(string.IsNullOrWhiteSpace(txtDistributorName.Text))
            {
                MessageBox.Show("Enter Distributor Name!!!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTIN.Text))
            {
                MessageBox.Show("Enter TIN No!!!");
                return false;
            }
            if (txtTIN.Text.Length!=12||txtTIN.Text[txtTIN.Text.Length-1]!='V')
            {
                MessageBox.Show("Enter Valid TIN No!!!");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(validateForm())
            { 
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dbpurchaseregister");
                MongoCollection<BsonDocument> Distributors = db.GetCollection<BsonDocument>("DistributorDetails");
                BsonDocument distributor = new BsonDocument
                {
                    {"ID",Convert.ToInt32(lblID.Text.Trim()) },
                    {"distributorName",txtDistributorName.Text.Trim()},
                    {"TIN",txtTIN.Text.Trim()}
                };
                Distributors.Insert(distributor);
                MessageBox.Show("Distributor Added Successfully");
                txtDistributorName.Text = "";
                txtTIN.Text = "";
                refresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dbpurchaseregister");
                MongoCollection<DistributorDetails> Distributors = db.GetCollection<DistributorDetails>("DistributorDetails");
                if (Convert.ToInt32(lblID.Text) > Distributors.Count())
                {
                    Distributors.Update(Query.EQ("ID", Convert.ToInt32(lblID.Text.Trim())), MongoDB.Driver.Builders.Update.Set("distributorName", txtDistributorName.Text.Trim()));
                    Distributors.Update(Query.EQ("ID", Convert.ToInt32(lblID.Text.Trim())), MongoDB.Driver.Builders.Update.Set("TIN", txtTIN.Text.Trim()));
                    MessageBox.Show("Distributor Updated");
                    refresh();
                }
                else
                    MessageBox.Show("Duplicate Entry!!!");
            }
        }

        private void dgvDistributor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text= dgvDistributor.SelectedCells[0].Value.ToString();
            txtDistributorName.Text = dgvDistributor.SelectedCells[1].Value.ToString();
            txtTIN.Text = dgvDistributor.SelectedCells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                MongoClient client = new MongoClient("mongodb://localhost");
                MongoServer server = client.GetServer();
                MongoDatabase db = server.GetDatabase("dbpurchaseregister");
                MongoCollection<DistributorDetails> Distributors = db.GetCollection<DistributorDetails>("DistributorDetails");
                if (Convert.ToInt32(lblID.Text) <= Distributors.Count())
                {
                    Distributors.Remove(Query.EQ("TIN", txtTIN.Text.Trim()));
                    MessageBox.Show("Distributor successfully deleted!");
                    refresh();
                }
                else
                    MessageBox.Show("Entry Not Found!!!");
            }
        }

        private void frmDistributor_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
