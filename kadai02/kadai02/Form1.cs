using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace kadai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string text = textBox2.Text;
            StreamWriter textFile;
            textFile = new StreamWriter(path, false, System.Text.Encoding.Default);
            textFile.WriteLine(text);
            textFile.Close();
            label3.Text = "書き出しました";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (File.Exists(path) == false)
            {
                label3.Text = "ファイルがありません";
                return;
            }
            StreamReader textFile;
            textFile = new StreamReader(path, System.Text.Encoding.Default);
            label3.Text = "ファイルの中身:" + textFile.ReadToEnd();
            textFile.Close();
        }
    }
}
