namespace GitHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("cineSeries", typeof(CinePage));
            Routing.RegisterRoute("videojuegos", typeof(VideojuegosPage));
            Routing.RegisterRoute("musica", typeof(Musica));
<<<<<<< HEAD
            Routing.RegisterRoute("lectura", typeof(LecturaPage));
=======
            //Routing.RegisterRoute("lectura", typeof(Views.LecturaPage));
>>>>>>> e820024f6e3f3d8f413bc839ba291459a17ad41f
        }
    }
}
