using System;
//generador de matriz con numeros par ingresados
class Programa
{
    static void Main()
    {
        Random random = new Random();  
        int N;

        do
        {
            Console.Write("Ingrese un número par para el tamaño de la matriz: ");
            N = Convert.ToInt32(Console.ReadLine());
        } while (N % 2 != 0);  

       
        int[,] matriz = new int[N, N];                 

        matriz[0, 0] = random.Next(1, 101);            
        matriz[0, N - 1] = random.Next(1, 101);        
        matriz[N - 1, 0] = random.Next(1, 101);        
        matriz[N - 1, N - 1] = random.Next(1, 101);

        int esquina1 = matriz[0, 0];        
        int esquina2 = matriz[0, N - 1];    
        int esquina3 = matriz[N - 1, 0];    
        int esquina4 = matriz[N - 1, N - 1];


        for (int i = 0; i < N; i++)         //generacion de filas de la matriz
        {
            for (int j = 0; j < N; j++)             //generacion de las columnas de la matriz
            {
                if (!((i == 0 && j == 0) || (i == 0 && j == N - 1) || (i == N - 1 && j == 0) || (i == N - 1 && j == N - 1)))
                {
                    matriz[i, j] = 0;
                }
            }
        }

        
        Console.WriteLine("\nMatriz NxN:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j].ToString("D3") + " ");  
            }
            Console.WriteLine();  
        }
        int sumaEsquinas = esquina1 + esquina2 + esquina3 + esquina4;
        int multiplicacionEsquinas = esquina1 * esquina2 * esquina3 * esquina4;

        Console.WriteLine($"\nResultado de la suma de las esquinas: {sumaEsquinas}");
        Console.WriteLine($"Resultado de la multiplicación de las esquinas: {multiplicacionEsquinas}");
    
    }
}