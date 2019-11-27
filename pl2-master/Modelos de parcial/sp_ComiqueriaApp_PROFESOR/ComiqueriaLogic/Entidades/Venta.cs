using System;

namespace ComiqueriaLogic
{
    [Serializable]
    public sealed class Venta
    {
        private static int porcentajeIva;
        private DateTime fecha;
        private Producto producto;
        private double precioFinal;
        private int cantidad;

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        public Venta()
        {

        }

        internal Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.Vender(cantidad);
        }

        public static int PorcentajeIva
        {
            get
            {
                return Venta.PorcentajeIva;
            }
            set
            {
                Venta.PorcentajeIva = porcentajeIva;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public double PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
            set
            {
                this.precioFinal = value;
            }
        }

        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);        
        }
        
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioSinIva = precioUnidad * cantidad;
            return precioSinIva + precioSinIva * Venta.porcentajeIva / 100;
        }

        public string ObtenerDescripcionBreve()
        {
            return String.Format("{0} - {1} - {2}", this.fecha, this.producto.Descripcion, this.precioFinal.FormatearPrecio());
        }        
    }
}
