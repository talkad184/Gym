using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomMyProg
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            void test() {
                try
                {
                    SQL_F.DB();
                    SQL_F.con.Open();
                    SQL_F.con.Close();
                    Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    Application.Run(new FormServerConnect());
                    if (SQL_F.LoadProgram == true)
                    {
                        try
                        {
                            SQL_F.DB();
                            SQL_F.con.Open();
                            SQL_F.con.Close();
                            Application.Run(new Form1());
                        }
                        catch (Exception ex1)
                        {
                            test();
                        }
                    }
                }
            }

            test();

        }
    }
}
