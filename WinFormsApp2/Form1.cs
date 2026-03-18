namespace WinFormsApp2
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] painters = File.ReadAllLines("painters.txt");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(painters);
            comboBox1.SelectedIndex = 0;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedName = comboBox1.SelectedItem.ToString();
            Form2 newForm = new Form2(this, selectedName);
            newForm.Show();
            this.Hide();
        }
    }
}
