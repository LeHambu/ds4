internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;

        Console.WriteLine("Ingrese el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos op = new CalculosMatematicos(primerNumero, segundoNumero);

        Console.WriteLine("El resultado de la operacion es: " + op.Calcular());
    }

    public class CalculosMatematicos
    {
        private int n1;
        private int n2;
        private int n3;

        public CalculosMatematicos(int N1, int N2)
        {
            n1 = N1;
            n2 = N2;
        }

        public int Calcular()
        {
            n3 = (n1 + n2) * (n1 - n2);
            return n3;
        }
    }
}