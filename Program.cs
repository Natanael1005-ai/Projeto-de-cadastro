namespace SistemaUsuarios
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var contexto = new ApplicationContext();

            Form1 telaLogin = new Form1();
            telaLogin.FormClosed += (s, e) =>
            {
                // Só encerra o app quando não sobrar nenhuma janela aberta
                if (Application.OpenForms.Count == 0)
                    contexto.ExitThread();
            };

            telaLogin.Show();

            Application.Run(contexto);
        }
    }
}