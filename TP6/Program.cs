// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Empleado empleado = new Empleado();

void cargarEmpleado(Empleado empleado)
{
    Console.WriteLine("Ingrese Nombre y Apellido ");
    empleado.Nombre = Console.ReadLine();

    empleado.Apellido  = Console.ReadLine();

    empleado.fechaNacimiento = new DateTime(1990,3,14); //hacer random

    Console.WriteLine("Estado Civil? S- soltero, C-casado");
    empleado.estadoCivil = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Genero? H-Hombre M-Mujer O- Otro");
    empleado.genero = Convert.ToChar(Console.ReadLine());

    empleado.fechaIngreso = new DateTime(2012,12,12); //hacer random

    Console.WriteLine("Ingrese su sueldo");
    empleado.sueldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Cual es su cargo en la empresa? 1-Auxiliar, 2-Administrativo, 3-Ingeniero, 4-Especialista, 5-Investigador");
    empleado.cargo = cargos.Administrativo; //swithc que recba un numero y de ahi hacer cada caso 

}

int antiguedad = empleado.Antiguedad(empleado.fechaIngreso);
Console.WriteLine("El empleado tiene:" +antiguedad+ "de antiguedad");

//para asignarlo cargos cargoEmpleado = cargos.Especialista;
