namespace Entidades
{
    public abstract class ClaseAbstracta
    {
      #region Atributos
      
      private string cadena;
      private int entero;
      private float flotante;
      
      #endregion
      
      #region Propiedades
      
      public string Cadena
      {
        get{return this.cadena;}
        set{this.cadena = value;}
      }
      public int Entero
      {
        get{return this.entero;}
        set{this.entero = value;}
      }
      public float Flotante
      {
        get{return this.entero;}
        set{this.entero = value;}
      }      
      
      #endregion
      
      #region Constructores
      
      public ClaseAbstracta(string cadena, int entero, float flotante){
        this.cadena = cadena;
        this.entero = entero;
        this.flotante = flotante;
      }
      
      #endregion
      
      #region Métodos
      
      public virtual string Mostrar(){
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("\nCadena: {0}", this.Cadena);
        sb.AppendFormat("\nEntero: {0}", this.Entero);
        sb.AppendFormat("\nFlotante: {0}", this.Flotante);
        return sb.ToString();
      }
      
      public virtual bool ValidarAlgo()
      {
        return true;
      }
      
      #endregion

    }
}      