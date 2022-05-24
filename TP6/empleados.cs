public enum cargos
{ 
    Auxiliar=1,
    Administrativo=2,
    Ingeniero=3,
    Especialista=4,
    Investigador=5
}
public class Empleado
{
    public DateTime fechaNacimiento;
    public char estadoCivil;
    public char genero;
    public DateTime fechaIngreso;
    public double sueldo;
    public cargos cargo;
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    
    public int Antiguedad(DateTime fechaIngreso)
    {
        DateTime Actual = DateTime.Today;
        int añosAntiguedad = Convert.ToInt32(Actual.Year - fechaIngreso.Year);
        return añosAntiguedad;
    }
}
