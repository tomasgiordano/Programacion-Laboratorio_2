//En clase abastracta:


/// El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
///(utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
///origen son iguales en ambas llamadas.

public static bool operator ==(Llamada l1, Llamada l2)
{

  if(!l1.Equals(l2))
  {
    return false;
  }
  
  else if (l1.NroOrigen != l2.NroOrigen)
  {
    return false;
  }
  
  else
  {
    return (l1.NroDestino != l2.NroDestino);
  }
  
}

public static bool operator !=(Llamada l1, Llamada l2)
{
    return !(l1 == l2);
}

/// EN LAS CLASES DERIVADAS:

//LOCAL
public override bool Equals(object obj)
{
  return (obj.GetType() == typeof(Local));
}

//PROVINCIAL
public override bool Equals(object obj)
{
  return (obj.GetType() == typeof(Provincial));
}
