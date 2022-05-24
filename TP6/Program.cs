// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora calc = new Calculadora(0);


Console.WriteLine(calc.resultado);

int opcion=10;
int menu=2,valor;

do
{
    Console.WriteLine("elija el valor a utilizar");
    valor = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("elija la operacion a realizar");
    Console.WriteLine("1-Sumar 2-Restar 3-Multiplicar 4-Dividir 5-Limpiar");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            calc.Suma(valor);
            break;
        case 2:
            calc.Resta(valor);
            break;
        case 3:
            calc.Multiplicar(valor);
            break;
        case 4:
            if(valor!=0){
                calc.Dividir(valor);
            }else{
                Console.WriteLine("ERROR! Para dividir dos numeros el segundo debe ser distinto de cero");
            }
            break;
        case 5: 
            calc.resultado=0;
            break;
        default:
            Console.WriteLine("debe ingresar una opcion valida");
            break;
    }
    Console.WriteLine("El resultado es: " + calc.resultado);
    Console.WriteLine("Desea realizar otra operacion 1-Si 0-No");
    menu = Convert.ToInt32(Console.ReadLine());
} while (menu!=0);
