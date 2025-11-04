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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("Input.txt");
            string line = "";
            List<string> input = new List<string>();
            while (line!=null)
            {
                line = reader.ReadLine();
                input.Add(line);
            }
            dataGridView1.Rows.Add(5);
            dataGridView1[0, 0].Value = input[0];
            dataGridView1[0, 1].Value = input[1];
            dataGridView1[0, 2].Value = input[2];
            dataGridView1[0, 3].Value = input[3];
            dataGridView1[0, 4].Value = input[4];
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 4; i++)
            {
                int studentAvr = int.Parse(dataGridView1[1, i].Value) + (int)dataGridView1[2, i].Value + dataGridView1[3, i].Value + dataGridView1[4, i].Value + dataGridView1[5, i].Value + dataGridView1[6, i].Value;
                int min = int.MaxValue;
                if (true)
                {

                }
            }
            
        }
    }
}
