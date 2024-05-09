using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace bakery_form1
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

            if (ProductNameTbl.Text == "" || priceTbl.Text == "" || QuantityTbl.Text == "" || comTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information!!!");
            }
            else
            {
                string strconnection = "data source=DESKTOP-KV08PKK; initial catalog=Bakery; integrated security=true";

                conn = new SqlConnection(strconnection);
                conn.Open();
            }
                 try
{
                    
SqlCommand cmd = new SqlCommand("Insert into productTb1 producttbl(productName,productCat,productpric,prodQty) values(@PN,@PC,@PP,@PQ)", conn);
                    cmd.Parameters.AddWithValue("@PN", ProductNameTbl.Text);
                    cmd.Parameters.AddWithValue("@PC", comTb.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@PP", priceTbl.Text);
                    cmd.Parameters.AddWithValue("@PQ", QuantityTbl.Text);
                    cmd.ExecuteNonQuery();
                    }
                    catch(Exception EX) 


                    {

                        MessageBox.Show(EX.Message);

                    }

                    da = new SqlDataAdapter("select * from productTbl", conn);

                SqlCommandBuilder x = new SqlCommandBuilder(da);
                da.Fill(ds,"productTbl");

                productDVG.DataSource = ds.Tables["productTbl"];

            }
    
            

        private void label7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void ProductNameTbl_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
