using ProyectoFinalProgra.ClasesVehiculos;

namespace ProyectoFinalProgra.PaginasVehiculos;

public partial class SUVPag : ContentPage
{
    private SUV suv = new SUV();
    private bool suvDisguise = false;


    public SUVPag()
    {
        InitializeComponent();
        SUV suv = new SUV();
        suv.Marca = "Jeep";
        suv.Modelo = "Wrangler";
        suv.Color = "Amarillo";
        suv.Anio = 2022;
        suv.Placa = "789NOSE";
        suv.Tipo = "SUV";
        suv.VelocidadMaxima = 230;    
        string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}\nVelocidad Maxima: {suv.VelocidadMaxima}";
        suvLabel.Text = suvInfo;
    }

    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void HornV(object sender, EventArgs e)
    {

        if (suvDisguise)
        {
            suvDisguise = false;
            suvLabel2.Text = string.Empty;
        }
        else
        {
            Console.Beep(1000, 500);
            string suvM = $"\nBocinando: {suv.Bocina()}";
            suvLabel2.Text = suvM;
            suvDisguise = true;
        }
    }

    private void OnV(object sender, EventArgs e)
    {
        string suvM = suv.Encender();
        suvLabel2.Text = suvM;
    }
    private void OffV(object sender, EventArgs e)
    {
        string suvM = suv.Apagar();
        suvLabel2.Text = suvM;
    }
    private void SpeedUpV(object sender, EventArgs e)
    {
        int Speed = suv.Acelerar(suv.Velocidad);
        if (Speed <= 230) 
        {
            string suvM = $"Aumentando la velocidad a: {Speed} KM/H";
            suvLabel2.Text = suvM;
        }
        else
        {
            string alert = $"llegaste a la velocidad maxima de {suv.VelocidadMaxima} KM/H";
            suvLabel2.Text = alert;
            suv.Velocidad -= 10;
        }
    }
    private void CurbV(object sender, EventArgs e)
    {
        int Speed = suv.Frenar(suv.Velocidad);
        if (Speed >= 0) 
        {
            string suvM = $"Bajando la velocidad a: {Speed} KM/H";
            suvLabel2.Text = suvM;
        }
        else
        {
            string alert = "Ya has frenado por completo";
            suvLabel2.Text = alert;
            suv.Velocidad += 10;
        }
    }
}