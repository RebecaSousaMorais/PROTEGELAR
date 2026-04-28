using System;
using System.Windows.Forms;
using DotNetEnv;

namespace PROJETO_INTEGRADOR
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Carrega variáveis do arquivo .env
                Env.Load();

                // Inicializa banco SQLite (cria arquivo + tabelas + dados)
                Conexao.InicializarBanco();

                // Inicializa aplicação Windows Forms
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Inicia pelo Login
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                // Evita app fechar sem mostrar erro
                MessageBox.Show("Erro crítico ao iniciar o sistema: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}