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
            double maxAvg = double.MinValue;
            string topStudent = "";
            double minSubjectAvg = double.MaxValue;
            string lowestSubject = "";

            // Пресмятаме успеха на всеки ученик
            for (int i = 0; i < studentCount; i++)
            {
                double sumGrades = 0;
                bool validGrades = true;

                for (int j = 1; j <= subjects.Length; j++)
                {
                    var cellValue = dataGridView1[i,j].Value;
                    if (cellValue == null || !double.TryParse(cellValue.ToString(), out double grade))
                    {
                        validGrades = false;
                        break;
                    }
                    sumGrades += grade;
                }

                if (!validGrades)
                {
                    MessageBox.Show($"Невалидна оценка при ученик на ред {i + 1}");
                    return;
                }

                double avg = sumGrades / subjects.Length;

                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    topStudent = dataGridView1[i,0].Value.ToString();
                }
            }

            // Пресмятаме среден успех за всеки предмет
            for (int j = 1; j <= subjects.Length; j++)
            {
                double sumGrades = 0;

                for (int i = 0; i < studentCount; i++)
                {
                    var cellValue = dataGridView1[i, j].Value;
                    if (cellValue == null || !double.TryParse(cellValue.ToString(), out double grade))
                    {
                        MessageBox.Show($"Невалидна оценка при предмет {subjects[j - 1]}");
                        return;
                    }
                    sumGrades += grade;
                }

                double avg = sumGrades / studentCount;

                if (avg < minSubjectAvg)
                {
                    minSubjectAvg = avg;
                    lowestSubject = subjects[j - 1];
                }
            }

            lblTopStudent.Text = $"Ученик с най-висок успех: {topStudent} ({maxAvg:F2})";
            lblLowestSubject.Text = $"Предмет с най-нисък среден успех: {lowestSubject} ({minSubjectAvg:F2})";
        }
    }
}
