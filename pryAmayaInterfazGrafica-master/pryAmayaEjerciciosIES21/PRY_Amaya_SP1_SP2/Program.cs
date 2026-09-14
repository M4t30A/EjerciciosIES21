using pryAmayaEjerciciosIES21;
using System.Windows.Forms;

namespace pryAmayaInterfazGrafica
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Mensaje temporal para comprobar que Main se ejecuta
            MessageBox.Show("Arranca Main", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Run(new ReservadeCabaña());
        }
    }
}