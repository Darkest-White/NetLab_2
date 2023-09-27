using System;
using System.Windows.Forms;

namespace NetLab2_1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Form myForm = new Form();
            //myForm.Show();
        }
    }
}