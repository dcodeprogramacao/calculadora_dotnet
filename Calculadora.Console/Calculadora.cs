namespace Calculadora.Console;

public class Calculadora
{
    public double Dividir(double valor1, double valor2) {
        if (valor2 == 0) {
            System.Console.WriteLine("Divisão por zero não aceita");
            return 0;
        }
        
        return valor1 / valor2;
    }
}
