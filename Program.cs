using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace BillingSystem
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");

                // 1) Entrada (usa InputHandler)
                string producto = InputHandler.ReadProductName();
                if (!InputHandler.TryReadPrice(out decimal precioBase)) return;
                if (!InputHandler.TryReadCustomerType(out int tipoCliente)) return;

                // 2) Lógica (usa Calculator)
                if (!Calculator.TryGetDiscountPercentage(tipoCliente, out decimal descuentoPorcentaje))
                {
                    Console.WriteLine("Error: Tipo de cliente no válido.");
                    return;
                }

                decimal precioConDescuento;
                decimal igv;
                decimal precioFinal = Calculator.ApplyDiscountAndTax(
                    precioBase, descuentoPorcentaje, out precioConDescuento, out igv
                );

                // 3) Salida formateada
                Console.WriteLine("\n=== RESUMEN DE COMPRA ===");
                Console.WriteLine($"Producto: {producto}");
                Console.WriteLine($"Precio base: S/ {precioBase:F2}");
                Console.WriteLine($"Descuento aplicado: {descuentoPorcentaje * 100}%");
                Console.WriteLine($"Precio con descuento: S/ {precioConDescuento:F2}");
                Console.WriteLine($"IGV (18%): S/ {igv:F2}");
                Console.WriteLine($"Precio final a pagar: S/ {precioFinal:F2}");
            }
        }
    }

}
    }
}
