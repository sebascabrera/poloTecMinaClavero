Console.Write("Ingrese numero de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese numero de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];
// Cargar la matriz
for (int i = 0; i < filas; i++)  // recorre filas 
{
    Console.WriteLine();
    Console.Write($"Para valor/es de fila: {i + 1}");
    Console.WriteLine();
    for (int j = 0; j < columnas; j++) // recorre columnas
    {
        Console.Write($"Ingrese valor/es de columna {j + 1}: ");
        int valor = int.Parse(Console.ReadLine());
        numeros[i, j] = valor;
    }
    Console.WriteLine();
}
// mostrar
Console.WriteLine("Los valores son:");
for (int i = 0; i < filas; i++)  // recorre filas 
{
    for (int j = 0; j < columnas; j++) // recorre columnas
    {
        Console.Write($"{numeros[i, j]:00} ");
    }
    Console.WriteLine(); // para espacio cuando termina el bucle interno
}

// para promedio -- primero se para en columna y de ahi recorre cuantas filas tiene

double[] promedios = new double[columnas];

for (int j = 0; j < columnas; j++)
{
    double suma = 0;
    for (int i = 0; i < filas; i++)
    {
        suma += numeros[i, j];  // valor de suma (+) lo que tiene la matriz en esa posicion
    }
    promedios[j] = suma / filas;  // cuando sale del bucle ya tengo la suma-- puedo calcular el promedio para guardarlo en el vector ordenado por columna 
    // por eso la j en el indice.

}

Console.WriteLine();
Console.WriteLine("Los promedios son:");
for (int i = 0; i < columnas; i++)
{
    Console.WriteLine($"columna {i+1}: {promedios[i]:00}\t");
}
