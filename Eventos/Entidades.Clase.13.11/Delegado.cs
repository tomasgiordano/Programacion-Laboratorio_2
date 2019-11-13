using Entidades.Clase._13._11;
public delegate void LimiteSueldoDelegado(double sueldo,Empleado empleado);
public delegate void LimiteSueldoMejoradoDel(Empleado e, EmpleadoEventArgs sender);

public enum TipoManejador
{
    LimiteSueldo,LimiteSueldoMejorado,Todos
}