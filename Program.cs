//Programa de operaciones basicas 
Console.WriteLine ("Ingrese el primer número:");
int num1= 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
int num2 =
Convert.ToInt32(Console.ReadLine());

// Programa de operaciones básicas
Console.WriteLine("Ingrese el primer número:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int num2 = Convert.ToInt32(Console.ReadLine());

// Codigo para seleccionar la operación
Console.WriteLine("Seleccione la operación:");
Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");

//codigo para leer la opción
string opcion = Console.ReadLine();
switch (opcion)
{
    case "1":
        Console.WriteLine("Resultado: " + (num1 + num2));
        break;
    case "2":
        Console.WriteLine("Resultado: " + (num1 - num2));
        break;
    case "3":
        Console.WriteLine("Resultado: " + (num1 * num2));
        break;
    case "4":
        if (num2 != 0)
            Console.WriteLine("Resultado: " + ((double)num1 / num2));
        else
            Console.WriteLine("Error: No se puede dividir entre cero.");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

Console.WriteLine("Fin del programa.");
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();