//Centralita
public void OrdenarLlamadas(){
  this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
}


//Recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2){
  if (llamada1.Duracion > llamada2.Duracion){
    return 1;
  }
  else if (llamada1.Duracion < llamada2.Duracion){
    return -1;
  }
  else{
    return 0;
  }
}