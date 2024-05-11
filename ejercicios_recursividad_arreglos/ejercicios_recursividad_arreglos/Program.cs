// See https://aka.ms/new-console-template for more information
////////////////////////////////////////////////////////// ejercicios

////Ejercicio Matrices:
////Ejercicio 1:
////Crea una matriz de números aleatorios de tamaño 100x100.
//// variables
//int filas = 100;
//int columnas = 100;
//Random random = new Random();
//int[,] matriz = new int[filas, columnas];
//// algoritmo
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        matriz[i, j] = random.Next(); 
//    }
//}
////resultado
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

////Ejercicio 2:
////Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.
//// variables
//int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };
//double media = matriz.Cast<int>().Average();

//int[] elementosOrdenados = matriz.Cast<int>().OrderBy(x => x).ToArray();
//double mediana;
////algoritmo
//if (elementosOrdenados.Length % 2 == 0)
//{
//    mediana = (elementosOrdenados[elementosOrdenados.Length / 2 - 1] + elementosOrdenados[elementosOrdenados.Length / 2]) / 2.0;
//}
//else
//{
//    mediana = elementosOrdenados[elementosOrdenados.Length / 2];
//}
//double mediaCuadratica = matriz.Cast<int>().Select(x => Math.Pow(x - media, 2)).Average();
//double desviacionEstandar = Math.Sqrt(mediaCuadratica);
//// resultados
//Console.WriteLine("Media: " + media);
//Console.WriteLine("Mediana: " + mediana);
//Console.WriteLine("Desviación Estándar: " + desviacionEstandar);

////Ejercicio 3:
////Escribe una función que encuentre el elemento máximo de una matriz.
//using System;

//class Program
//{
//    static int FindMaxElement(int[,] matriz)
//    {
//        int maxElement = matriz[0, 0]; // Suponemos que el primer elemento es el máximo

//        // Iteramos sobre todos los elementos de la matriz para encontrar el máximo
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//            {
//                if (matriz[i, j] > maxElement)
//                {
//                    maxElement = matriz[i, j];
//                }
//            }
//        }

//        return maxElement;
//    }

//    static void Main(string[] args)
//    {
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 9, 6},
//            {7, 8, 5}
//        };

//        int maximo = FindMaxElement(matriz);
//        //resultado
//        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
//    }
//}



//Ejercicio 4:
//Escribe una función que encuentre la submatriz de mayor suma de una matriz.
//Ejercicio 5:
//Escribe una función que encuentre la matriz de covarianza de dos matrices.

//12) Calcula la media de los elementos de una matriz.


////11) Multiplica una matriz por un número.
////variables
//int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//int multiplicador = 2;

////algoritmo
//int filas = matriz.GetLength(0);
//int columnas = matriz.GetLength(1);
//int[,] matrizResultado = new int[filas, columnas];

//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        matrizResultado[i, j] = matriz[i, j] * multiplicador;
//    }
//}

//// resultado
//Console.WriteLine("Matriz Resultado:");
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write(matrizResultado[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//10) Suma dos matrices de diferentes tamaños.


//9) Accede al elemento central de una matriz.


////8) Crea una matriz de matrices.
////variables
//int rows = 3; // Número de filas
//int cols = 2; // Número de columnas
//int[][][] matrizDeMatrices = new int[rows][][];
////algoritmo
//for (int i = 0; i < rows; i++)
//{
//    matrizDeMatrices[i] = new int[cols][];
//    for (int j = 0; j < cols; j++)
//    {

//        matrizDeMatrices[i][j] = new int[2] { i + 1, j + 1 };
//    }
//}
//// resuktaddo
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write("[");
//        for (int k = 0; k < 2; k++)
//        {
//            Console.Write(matrizDeMatrices[i][j][k]);
//            if (k < 1) Console.Write(", ");
//        }
//        Console.Write("] ");
//    }
//    Console.WriteLine();
//}



////7) Crea una matriz de números complejos.
//// variables
//using System.Numerics;
//Console.Write("Ingrese el número de filas de la matriz: ");
//int filas = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ingrese el número de columnas de la matriz: ");
//int columnas = Convert.ToInt32(Console.ReadLine());
//Complex[,] matriz = new Complex[filas, columnas];
//// algoritmo
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write($"Ingrese la parte real del elemento ({i}, {j}): ");
//        double real = Convert.ToDouble(Console.ReadLine());

//        Console.Write($"Ingrese la parte imaginaria del elemento ({i}, {j}): ");
//        double imag = Convert.ToDouble(Console.ReadLine());

//        matriz[i, j] = new Complex(real, imag);
//    }
//}
//// resultado
//Console.WriteLine("Matriz de números complejos ingresada:");
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}


////Arreglos y Matrices:
////6) Crea una matriz de números reales.
////variabeles
//double[,] matriz = new double[,]
//        {
//            {1.1, 2.2, 3.3},
//            {4.4, 5.5, 6.6},
//            {7.7, 8.8, 9.9}
//        };

//// algoritmo
//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write(matriz[i, j] + "\t");
//    }
//    //resultado
//    Console.WriteLine();
//}


//// 5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n.
////algoritmo
//Func<int, int, int> PrintMultiplicationTable; // Declarar la función antes de usarla
//PrintMultiplicationTable = null;
//PrintMultiplicationTable = (n, multiplier) =>
//{
//    if (multiplier <= 10)
//    {
//        Console.WriteLine($"{n} x {multiplier} = {n * multiplier}");
//        PrintMultiplicationTable(n, multiplier + 1); // Llamada recursiva
//    }
//    return 0; // Tipo de retorno necesario para cumplir con la firma de la función
//};
////declaracion d evariables
//Console.Write("Ingresa un número para obtener su tabla de multiplicar: ");
//int n = Convert.ToInt32(Console.ReadLine());
////resultado
//Console.WriteLine($"Tabla de multiplicar del {n}:");
//PrintMultiplicationTable(n, 1); // Llamada inicial


////4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
//Console.Write("Ingresa un número: ");
//int n = Convert.ToInt32(Console.ReadLine());
//// Imprimir la pirámide de números invertidos
//for (int i = 1; i <= n; i++)
//{
//    for (int j = n; j >= i; j--)
//    {
//        Console.Write(j);
//    }
//    //RESULTADO
//    Console.WriteLine();
//}


////3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.
//Console.Write("Ingresa un número: ");
//int n = Convert.ToInt32(Console.ReadLine());
////algoritmo
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j);
//    }
//    //resultado
//    Console.WriteLine();
//}


////Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.}
////declaracion de variables
//int SumarRecursivo(int n)
////algoritmo
//{
//    if (n == 0)
//    {
//        return 0;
//    }
//    else
//    {
//        return n + SumarRecursivo(n - 1);
//    }
//}
//// Resultados
//Console.WriteLine("ingrese el numero hasta donde desea sumar: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int sum = SumarRecursivo(number);
//Console.WriteLine($"La suma desde el 1 al {number} es: {sum}");


////Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.
////declaracion de variables
//int numero = 1;
////algoritmo
//while (numero <= 100)
//{
//    if (numero % 2 == 0)
//    {
//        //resultado
//        Console.WriteLine(numero);
//    }
//    numero++;
//}

