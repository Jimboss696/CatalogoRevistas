using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoRevistas
{
    class Program
    {
        // Función para buscar de manera iterativa un título en el catálogo
        // Recibe la lista de revistas y el título a buscar
        static bool BuscarTitulo(List<string> catalogo, string titulo)
        {
            // Recorremos cada elemento de la lista (catálogo de revistas)
            foreach (var item in catalogo)
            {
                // Comparamos el título ingresado con cada elemento de la lista
                // Usamos StringComparison.OrdinalIgnoreCase para ignorar mayúsculas y minúsculas
                if (item.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Si encontramos el título, retornamos "true"
                }
            }
            return false; // Si no encontramos el título, retornamos "false"
        }

        static void Main()
        {
            // Creamos una lista de strings para almacenar los títulos de las revistas
            List<string> catalogoRevistas = new List<string>();

            // Solicitamos al usuario que ingrese 10 títulos de revistas
            Console.WriteLine("Ingrese 10 títulos de revistas:");

            // Bucle for que se repite 10 veces para ingresar los títulos
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Título {i}: "); // Muestra "Título 1", "Título 2", etc.
                string titulo = Console.ReadLine(); // Capturamos el título ingresado por el usuario
                catalogoRevistas.Add(titulo); // Lo añadimos a la lista de revistas
            }

            // Variable para controlar si el programa debe seguir ejecutándose
            bool salir = false;

            // Bucle while que se repetirá hasta que el usuario elija salir
            while (!salir)
            {
                // Mostramos el menú con las opciones disponibles
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Buscar un título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                // Leemos la opción seleccionada por el usuario
                int opcion = int.Parse(Console.ReadLine());

                // Estructura switch para manejar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        // Si el usuario selecciona la opción 1, se busca un título
                        Console.Write("Ingrese el título a buscar: "); // Pedimos el título
                        string tituloBuscar = Console.ReadLine(); // Lo leemos

                        // Llamamos a la función BuscarTitulo para buscar el título
                        bool encontrado = BuscarTitulo(catalogoRevistas, tituloBuscar);

                        // Mostramos el resultado de la búsqueda según el valor de la variable 'encontrado'
                        if (encontrado)
                        {
                            Console.WriteLine("Resultado de la búsqueda: encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Resultado de la búsqueda: no encontrado");
                        }
                        break;

                    case 2:
                        // Si el usuario selecciona la opción 2, se cambia 'salir' a true y termina el bucle
                        salir = true;
                        break;

                    default:
                        // Si el usuario ingresa una opción no válida, se muestra este mensaje
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
