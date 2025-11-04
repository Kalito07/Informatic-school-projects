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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader r = new StreamReader("clasResult.txt");
            richTextBox1.Text = r.ReadToEnd();
            r.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
