using ProyectoFinalProgra.ClasesVehiculos;

namespace ProyectoFinalProgra.PaginasVehiculos;

public partial class SedanPag : ContentPage
{
    private Sedan sedan = new Sedan();
    private bool sedanDisguise = false;

    public SedanPag()
    {
        InitializeComponent();
        sedan.Marca = "Lexus";
        sedan.Modelo = "Lexus IS";
        sedan.Color = "Gris";
        sedan.Anio = 2019;
        sedan.Placa = "Q76EV12T";
        sedan.Tipo = "Sedán";
        sedan.VelocidadMaxima = 290;
        string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}\nVelocidad Maxima {sedan.VelocidadMaxima}";
        sedanLabel.Text = sedanInfo;
    }

    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void HornS(object sender, EventArgs e)
    {

        if (sedanDisguise)
        {
            sedanDisguise = false;
            sedanLabel2.Text = string.Empty; 
        }
        else
        {
            Console.Beep(1000, 500);
            string sedanM = $"Bocinando: {sedan.Bocina()}";
            sedanLabel2.Text = sedanM;
            sedanDisguise = true;
        }
    }

    private void OnS(object sender, EventArgs e)
    {
        string sedanM = sedan.Encender();
        sedanLabel2.Text = sedanM;
    }
    private void OffS(object sender, EventArgs e)
    {
        string sedanM = sedan.Apagar();
        sedanLabel2.Text = sedanM;
    }
    private void SpeedUpS(object sender, EventArgs e)
    {
        int Speed = sedan.Acelerar(sedan.Velocidad);
        if (Speed <= 290)
        {
            string sedanM = $"Aumentando la velocidad a: {Speed} KM/H";
            sedanLabel2.Text = sedanM;
        }
        else
        {
            string alert = $"llegaste a la velocidad maxima de {sedan.VelocidadMaxima} KM/H";
            sedanLabel2.Text = alert;
            sedan.Velocidad -= 10;
        }
    }
    private void CurbS(object sender, EventArgs e)
    {

        int Speed = sedan.Frenar(sedan.Velocidad);

        if (Speed >= 0) 
        {
            string sedanM = $"Bajando la velocidad a: {Speed} KM/H";
            sedanLabel2.Text = sedanM;
        }
        else
        {
            string alert = "Ya has frenado por completo";
            sedanLabel2.Text = alert;
            sedan.Velocidad += 10;
        }

    }
}

