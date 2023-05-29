namespace ProyectoFinalProgra.PaginasVehiculos;
using ProyectoFinalProgra.ClasesVehiculos;
public partial class CuadPag : ContentPage
{
    private CuatroX4 cX4 = new CuatroX4();
    private bool cX4Disguise = false;
    public CuadPag()
    {        
        InitializeComponent();
        cX4.Marca = "RAM";
        cX4.Modelo = "trx";
        cX4.Color = "Negro";
        cX4.Anio = 2023;
        cX4.Placa = "P202JZR";
        cX4.Tipo = "4x4";
        cX4.VelocidadMaxima = 260;
        string cX4Info = $"Marca: {cX4.Marca}\nModelo: {cX4.Modelo}\nColor: {cX4.Color}\nAño: {cX4.Anio}\nPlaca: {cX4.Placa}\nTipo: {cX4.Tipo}\nVelocidad Maxima: {cX4.VelocidadMaxima}";
        cX4Label.Text = cX4Info;
    }

    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void HornC(object sender, EventArgs e)
    {

        if (cX4Disguise)
        {
            cX4Disguise = false;
            cX4Label2.Text = string.Empty; 
        }
        else
        {
            Console.Beep(1000,500);
            cX4.Bocina();
            string cX4M = $"Bocinando: {cX4.Bocina()}";
            cX4Label2.Text = cX4M;
            cX4Disguise = true;
        }
    }

    private void OnC(object sender, EventArgs e)
    {
        string cX4M = cX4.Encender();
        cX4Label2.Text = cX4M;
    }
    private void OffC(object sender, EventArgs e)
    {
        string cX4M = cX4.Apagar();
        cX4Label2.Text = cX4M;
    }
    private void SpeedUpC(object sender, EventArgs e)
    {
        int Speed = cX4.Acelerar(cX4.Velocidad);
        if (Speed <= 260) 
        {
            string cX4M = $"Aumenteando la velocida a: {Speed} KM/H";
            cX4Label2.Text = cX4M;
        }
        else
        {
            string Alert = $"llegaste a la velocidad maxima de {cX4.VelocidadMaxima} KM/H";
            cX4Label2.Text = Alert;
            cX4.Velocidad -= 10;
        }
    }
    private void CurbC(object sender, EventArgs e)
    {
        int Speed = cX4.Frenar(cX4.Velocidad);
        if (Speed >= 0) 
        {
            string cX4M = $"Bajando la velocidad a: {Speed} KM/H";
            cX4Label2.Text = cX4M;
        }
        else
        {
            string Alert = "Ya has frenado por completo";
            cX4Label2.Text = Alert;
            cX4.Velocidad += 10;
        }
    }
}
