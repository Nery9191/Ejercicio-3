Console.WriteLine("Ingrese el primer numero");
Double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
Double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Elige una operacion: Suma, Resta, Multiplicacion, Division");
String operacion = Console.ReadLine().ToLower();
double resultado = 0;

switch (operacion)
{
    case "suma":
        resultado = n1 + n2;
        Console.WriteLine($"La suma es: {resultado}");
        break;
    case "resta":
        resultado = n1 - n2;
        Console.WriteLine($"La resta es: {resultado}");
        break;
    case "multiplicacion":
        resultado = n1 * n2;
        Console.WriteLine($"La multiplicacion es: {resultado}");
        break;
    case "division":
        resultado = n1 / n2;
        Console.WriteLine($"La division es: {resultado}");
        break;
    default:
        Console.WriteLine("Operacion no valida");
        break;
}

Console.WriteLine($"El resultado es: {resultado}");
