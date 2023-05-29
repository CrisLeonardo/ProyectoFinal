using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra
{
    internal interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }
        int Anio { get; set; }
        string Placa { get; set; }
        string Tipo { get; set; }
        int VelocidadMaxima { get; }
        int VelocidadActual { get; }
        string Bocina();
        int Acelerar(int cuanto);
        string Encender();
        string Apagar();
        int Frenar(int cuanto);
    }
}
