namespace ProyectoFinalProgra.PaginasVehiculos;


using Microsoft.Maui.Controls;

public partial class Vehiculos : ContentPage
{
	public Vehiculos()
	{
		InitializeComponent();
	}

    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void ButtonSedan(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SedanPag());
    }

    private void ButtonPickUp(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PickUpPag());
    }
    private void ButtonSuv(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SUVPag());
    }

    private void ButtonCuad(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CuadPag());
    }
    private void ButtonModif(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ModifcarPagina());
    }
}