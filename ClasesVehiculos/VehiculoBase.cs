using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra.ClasesVehiculos
{
    internal class VehiculoBase : IVehiculo
    {
        private int Vel = 0;

        public bool OnOrOff = false;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; set; }
        public int VelocidadActual { get; set; }

        public string Bocina()
        {
            return ("Beeeeeep");
        }


        public string Encender()
        {

            if (OnOrOff)
            {

                return ("Ya has encendido el carro no lo puedes encender denuevo");


            }
            else
            {
                OnOrOff = true;
                return ("Encendiendo la mamalona");
            }
        }

        public string Apagar()
        {

            if (OnOrOff)
            {
                Vel = 0;
                OnOrOff = false;
                return ("Apagando la mamalona");


            }
            else
            {

                return ("No lo puedes apagar porque aun no lo has encendido");

            }

        }
        public int Acelerar(int cuanto)
        {
            if (OnOrOff)
            {
                Vel += 10;
                return Vel;

            }
            else
            {
                return 0;
            }
        }

        public int Frenar(int cuanto)
        {

            if (OnOrOff)
            {
                Vel -= 10;
                Console.WriteLine("Frenando el vehículo en {0} unidades", Vel);
                return Vel;

            }
            else
            {
                Console.WriteLine("El carro esta apagado no puedes frenar si esta pagado");
                return 0;
            }

        }

        public int Velocidad
        {
            get { return Vel; }
            set { Vel = value; }
        }

    }
}
