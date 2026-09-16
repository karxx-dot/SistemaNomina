using System.Windows.Forms;

namespace SistemaNomina
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SistemaNomina());
        }
    }
}
