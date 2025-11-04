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

namespace classResults
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        Student[] students = new Student[27];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_sreden.Hide();
            for (int i = 1; i < 27; i++)
            {
                classof[i] = new Student();
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textBoxClass.Text = "";
            textBoxNo.Text = "";
            textBoxIme.Text = "";
            textBoxBEL.Text = "";
            textBoxFor.Text = "";
            textBoxMath.Text = "";
            textBoxPhys.Text = "";
            textBoxChem.Text = "";
            textBoxBio.Text = "";
            label_sreden.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student("Pesho", "11v", "11", 3, 4, 3, 4, 5, 6);
                StreamWriter w = new StreamWriter("clasResult.txt", true);
                w.WriteLine($"{txtBName.Text} {txtBKlas.Text} {txtBID.Text} {label12.Text}");
                w.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader r = new StreamReader("clasResult.txt");
                richTextBox1.Text = r.ReadToEnd();
                r.Close();
            }
            catch (FileNotFoundException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
