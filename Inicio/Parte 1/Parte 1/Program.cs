
using System;

namespace BillingSystem
{
    // Encargado de leer y validar entradas del usuario
    public static class InputHandler
    {
        public static string ReadProductName()
        {
            Console.Write("Ingrese el nombre del producto: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public static bool TryReadPrice(out decimal precioBase)
        {
            Console.Write("Ingrese el precio base del producto: ");
            if (!decimal.TryParse(Console.ReadLine(), out precioBase) || precioBase <= 0)
            {
                Console.WriteLine("Error: El precio ingresado no es válido.");
                return false;
            }
            return true;
        }

        public static bool TryReadCustomerType(out int tipoCliente)
        {
            Console.WriteLine("Tipo de cliente: 1=Frecuente, 2=Nuevo, 3=Corporativo");
            Console.Write("Ingrese el tipo de cliente: ");
            if (!int.TryParse(Console.ReadLine(), out tipoCliente))
            {
                Console.WriteLine("Error: Debe ingresar un número entero (1, 2 o 3).");
                return false;
            }
            return true;
        }
    }
}
