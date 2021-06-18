using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomMyProg
{
    public partial class FormServerConnect : Form
    {
        public FormServerConnect()
        {
            InitializeComponent();
        }

        private void inp()
        {
            try
            {
                string path = @"C:\Gym";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                //Console.WriteLine("Введите строку для записи в файл:");
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;

                File.WriteAllText(@"C:\Gym\Server.txt", String.Empty);
                File.WriteAllText(@"C:\Gym\User_id.txt", String.Empty);
                File.WriteAllText(@"C:\Gym\Password.txt", String.Empty);
                File.WriteAllText(@"C:\Gym\DataBase.txt", String.Empty);
                // запись в файл
                using (FileStream fstream1 = new FileStream(@"C:\Gym\Server.txt", FileMode.OpenOrCreate))
                {
                    // преобразуем строку в байты
                    byte[] array1 = System.Text.Encoding.Default.GetBytes(text1);
                    // запись массива байтов в файл
                    fstream1.Write(array1, 0, array1.Length);
                }
                using (FileStream fstream2 = new FileStream(@"C:\Gym\User_id.txt", FileMode.OpenOrCreate))
                {
                    byte[] array2 = System.Text.Encoding.Default.GetBytes(text2);
                    fstream2.Write(array2, 0, array2.Length);
                }
                using (FileStream fstream3 = new FileStream(@"C:\Gym\Password.txt", FileMode.OpenOrCreate))
                {
                    byte[] array3 = System.Text.Encoding.Default.GetBytes(text3);
                    fstream3.Write(array3, 0, array3.Length);
                }
                using (FileStream fstream4 = new FileStream(@"C:\Gym\DataBase.txt", FileMode.OpenOrCreate))
                {
                    byte[] array4 = System.Text.Encoding.Default.GetBytes(text4);
                    fstream4.Write(array4, 0, array4.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Данные о базе данных добавлены");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath.ToString());

            //SQL_F.Server = textBox1.Text;
            //SQL_F.User_id = textBox2.Text;
            //SQL_F.Password = textBox3.Text;
            //SQL_F.DataBase = textBox4.Text;

            SQL_F.LoadProgram = false;
            inp();

            SQL_F.DB();
            try
            {
                SQL_F.con.Open();
                MessageBox.Show("Подключение установлено");
                SQL_F.con.Close();
                //this.Hide();
                SQL_F.LoadProgram = true;

                Close();
                //Form1 newform = new Form1();
                //newform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if (SQL_F.Output().Count != 0)
            //{
            //    MessageBox.Show("Подключение установлено");
            //    Close();
            //}
            //else MessageBox.Show("Подключение отсутствует");

        }
    }
}
