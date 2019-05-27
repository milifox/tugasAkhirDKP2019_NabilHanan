using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace todolist_sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> list1 = new Queue<string>();
        string data1;

        Queue<string> list2 = new Queue<string>();
        string data2;

        private void button1_Click(object sender, EventArgs e)
        {
            data1 = textBox1.Text;
            list1.Enqueue(data1);
            textBox1.Clear();

            textBox3.Text = list1.ElementAtOrDefault(0) + Environment.NewLine
                    + list1.ElementAtOrDefault(1) + Environment.NewLine
                    + list1.ElementAtOrDefault(2) + Environment.NewLine
                    + list1.ElementAtOrDefault(3) + Environment.NewLine
                    + list1.ElementAtOrDefault(4) + Environment.NewLine
                    + list1.ElementAtOrDefault(5) + Environment.NewLine
                    + list1.ElementAtOrDefault(6) + Environment.NewLine
                    + list1.ElementAtOrDefault(7) + Environment.NewLine
                    + list1.ElementAtOrDefault(8) + Environment.NewLine
                    + list1.ElementAtOrDefault(9) + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data2 = textBox2.Text;
            list2.Enqueue(data2);
            textBox2.Clear();

            textBox4.Text = list2.ElementAtOrDefault(0) + Environment.NewLine
                    + list2.ElementAtOrDefault(1) + Environment.NewLine
                    + list2.ElementAtOrDefault(2) + Environment.NewLine
                    + list2.ElementAtOrDefault(3) + Environment.NewLine
                    + list2.ElementAtOrDefault(4) + Environment.NewLine
                    + list2.ElementAtOrDefault(5) + Environment.NewLine
                    + list2.ElementAtOrDefault(6) + Environment.NewLine
                    + list2.ElementAtOrDefault(7) + Environment.NewLine
                    + list2.ElementAtOrDefault(8) + Environment.NewLine
                    + list2.ElementAtOrDefault(9) + Environment.NewLine;
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            int jumlah1 = list1.Count;

            if (jumlah1 >= 1)
            {
                list1.Dequeue();

                textBox3.Text = list1.ElementAtOrDefault(0) + Environment.NewLine
                        + list1.ElementAtOrDefault(1) + Environment.NewLine
                        + list1.ElementAtOrDefault(2) + Environment.NewLine
                        + list1.ElementAtOrDefault(3) + Environment.NewLine
                        + list1.ElementAtOrDefault(4) + Environment.NewLine
                        + list1.ElementAtOrDefault(5) + Environment.NewLine
                        + list1.ElementAtOrDefault(6) + Environment.NewLine
                        + list1.ElementAtOrDefault(7) + Environment.NewLine
                        + list1.ElementAtOrDefault(8) + Environment.NewLine
                        + list1.ElementAtOrDefault(9) + Environment.NewLine;
            }   
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            int jumlah2 = list2.Count;

            if (jumlah2 >= 1)
            {
                list2.Dequeue();

                textBox4.Text = list2.ElementAtOrDefault(0) + Environment.NewLine
                        + list2.ElementAtOrDefault(1) + Environment.NewLine
                        + list2.ElementAtOrDefault(2) + Environment.NewLine
                        + list2.ElementAtOrDefault(3) + Environment.NewLine
                        + list2.ElementAtOrDefault(4) + Environment.NewLine
                        + list2.ElementAtOrDefault(5) + Environment.NewLine
                        + list2.ElementAtOrDefault(6) + Environment.NewLine
                        + list2.ElementAtOrDefault(7) + Environment.NewLine
                        + list2.ElementAtOrDefault(8) + Environment.NewLine
                        + list2.ElementAtOrDefault(9) + Environment.NewLine;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
