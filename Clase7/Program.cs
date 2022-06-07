Console.WriteLine("Ingrese 10 numeros!");
int[] numeros = new int[10];
int suma=0;

int mayor=0;
int menor=0;


for (int i=0; i<numeros.Length; i++)
{

    Console.WriteLine($"ingrese numero {i + 1}: ");
   numeros [i] = int.Parse(Console.ReadLine()) ;
     suma += numeros[i];
    
    if (mayor ==0)
    {
        mayor = numeros[i];
        menor = numeros[i];
    }
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine("Los numeros ingresados son:");
foreach (int valor in numeros)
{
   Console.WriteLine($"{valor}");
}
Console.WriteLine($"la suma es {suma}");
Console.WriteLine($"El promedio es {suma/10}");
Console.WriteLine($"El mayor es {mayor}");
Console.WriteLine($"El menor es {menor}");