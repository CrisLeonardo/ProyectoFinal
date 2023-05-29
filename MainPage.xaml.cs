using ProyectoFinalProgra.PaginasVehiculos;

namespace ProyectoFinalProgra;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        // Aquí redireccionas a otra página
        // Puedes usar el siguiente código como ejemplo:
        Navigation.PushAsync(new Vehiculos());
    }

    private void OnCerrarClicked(object sender, EventArgs e)
    {
        // Código para finalizar la aplicación
        System.Environment.Exit(0);
    }
}
