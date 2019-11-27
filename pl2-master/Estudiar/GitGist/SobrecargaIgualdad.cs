// El operador == entre Equipo y Jugador informará true si esa instancia de Jugador ya se encuentra agregada al equipo.

public static bool operator ==(Equipo e, Jugador j)
{
  return e.jugadores.Contains(j);
}

public static bool operator !=(Equipo e, Jugador j)
{
  return !(e == j);
}