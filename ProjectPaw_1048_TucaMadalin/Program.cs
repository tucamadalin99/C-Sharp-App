using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Tuca_Madalin_1048
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new firstPanel());
            Application.Run(new Form2());
            User u1 = new User();
            

        //User u2 = new User("Daniel", "Mosneanu", "danymos99@yahoo.com", "0723319930", 49);
        double[] preturi = { 210.0, 432.34, 456.23, 451.35 };
            double pretMediu = 0.0;
            Cazare c = new Cazare("Targu Jiu", 3, "Europa", 4, "Dubla", preturi, 500);
            pretMediu = c.calcPretMediu();
            c.PretMediu = pretMediu;
            

        }
    }
}
