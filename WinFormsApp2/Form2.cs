using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private string _Painter;
        private Form1 form1;
        private int i = 0;
        private List<string> images = new List<string>();
        private string portraitPath;

        public Form2(Form1 form1, string painterName)
        {
            InitializeComponent();

            this.form1 = form1;
            _Painter = painterName;

            string folderPath = Path.Combine(Application.StartupPath, _Painter);

            string txtFile = Directory.GetFiles(folderPath, "*.txt").FirstOrDefault();

            richTextBox1.Text = File.ReadAllText(txtFile);

            string[] files = Directory.GetFiles(folderPath);

            portraitPath = files.FirstOrDefault(f =>
                Path.GetFileNameWithoutExtension(f).Trim().ToLower() ==
                _Painter.Trim().ToLower() &&
                IsImage(f));

            if (portraitPath != null)
            {
                pictureBox1.ImageLocation = portraitPath;
            }


            images = files
                .Where(f => IsImage(f) && f != portraitPath)
                .ToList();

            if (images.Count > 0)
            {
                pictureBox2.ImageLocation = images[i];
            }

        }

        private bool IsImage(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) 
            {
                return; 
            }

            if (i > 0)
            {
                i--;
            }

            else
            {
                i = images.Count - 1;
            }


            pictureBox2.ImageLocation = images[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                return;
            }

            if (i < images.Count - 1)
            {
                i++;
            }

            else
            {
                i = 0;
            }


            pictureBox2.ImageLocation = images[i];
        }
    }
}