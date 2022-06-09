
Console.Write("Ingrese numero de filas: ");
int filas = int.Parse( Console.ReadLine());
Console.WriteLine();
Console.Write("Ingrese numero de columnas: ");
int columnas = int.Parse( Console.ReadLine());
Console.WriteLine();

int[,] numeros = new int[filas, columnas];
//double[] promedio = new double[];

for (int i = 0; i < filas; i++)
{
    Console.Write($"valores de fila: {i +1}");
        Console.WriteLine();
    for(int j = 0; j < columnas; j++)
    {
        Console.Write($"Ingrese valor {j + 1} de columna{j + 1}: ");
        int valor = int.Parse( Console.ReadLine());
        numeros[i,j] = valor;    
    }
    Console.WriteLine();
}
