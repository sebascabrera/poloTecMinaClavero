Console.WriteLine("Ingrese la longitud de vector: ");
int n = int.Parse(Console.ReadLine());


int [] vector = new int [n];


for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese valor:");
    int valor = int.Parse(Console.ReadLine());
    vector[i] = valor;
}
foreach(int i in vector)
{
    Console.Write( $" {i} \t");
}