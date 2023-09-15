Console.Write("Ingrese la cantidad de numeros a sumar: ");
int limite = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = 1; i <= limite; i++)
{
    Console.Write("Ingrese el numero "+i+": ");
    int numero = int.Parse(Console.ReadLine());
    suma = suma + numero;
}
Console.WriteLine("la suma es: "+suma);
Console.ReadLine();