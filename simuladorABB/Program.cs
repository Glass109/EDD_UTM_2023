using simuladorABB;
using System.Runtime.InteropServices;
class Program
{
    [STAThread]
    static void Main()
    {
        // Elementos visuales de la aplicaci�n
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Crea una consola para mostrar los mensajes de depuraci�n
        AllocConsole();

        // Iniciar la aplicaci�n
        Application.Run(new Form1());
    }

    // No tengo idea de que hace esto, pero es necesario para que funcione la consola
    [DllImport("kernel32.dll")]
    public static extern Boolean AllocConsole();
}
