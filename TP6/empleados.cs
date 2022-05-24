public class Empleado
{
    public DateTime fechaNacimiento;
    public char estadoCivil;
    public char genero;
    public DateTime fechaIngreso;
    public double sueldo;

    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public enum cargos
    { 
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    //para asignarlo cargos cargoEmpleado = cargos.Especialista;
}