public class Calculadora
{
    public double resultado;
    public Calculadora(double valorInicial)
    {
        resultado = valorInicial;
    }
    public void Suma(double valor)
    {
        resultado += valor;
    }
    public void Resta(double valor)
    {
        resultado -= valor;
    }
    public void Multiplicar(double valor)
    {
        resultado = resultado*valor;
    }
    public void Dividir(double valor)
    {
        if(valor!=0){
            resultado = resultado/valor;
        }else{
            Console.WriteLine("no se puede dividir en 0");
        }
    }

}
