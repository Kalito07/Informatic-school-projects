using System;
using System.IO;
using System.Windows.Forms;

namespace classResult_11v_11
{
    public partial class Form1 : Form
    {
        Student[] students = new Student[26];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < students.Length; i++)
                students[i] = new Student();
            labelAverage.Hide();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxClas.Clear();
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxBEL.Clear();
            textBoxForeign.Clear();
            textBoxMath.Clear();
            textBoxPhys.Clear();
            textBoxChem.Clear();
            textBoxBio.Clear();
            labelAverage.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                if (id < 1 || id > 26)
                {
                    MessageBox.Show("ID трябва да е между 1 и 26.");
                    return;
                }

                students[id - 1].Id = id;
                students[id - 1].Clas = textBoxClas.Text;
                students[id - 1].Name = textBoxName.Text;
                students[id - 1].BEL = double.Parse(textBoxBEL.Text);
                students[id - 1].Math = double.Parse(textBoxMath.Text);
                students[id - 1].Foreign = double.Parse(textBoxForeign.Text);
                students[id - 1].Phys = double.Parse(textBoxPhys.Text);
                students[id - 1].Chem = double.Parse(textBoxChem.Text);
                students[id - 1].Bio = double.Parse(textBoxBio.Text);

                MessageBox.Show("Ученикът е записан успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                if (id < 1 || id > 26)
                {
                    MessageBox.Show("ID трябва да е между 1 и 26.");
                    return;
                }

                Student s = students[id - 1];

                if (s.Id == 0)
                {
                    MessageBox.Show("Ученик с този ID не е намерен.");
                    return;
                }

                textBoxClas.Text = s.Clas;
                textBoxName.Text = s.Name;
                textBoxBEL.Text = s.BEL.ToString();
                textBoxForeign.Text = s.Foreign.ToString();
                textBoxMath.Text = s.Math.ToString();
                textBoxPhys.Text = s.Phys.ToString();
                textBoxChem.Text = s.Chem.ToString();
                textBoxBio.Text = s.Bio.ToString();

                labelAverage.Text = $"{s.AverageGrade:F2}";
                labelAverage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            try
            {
                double bel = double.Parse(textBoxBEL.Text);
                double foreign = double.Parse(textBoxForeign.Text);
                double math = double.Parse(textBoxMath.Text);
                double phys = double.Parse(textBoxPhys.Text);
                double chem = double.Parse(textBoxChem.Text);
                double bio = double.Parse(textBoxBio.Text);

                double average = (bel + foreign + math + phys + chem + bio) / 6;

                labelAverage.Text = $"Среден успех: {average:F2}";
                labelAverage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при изчисляване на средния успех: " + ex.Message);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("classResults.txt", false))
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (students[i].Id != 0)
                        {
                            writer.WriteLine($"{students[i].Clas}|{students[i].Id}|{students[i].Name}|{students[i].BEL}|{students[i].Foreign}|{students[i].Math}|{students[i].Phys}|{students[i].Chem}|{students[i].Bio}");
                        }
                    }
                }
                MessageBox.Show("Данните са записани във файла успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при запис във файла: " + ex.Message);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("classResults.txt"))
                {
                    MessageBox.Show("Файлът classResults.txt не съществува.");
                    return;
                }

                using (StreamReader reader = new StreamReader("classResults.txt"))
                {
                    students = new Student[26];
                    for (int i = 0; i < students.Length; i++)
                        students[i] = new Student();

                    richTextBox1.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 9)
                        {
                            int id = int.Parse(parts[1]);

                            Student s = new Student(
                                parts[0],                
                                id,                      
                                parts[2],               
                                double.Parse(parts[3]),  
                                double.Parse(parts[4]),  
                                double.Parse(parts[5]),  
                                double.Parse(parts[6]), 
                                double.Parse(parts[7]), 
                                double.Parse(parts[8]) 
                            );



                        students[id - 1] = s;

                            richTextBox1.AppendText(s.ToString() + Environment.NewLine);
                        }
                    }
                }
                MessageBox.Show("Данните са заредени успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при четене на файла: " + ex.Message);
            }
        }
    }
}
