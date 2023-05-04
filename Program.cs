
using folhaDePagamento.services;
using FolhaPagamento.Classes;
using MySql.Data.MySqlClient;

namespace FolhaPagamento
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ConnectDatabase connect = new ConnectDatabase();
                connect.connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}