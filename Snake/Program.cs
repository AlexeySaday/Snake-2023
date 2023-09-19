using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Snake
{
    internal static class Program
    {

        private static string UserName = "Defualt";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            UserName = Console.ReadLine();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(UserName));
        }
    }
}