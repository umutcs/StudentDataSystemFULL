using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentDataProgram
{
    public partial class Form1 : Form
    {
        private const string FolderName = "Students";

        public Form1()
        {
            InitializeComponent();

        }

        private void RefreshStudents()
        {
            if (!Directory.Exists(FolderName))
            {
                Directory.CreateDirectory(FolderName);
            }
            string[] allStudents = Directory.GetFiles("Students", "*.txt", SearchOption.AllDirectories);

            foreach (string item in allStudents)
            {
                FileInfo fi = new FileInfo(item);
                if (fi.Length < 1)
                {
                    continue;
                }

                string[] studentInfo = File.ReadAllLines(item)[0].Trim().Split('/');
                dataGridView1.Rows.Add(studentInfo);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            RefreshStudents();

        }

        public void btnAdd_Click(object sender, EventArgs e)

        {



            string OGRNO = txtID.Text;
            string studentFolderPath = $@"{FolderName}\{OGRNO}";

            if (Directory.Exists(studentFolderPath))
            {
                MessageBox.Show("Bu öğrenci daha önce kaydedilmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              


                Student student = new Student
                {
                    studentNumber = txtID.Text,
                    grade = Convert.ToString(comboBox3.SelectedItem),
                    name = txtName.Text,
                    lastName = txtSurname.Text,
                    univercity = Convert.ToString(comboBox1.Text),
                    department = Convert.ToString(comboBox2.Text)
                };


                StudentValid valid = new StudentValid();
                ValidationResult result = valid.Validate(student);
                IList<ValidationFailure> failures = result.Errors;
                if (!result.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {





                    //Öğrenci ekleme

                    Directory.CreateDirectory($@"{FolderName}\{OGRNO}");

                    using (StreamWriter sw = new StreamWriter($@"{studentFolderPath}\{OGRNO}.txt", true))
                    {
                        if (openFileDialog1.ShowDialog() != DialogResult.OK)
                        {
                            return;
                        }

                        string studentPhotoPath = $@"{FolderName}\{OGRNO}\{OGRNO}";

                        string sourcePath = pictureBox1.ImageLocation;

                        string destPath = studentPhotoPath;


                        string imagePath = destPath + Guid.NewGuid().ToString() + ".jpeg";
                        File.Move(openFileDialog1.FileName, imagePath);
                        pictureBox1.Image = Bitmap.FromFile(imagePath);

                        string uni = Convert.ToString(comboBox1.SelectedItem);
                        string dep = Convert.ToString(comboBox2.SelectedItem);
                        string grade = Convert.ToString(comboBox3.SelectedItem);


                        sw.WriteLine(Convert.ToString(txtID.Text) + "/" + txtName.Text + "/" + txtSurname.Text + "/" + uni + "/" + dep + "/" + grade);
                        sw.Close();
                        string[] lines = File.ReadAllLines($@"{FolderName}\{OGRNO}\{OGRNO}.txt");

                        string[] values;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            values = lines[i].ToString().Split('/');
                            string[] row = new string[values.Length];
                            for (int j = 0; j < values.Length; j++)
                            {
                                row[j] = values[j].Trim();
                            }


                         

                        }

                    }
                    RefreshStudents();
                    MessageBox.Show("Öğrenci başarıyla sisteme eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}