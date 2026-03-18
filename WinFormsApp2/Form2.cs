using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private string _Painter;


        private Form1 form1;

        private int i = 1;

        public Form2(Form1 form1, string painterName)
        {
            txt - описание (richTextBox1.Text)

                файл с именем - портрет (pictureBox1.Image)

                остальные изображения - картины (pictureBox2.Image)


            string folderPath = _Painter;

            string txtFile = Directory.GetFiles(folderPath, "*.txt").FirstOrDefault();

            InitializeComponent();
            this.form1 = form1;
            _Painter = painterName;
            pictureBox1.Image = painterName;
            pictureBox2.Image = 1 + painterName;
            richTextBox1.Text = File.ReadAllText(painterName + ".txt");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form1.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 1)
            {
                i -= 1;
            }
            else
            {
                i = 3;
            }

            pictureBox2.ImageLocation = i.ToString() + _Painter + ".jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i != 3)
            {
                i += 1;
            }
            else
            {
                i = 1;
            }

            pictureBox2.ImageLocation = i.ToString() + _Painter + ".jpg";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
