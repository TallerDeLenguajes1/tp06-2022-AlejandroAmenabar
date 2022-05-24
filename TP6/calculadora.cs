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
        resultado = resultado/valor;
    }

}
