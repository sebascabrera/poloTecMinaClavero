Console.WriteLine("Ingrese la longitud de vector: ");
int n = int.Parse(Console.ReadLine());


int [] vector = new int [n];
int j = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese valor:");
    int valor = int.Parse(Console.ReadLine());
    vector[i] = valor;
    j++;
}
Console.WriteLine("Los valores del vector son:");
foreach (int i in vector)
{
        Console.Write( $" {i} \t");
}
//Reverse().ToArray(); herramienta de C#
Console.WriteLine();

for (int i = j; i > 0; i--)
{
    int aux = vector[vector.Length - i];
    vector[i-1] = aux;
   }

Console.WriteLine("Los valores del vector son:");
foreach (int i in vector)
{

    Console.Write($" {i} \t");

}
Console.ReadKey();