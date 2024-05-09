using CustomProject;
using MySql.Data.MySqlClient;
using NUnit.Framework.Constraints;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System;
using System.Windows.Forms;



namespace CustomUIUX
{
    public partial class Form1 : Form
    {
        string text;
        string selectedvalue;
        string result = "";
        List<string> queryresult;

        //post function
        string name = "";
        string desc = "";
        string[] ids = new string[] { "" };
        Location location;
        LocationList locs;


        /*LocationList locs = new LocationList();
        Location swin = new Location(new string[] { "location", "swinburne", "Swinburne" }, "Swinburne", "a school");
        Item item1 = new Item(new string[] { "spoon" }, "spoon", "a spoon");
        Item item2 = new Item(new string[] { "spoon" }, "apple", "an applee");*/



        int status = 1;


        private MySqlConnection connection;
        private string server;
        private string database;
        private string password;
        private string user;
        string connectionString;


        public Form1()
        {
            InitializeComponent();
            SqlServer server = new SqlServer();
            //locs = server.CreateList();
            //Initialize();
            /*locs.AddLocation(swin);
            swin.Inventory.Put(item1);
            swin.Inventory.Put(item2);*/

            /*foreach (Location l in locs.GetList)
            {
                comboBox1.Items.Add(l.Name);
                comboBox2.Items.Add(l.Name);
            }

            try
            {
                connection.Open();
                //LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }*/
        }

        /*private void Initialize()
        {
            server = "feenix-mariadb.swin.edu.au";
            database = "s103805253_db";
            user = "s103805253";
            password = "s103805253";

            connectionString = $"server={server};user ={user}; database={database};password={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM cars";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            System.Data.DataTable dataTable = new System.Data.DataTable();

            dataAdapter.Fill(dataTable);

            // Now you can use the dataTable as needed, for example:
            dataGridView1.DataSource = dataTable;
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }
        //search function
        private void button1_Click(object sender, EventArgs e)
        {

            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand("look");

            queryresult = c.Execute(location, text, "id");

            // Set label text here
            foreach (string i in queryresult)
            {
                result += i + "\n";
            }

            label6.Text = result;
            result = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = result;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = locs.Locate(comboBox1.SelectedItem.ToString());
            selectedvalue = comboBox1.SelectedValue.ToString(); // This line retrieves the selected value from the combo box
        }






        private void button2_Click(object sender, EventArgs e)
        {
            SendForm form = null;
            FormFactory f = new FormFactory();
            string output = "Error";

            if (name == "")
                output = "Please enter your name";
            else if (location == null)
                output = "Please select your location";
            else
            {
                form = f.MakeForm("post");
                output = form.Execute(ids, name, desc, location);
            }

            MessageBox.Show(output);


        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            location = locs.Locate(comboBox1.SelectedItem.ToString());
        }



        private void ItemnameTextbox_TextChanged(object sender, EventArgs e)
        {
            name = ItemnameTextbox.Text;
        }

        private void DesccriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            desc = DesccriptionTextbox.Text;
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {
            ids = textBox2.Text.Split(',');

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            status = status * (-1);
            if (status > 0)
            {
                button2.Text = "Lost an item?";

                Form.Hide();
            }
            else
            {
                button2.Text = "Found an item?";

                Form.Show();
            }


        }

        private void Form_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            name = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            desc = textBox4.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = locs.Locate(comboBox2.SelectedItem.ToString());
        }

        private void RelatedidTextbox_TextChanged(object sender, EventArgs e)
        {
            ids = textBox2.Text.Split(',');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendForm form = null;
            FormFactory f = new FormFactory();
            string output = "Error";

            if (name == "")
                output = "Please enter your name";
            else if (location == null)
                output = "Please select your location";
            else
            {
                form = f.MakeForm("retrieve");
                output = form.Execute(ids, name, desc, location);
            }

            MessageBox.Show(output);
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}