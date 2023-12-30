using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql;
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void connect_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection();
            sql.ConnectionString =
            ConfigurationManager.ConnectionStrings["m3had"].ConnectionString;

            if (sql.State == ConnectionState.Closed)
                sql.Open();
            using (SqlCommand xactAbortCommand = sql.CreateCommand())
            {
                xactAbortCommand.CommandText = "SET XACT_ABORT ON";
                xactAbortCommand.ExecuteNonQuery();
            }
            MessageBox.Show(sql.State.ToString());
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string name = textBox_productname.Text;
            string price = textBox_price.Text;
            string description = textBox_description.Text;
            string quantity = textBox_quantity.Text;
            string location = textBox_location.Text;


            SqlCommand command = new SqlCommand("AddProduct", sql);

            command.CommandType = CommandType.StoredProcedure;

            // Set the parameters for the stored procedure
            command.Parameters.AddWithValue("@ProductID", id);
            command.Parameters.AddWithValue("@ProductName", name);
            command.Parameters.AddWithValue("@LocationID", location);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.ExecuteNonQuery();
            MessageBox.Show("Product ADDED");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string location = textBox_location.Text;

            SqlCommand command = new SqlCommand("DeleteProduct", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductID", id);
            command.Parameters.AddWithValue("@LocationID", location);
            command.ExecuteNonQuery();
            MessageBox.Show("Product Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            SqlCommand command = new SqlCommand("ViewInventory", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductID", id);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Retrieve data from the reader
                        int productID = reader.GetInt32(0); // Assuming ProductID is in the first column
                        string locationName = reader.GetString(1); // Assuming LocationName is in the second column
                        int totalQuantity = reader.GetInt32(2); // Assuming TotalQuantity is in the third column

                        // Process retrieved data here (e.g., display in MessageBox)
                        MessageBox.Show($"ProductID: {productID}, LocationName: {locationName}, TotalQuantity: {totalQuantity}");
                    }
                }
                else
                {
                    // No rows returned
                    MessageBox.Show("No data found.");
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string quantity = textBox_quantity.Text;
            string location = textBox_location.Text;
            SqlCommand command = new SqlCommand("UpdateInventory", sql);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductID", id);
            command.Parameters.AddWithValue("@NewQuantity ", quantity);
            command.Parameters.AddWithValue("@LocationID", location);
            command.ExecuteNonQuery();
            MessageBox.Show("Inventory Updated");
        }
    }
}
