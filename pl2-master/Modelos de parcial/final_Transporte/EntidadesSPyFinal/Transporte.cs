namespace EntidadesSPyFinal
{
    public abstract class Transporte
    {
        private EFabricante fabricante;
        protected int velocidad;

        #region Propiedades
        public EFabricante Fabricante
        {
            get { return this.fabricante; }
            set { this.fabricante = value; }
        }

        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }

        #endregion

        #region Constructor

        public Transporte(EFabricante fabricante, int velocidad)
        {
            this.Velocidad = velocidad;
            this.Fabricante = fabricante;
        }

        #endregion


        public abstract string Transportar(Transporte transporte);

    }
}
