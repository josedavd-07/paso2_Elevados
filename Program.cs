using System;

namespace PasajesAereos
{
    class Program
    {
        static void Main(string[] args)
        {
            //................................................
            //Nombre: Jose David Carranza Angarita
            // Grupo : 213022_77
            // Programa : Ingeniería de Sistemas
            // Código Fuente: autoría propia 
            // Fecha : 02/09/2023
            //.................................................

            // Declaramos las variables que vamos a utilizar
            string nombrePasajero;
            float tarifaBasica = 0f;
            int edad;
            string temporada;
            string tipoPasajero;
            string compañía;

            // Solicitamos al usuario los datos
            Console.WriteLine("Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();

            Console.WriteLine("Ingrese la tarifa básica del pasaje: ");
            tarifaBasica = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la edad del pasajero: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la temporada (alta o baja): ");
            temporada = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de pasajero (estudiante o particular): ");
            tipoPasajero = Console.ReadLine();

            Console.WriteLine("Ingrese la compañía aérea (ALAS o VOLAR): ");
            compañía = Console.ReadLine();

            // Calculamos el precio del pasaje
            float precioBase = tarifaBasica;

            // Aplicamos los descuentos y recargos correspondientes
            if (temporada == "alta")
            {
                precioBase *= 1.3f;
            }

            if (edad < 18)
            {
                precioBase *= 0.5f;
            }

            if (compañía == "VOLAR")
            {
                precioBase += 10000;
            }

            // Calculamos el precio final del pasaje
            float precioFinal = precioBase;

            // Imprimimos el resultado
            Console.WriteLine("El precio final del pasaje para {0} es de ${1:0.00}", nombrePasajero, precioFinal);
        }
    }
}
