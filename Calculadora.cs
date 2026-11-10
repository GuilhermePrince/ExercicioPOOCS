
namespace ListaExPOO
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a+b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static decimal Dividir(decimal a, decimal b)
        {
            if(b == 0)
            {
                Console.WriteLine("Divisão por 0!");
                return 0;
            }
            return a / b;
        }


    }
}