
Console.Write("Ingrese numero de filas: ");
int filas = int.Parse( Console.ReadLine());
Console.WriteLine();
Console.Write("Ingrese numero de columnas: ");
int columnas = int.Parse( Console.ReadLine());
Console.WriteLine();

int[,] numeros = new int[filas, columnas];
double suma = 0;
double[] promedios = new double[columnas];

for (int i = 0; i < filas; i++)
{
    Console.WriteLine();
    Console.Write($"Para valor/es de fila: {i +1}");
    Console.WriteLine();
    for(int j = 0; j < columnas; j++)
    {
        Console.Write($"Ingrese valor/es de columna {j + 1}: ");
        int valor = int.Parse( Console.ReadLine());
        numeros[i,j] = valor;
     }
    Console.WriteLine();
}
Console.WriteLine("Los valores son");
for (int i = 0; i < filas; i++)
{
   for (int j = 0; j < columnas; j++)
    {
        Console.Write($"{numeros[i,j]:0000}\t");
     }
    Console.WriteLine();
}
Console.WriteLine();




for (int i = 0; i < columnas; i++)
{
    for (int j = 0; j < filas; j++)
    {
        suma =+ numeros[j, i];
    }
    promedios[i] = suma / filas;
}
Console.WriteLine();
Console.WriteLine("Los promedios son:");
for(int i = 0; i < columnas; i++)
{
    Console.WriteLine($"{promedios[i]}");
}
