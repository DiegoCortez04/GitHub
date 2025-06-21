using GitHub;

namespace GitHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("inicio", typeof(MainPage));
            Routing.RegisterRoute("cineSeries", typeof(CinePage));
            Routing.RegisterRoute("videojuegos", typeof(VideojuegosPage));
            Routing.RegisterRoute("musica", typeof(Musica));
            Routing.RegisterRoute("lectura", typeof(LecturaPage));
        }
    }
}
