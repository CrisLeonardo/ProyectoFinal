using ProyectoFinalProgra.ClasesVehiculos;

namespace ProyectoFinalProgra.PaginasVehiculos;

public partial class PickUpPag : ContentPage
{
    private PickUp pickUp = new PickUp();
    private bool pickUpDisguise = false;

    public PickUpPag()
    {
        InitializeComponent();
        pickUp.Marca = "Toyota";
        pickUp.Modelo = "Tacoma";
        pickUp.Color = "Anaranjado";
        pickUp.Anio = 2023;
        pickUp.Placa = "Z45X7C";
        pickUp.Tipo = "PickUp";
        pickUp.VelocidadMaxima = 250;
        ActualizarPickUpInfo();
    }

    private void ActualizarPickUpInfo()
    {
        string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}\nVelocidad Maxima: {pickUp.VelocidadMaxima}";
        pickUpLabel.Text = pickUpInfo;
    }

    private void ModificarPropiedades(object sender, EventArgs e)
    {
        pickUp.Marca = marcaEntry.Text;
        pickUp.Modelo = modeloEntry.Text;
        pickUp.Color = colorEntry.Text;
        ActualizarPickUpInfo();
    }
    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void HornP(object sender, EventArgs e)
    {

        if (pickUpDisguise)
        {
            pickUpDisguise = false;
            pickUpLabel2.Text = string.Empty; 
        }
        else
        {
            Console.Beep(1000, 500);
            pickUp.Bocina();
            string pickUpM = $"\nBocinando: {pickUp.Bocina()}";
            pickUpLabel2.Text = pickUpM;
            pickUpDisguise = true;
        }
    }

    private void OnP(object sender, EventArgs e)
    {
        string pickUpM = pickUp.Encender();
        pickUpLabel2.Text = pickUpM;
    }
    private void OffP(object sender, EventArgs e)
    {
        string pickUpM = pickUp.Apagar();
        pickUpLabel2.Text = pickUpM;
    }
    private void SpeedUpP(object sender, EventArgs e)
    {
        int Speed = pickUp.Acelerar(pickUp.Velocidad);
        if (Speed <= 250) 
        {
            string pickUpM = $"Aumenteando la velocida a: {Speed} KM/H";
            pickUpLabel2.Text = pickUpM;
        }
        else
        {
            string alert = $"llegaste a la velocidad maxima de {pickUp.VelocidadMaxima} KM/H";
            pickUpLabel2.Text = alert;
            pickUp.Velocidad -= 10;
        }
    }
    private void CurbP(object sender, EventArgs e)
    {
        int Speed = pickUp.Frenar(pickUp.Velocidad);
        if (Speed >= 0) 
        {
            string pickUpM = $"Bajando la velocidad a: {Speed} KM/H";
            pickUpLabel2.Text = pickUpM;
        }
        else
        {
            string alert = "Ya has frenado por completo";
            pickUpLabel2.Text = alert;
            pickUp.Velocidad += 10;
        }
    }
}