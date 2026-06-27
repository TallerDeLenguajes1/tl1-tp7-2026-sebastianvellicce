using EspacioCalculadora;

int opcion = 1;
double num;
Calculadora calc = new Calculadora();
void mostrarMenu()
{
    Console.WriteLine("################# MENU #################\n");
    Console.WriteLine("1-Sumar\n");
    Console.WriteLine("2-Restar\n");
    Console.WriteLine("3-Multiplicar\n");
    Console.WriteLine("4-Dividir\n");
    Console.WriteLine("5-Limpiar\n");
    Console.WriteLine("0-Salir\n");
}

while (opcion != 0)
{
    mostrarMenu();
    Console.WriteLine("Ingrese una opcion\n");
    opcion = int.Parse(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero\n");
            num = double.Parse(Console.ReadLine());
            calc.Sumar(num);
            break;
        case 2:
            Console.WriteLine("Ingrese el numero\n");
            num = double.Parse(Console.ReadLine());
            calc.Restar(num);
            break;

        case 3:
            Console.WriteLine("Ingrese el numero\n");
            num = double.Parse(Console.ReadLine());
            calc.Multiplicar(num);
            break;
        case 4:
            Console.WriteLine("Ingrese el numero\n");
            num = double.Parse(Console.ReadLine());
            calc.Dividir(num);
            break;
        case 5:
            calc.Limpiar();
            break;

        case 0:
            Console.WriteLine("Saliendo...\n");
            break;

        default:
            Console.WriteLine("Opcion invalida\n");
            break;
    }
    Console.WriteLine($"Resultado = {calc.Resultado}\n");
}
