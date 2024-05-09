using CustomProject;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace CustomUIUX
{
    public partial class Form1 : Form
    {
        string text;
        string selectedvalue;
        string queryresult;

        //post function
        string postname;
        string desc;
        string[] ids;
        Location location;

        LocationList locs = new LocationList();
        Location swin = new Location(new string[] { "location", "swinburne" }, "Swinburne", "a school");
        Item item1 = new Item(new string[] { "spoon" }, "spoon", "a spoon");
        


        public Form1()
        {
            InitializeComponent();
            locs.AddLocation(swin);
            swin.Inventory.Put(item1);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommandFactory command = new CommandFactory();
            Command c = null;

            c = command.makeCommand(text.Split(" "));

            queryresult = c.Execute(locs, text.Split(" "));

            // Set label text here
            label6.Text = queryresult;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = comboBox1.SelectedItem as Location;
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            foreach (Location loc in locs.GetList)
            {
                comboBox1.Items.Add(loc);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            Post post = new Post(ids, postname, desc, location);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //label6.Text = queryresult.ToString();
        }

        private void ItemnameTextbox_TextChanged(object sender, EventArgs e)
        {
            postname = ItemnameTextbox.Text;
        }

        private void DesccriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            desc = DesccriptionTextbox.Text;
        }

        private void RelatedidTextbox_TextChanged(object sender, EventArgs e)
        {
            string text = RelatedidTextbox.Text;

            ids = text.Split(',');
        }
    }
}