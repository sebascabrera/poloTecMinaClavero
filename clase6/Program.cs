int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

int numeroUsuario = 0;
int i= 0;

for ( i = 0; numeroUsuario != numeroSecreto; i++) {
    Console.Write("Intente adivinar numero secreto.\n Ingrese numero: ");
    numeroUsuario = int.Parse(Console.ReadLine());


    if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El numero que ingreso es mayor que nuestro numero secreto\nIntente nuevamente\n");

    }
    else if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("El numero que ingreso es menor que nuestro numero secreto\nIntente nuevamente\n");
   
    } 
 
}
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: { numeroSecreto }\n ");
Console.WriteLine($"Lo has logrado en {i} intentos !!");
