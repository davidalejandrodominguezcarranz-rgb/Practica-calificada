using System;

namespace BillingSystem
{
    // Encargado de toda la lógica de negocio: descuentos e IGV
    public static class Calculator
    {
        // Devuelve el porcentaje de descuento (ej: 0.10m = 10%)
        public static bool TryGetDiscountPercentage(int tipoCliente, out decimal porcentaje)
        {
            porcentaje = 0m;
            switch (tipoCliente)
            {
                case 1:
                    porcentaje = 0.10m; // 10%
                    return true;
                case 2:
                    porcentaje = 0.00m; // 0%
                    return true;
                case 3:
                    porcentaje = 0.15m; // 15%
                    return true;
                default:
                    porcentaje = 0m;
                    return false;
            }
        }

        public static decimal CalculateDiscountAmount(decimal precioBase, decimal porcentaje)
        {
            return precioBase * porcentaje;
        }

        public static decimal CalculateIGV(decimal monto, decimal igvRate = 0.18m)
        {
            return monto * igvRate;
        }

        public static decimal ApplyDiscountAndTax(decimal precioBase, decimal porcentaje, out decimal precioConDescuento, out decimal igv)
        {
            decimal descuento = CalculateDiscountAmount(precioBase, porcentaje);
            precioConDescuento = precioBase - descuento;
            igv = CalculateIGV(precioConDescuento);
            return precioConDescuento + igv;
        }
    }
}