using ProyectoFinalProgra.ClasesVehiculos;

namespace ProyectoFinalProgra.PaginasVehiculos;

public partial class ModifcarPagina : ContentPage
{
    private Modificar modificar = new Modificar();
    private bool modificarDisguise = false;

    public ModifcarPagina()
    {
        InitializeComponent();
        modificar.Marca = "";
        modificar.Modelo = "";
        modificar.Color = "";
        modificar.Anio = 0;
        modificar.Placa = "";
        modificar.Tipo = "";
        modificar.VelocidadMaxima = 0;
        ActualizarModificarInfo();
    }

    private void ActualizarModificarInfo()
    {
        string ModificarInfo = $"Marca: {modificar.Marca}\nModelo: {modificar.Modelo}\nColor: {modificar.Color}\nAño: {modificar.Anio}\nPlaca: {modificar.Placa}\nTipo: {modificar.Tipo}\nVelocidad Maxima: {modificar.VelocidadMaxima}";
        modificarLabel.Text = ModificarInfo;
    }

    private void ModificarPropiedades(object sender, EventArgs e)
    {
        modificar.Marca = marcaEntry.Text;
        modificar.Modelo = modeloEntry.Text;
        modificar.Color = colorEntry.Text;
        if (int.TryParse(anioEntry.Text, out int anio))
        {
            modificar.Anio = anio;
        }
        modificar.Placa = placaEntry.Text;
        modificar.Tipo = tipoEntry.Text;
        if (int.TryParse(maximaEntry.Text, out int velocidadMaxima))
        {
            modificar.VelocidadMaxima = velocidadMaxima;
        }

        ActualizarModificarInfo();
    }

    private void Backbutton(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void HornM(object sender, EventArgs e)
    {

        if (modificarDisguise)
        {
            modificarDisguise = false;
            modificarLabel2.Text = string.Empty;
        }
        else
        {
            Console.Beep(1000, 500);
            string modificarM = $"\nBocinando: {modificar.Bocina()}";
            modificarLabel2.Text = modificarM;
            modificarDisguise = true;
        }
    }

    private void OnM(object sender, EventArgs e)
    {
        string modificarM = modificar.Encender();
        modificarLabel2.Text = modificarM;
    }
    private void OffM(object sender, EventArgs e)
    {
        string modificarM = modificar.Apagar();
        modificarLabel2.Text = modificarM;
    }
    private void SpeedUpM(object sender, EventArgs e)
    {
        int Speed = modificar.Acelerar(modificar.Velocidad);
        if (Speed <= 230)
        {
            string modificarM = $"Aumentando la velocidad a: {Speed} KM/H";
            modificarLabel2.Text = modificarM;
        }
        else
        {
            string alert = $"llegaste a la velocidad maxima de {modificar.VelocidadMaxima} KM/H";
            modificarLabel2.Text = alert;
            modificar.Velocidad -= 10;
        }
    }
    private void CurbM(object sender, EventArgs e)
    {
        int Speed = modificar.Frenar(modificar.Velocidad);
        if (Speed >= 0)
        {
            string modificarM = $"Bajando la velocidad a: {Speed} KM/H";
            modificarLabel2.Text = modificarM;
        }
        else
        {
            string alert = "Ya has frenado por completo";
            modificarLabel2.Text = alert;
            modificar.Velocidad += 10;
        }
    }
}