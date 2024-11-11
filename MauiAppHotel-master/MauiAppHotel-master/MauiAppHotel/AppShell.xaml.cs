using System;

namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Definindo rotas para as páginas adicionais
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ReservaPage), typeof(ReservaPage));
            Routing.RegisterRoute(nameof(PerfilPage), typeof(PerfilPage));
        }
    }
}