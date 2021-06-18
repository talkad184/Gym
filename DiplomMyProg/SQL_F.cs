using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using DiplomMyProg;
using System.Runtime.InteropServices;


namespace DiplomMyProg
{
    static class SQL_F
    {

        public static MySqlConnection con = null;

        //public static string Server = "localhost";
        //public static string User_id = "root";
        //public static string Password = "1111";
        //public static string DataBase = "mydb";

        public static bool LoadProgram;

        public static void DB()
        {

            FileStream load1 = null;
            load1 = new FileStream(@"C:\Gym\Server.txt", FileMode.Open);
            StreamReader read1 = new StreamReader(load1);
            string Server = read1.ReadToEnd();
            load1.Close();

            FileStream load2 = null;
            load2 = new FileStream(@"C:\Gym\User_id.txt", FileMode.Open);
            StreamReader read2 = new StreamReader(load2);
            string User_id = read2.ReadToEnd();
            load2.Close();

            FileStream load3 = null;
            load3 = new FileStream(@"C:\Gym\Password.txt", FileMode.Open);
            StreamReader read3 = new StreamReader(load3);
            string Password = read3.ReadToEnd();
            load3.Close();

            FileStream load4 = null;
            load4 = new FileStream(@"C:\Gym\DataBase.txt", FileMode.Open);
            StreamReader read4 = new StreamReader(load4);
            string DataBase = read4.ReadToEnd();
            load4.Close();


            con = new MySqlConnection("server=" + Server + "; user id=" + User_id + "; password=" + Password + "; database=" + DataBase);
        }



        public static string getId(string table, string column, string search, string value)
        {
            string selectQuery = "SELECT " + search + " FROM " + table + " WHERE " + column + " = '" + value + "'";
            
            try
            {
                using (MySqlCommand com = new MySqlCommand(selectQuery, con))
                {
                    using (MySqlDataReader rd = com.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            //MessageBox.Show("=" + rd[0].ToString());
                            return rd[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // здесь возможно исправить нужно NULL на что-то другое
            return "привет";

        }

        public static DataTable ShowData(string table)
        {
            string selectQuery = "SELECT * FROM " + table + "";
            DataTable DATA = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(DATA);
            return DATA;
        }


        public static List<string> outputData(string table, string column)
        {
            List<string> mas = new List<string>();
            string selectQuery = "SELECT " + column + " FROM " + table + "";
            try
            {
                using (MySqlCommand com = new MySqlCommand(selectQuery, con))
                {
                    using (MySqlDataReader rd = com.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            mas.Add(rd[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return mas;
        }

        public static string GetSelectData(string ColumnName, string table, string TextId)
        {
            string selectQuery = "SELECT " + ColumnName + " FROM " + table + " WHERE id" + table + " = " + TextId ;
            List<string> lst = new List<string>();
            try
            {
                using (MySqlCommand com = new MySqlCommand(selectQuery, con))
                {
                    using (MySqlDataReader rd = com.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            //MessageBox.Show("=" + rd[0].ToString());
                            return rd[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // здесь возможно исправить нужно NULL на что-то другое
            return "";
        }

        public static List<string> Output()
        {
            con.Close();
            con.Open();
            List<string> mas = new List<string>();
            string selectQuery = "show tables";
            try
            {
                using (MySqlCommand com = new MySqlCommand(selectQuery, con))
                {
                    using (MySqlDataReader rd = com.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            mas.Add(rd[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ffffff" + ex.Message);
            }
            con.Close();
            return mas;
        }

        public static string findID(string table)
        {
            string selectQuery = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + table + "'";
            List<string> lst = new List<string>();
            try
            {
                MySqlCommand com = new MySqlCommand(selectQuery, con);
                using (MySqlDataReader rd = com.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        //lst.Add(rd[0].ToString());
                        //MessageBox.Show(table + " ищем id = " + rd[0].ToString());
                        return rd[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("findId___" + ex.Message);
            }
            return "";
        }


        public static bool Validate(string name, List<string> list)
        {
            foreach (string a in list)
                if (name == a)
                {
                    return true;
                }
            return false;
        }

        public static int CountDate;



        public static string tablesname;
        public static string TextId;

    }
}
