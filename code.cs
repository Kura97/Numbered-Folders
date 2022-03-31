using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace nfcApp
{
    public partial class Form1 : Form
    {
        int first, end, test;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                test = int.Parse(textBox2.Text);
            }
            catch (SystemException)
            {
                if (textBox2.Text == "")
                {
                }
                else
                {
                    MessageBox.Show("يجب ادخال رقم فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete("C:\\folderss", true);
                MessageBox.Show("تم حذف المجلدات ", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SystemException)
            {
                MessageBox.Show("المجلدات محذوفة بالفعل!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                test = int.Parse(textBox1.Text);
            }
            catch (SystemException)
            {
                if (textBox1.Text == "")
                {
                }
                else
                {
                    MessageBox.Show("يجب ادخال رقم فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

             if ( textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("يجب ملئ الخانات الفارغة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                MessageBox.Show("يجب البدء من الاصغر الى الاكبر", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                first = int.Parse(textBox1.Text);
                end = int.Parse(textBox2.Text);
                Directory.CreateDirectory("C:\\folderss");

                for (int i = first; i <= end; i++)
                {
                    Directory.CreateDirectory("C:\\folderss\\" + i);
                }
                Process.Start("C:\\folderss");
            }
        }
    }
}
