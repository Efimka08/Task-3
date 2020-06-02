using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.NextDouble() * 10;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            Form1_Load(sender, e);
            if (radioButton1.Checked)
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(dataGridView1[0, i].Value));
            }
            else if (radioButton2.Checked)
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(dataGridView1[1, i].Value));
                }
                    else if (radioButton3.Checked)
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(dataGridView1[2, i].Value));
                        }
                        else if (radioButton4.Checked)
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(dataGridView1[3, i].Value));
                            }
                            else
                                for (int i = 0; i < dataGridView1.RowCount; i++)
                                {
                                    chart1.Series[0].Points.AddXY(i + 1, Convert.ToDouble(dataGridView1[4, i].Value));
                                }
            int nstr = 0;
            int kmax = 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int a = Convert.ToInt32(dataGridView1[i, 0].Value);
                int counter = 1;
                for (int j = 1; j < 5; j++)
                {
                    if (a == Convert.ToInt32(dataGridView1[j, i].Value))
                        counter++;
                    else
                        a = Convert.ToInt32(dataGridView1[j, i].Value);
                }
                if (counter > kmax)
                {
                    kmax = counter;
                    nstr = i;
                }
            }
            textBox1.Text = Convert.ToString(nstr + 1);

            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                int counter = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (Convert.ToInt32(dataGridView1[j, i].Value) == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter != 0)
                    k++;
            }
            textBox2.Text = Convert.ToString(k);
        }
    }
}