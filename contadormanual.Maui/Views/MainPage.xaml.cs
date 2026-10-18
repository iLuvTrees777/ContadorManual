using contadormanual.Maui.Models;

namespace contadormanual.Maui.Views
{
    public partial class MainPage : ContentPage
    {
        private Contador _contador;

        public MainPage()
        {
            InitializeComponent();
            _contador = new Contador();
            ConteoLabel.Text = _contador.conteo.ToString();
        }

        private void Contar_Clicked(object sender, EventArgs e)
        {
            _contador.Contar();
            ConteoLabel.Text = _contador.conteo.ToString();
        }

        private void Reiniciar_Clicked(object sender, EventArgs e)
        {
            _contador.Reiniciar();
            ConteoLabel.Text = _contador.conteo.ToString();
        }

    }
}