using System;

Calculadora calculadora = new Calculadora();
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("          CALCULADORA");
    Console.WriteLine("                        ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Verificar aprobación");
    Console.WriteLine("6. Salir");
    Console.WriteLine();
    Console.Write("Seleccione una opción: ");

    string opcionSeleccionada = Console.ReadLine();

    try
    {
        switch (opcionSeleccionada)
        {
            case "1":
                {
                    double primerNumero = PedirNumero("Digite el primer número: ");
                    double segundoNumero = PedirNumero("Digite el segundo número: ");

                    double resultado = calculadora.Sumar(primerNumero, segundoNumero);

                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                }

            case "2":
                {
                    double primerNumero = PedirNumero("Digite el primer número: ");
                    double segundoNumero = PedirNumero("Digite el segundo número: ");

                    double resultado = calculadora.Restar(primerNumero, segundoNumero);

                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                }

            case "3":
                {
                    double primerNumero = PedirNumero("Digite el primer número: ");
                    double segundoNumero = PedirNumero("Digite el segundo número: ");

                    double resultado = calculadora.Multiplicar(primerNumero, segundoNumero);

                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                }

            case "4":
                {
                    double primerNumero = PedirNumero("Digite el primer número: ");
                    double segundoNumero = PedirNumero("Digite el segundo número: ");

                    double resultado = calculadora.Dividir(primerNumero, segundoNumero);

                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                }

            case "5":
                {
                    double notaEstudiante = PedirNumero("Ingrese la nota del estudiante: ");

                    Console.WriteLine(calculadora.VerificarAprobacion(notaEstudiante));
                    break;
                }

            case "6":
                {
                    salir = true;
                    Console.WriteLine("Gracias por utilizar el programa.");
                    break;
                }

            default:
                {
                    Console.WriteLine("La opción seleccionada no es válida.");
                    break;
                }
        }
    }
    catch (Exception error)
    {
        Console.WriteLine("Ocurrió un error: " + error.Message);
    }

    if (!salir)
    {
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}

double PedirNumero(string mensaje)
{
    double numeroIngresado;

    while (true)
    {
        Console.Write(mensaje);

        if (double.TryParse(Console.ReadLine(), out numeroIngresado))
        {
            return numeroIngresado;
        }

        Console.WriteLine("Entrada no válida. Intente nuevamente.");
    }
}

class Calculadora { 

    public double Sumar(double primerNumero, double segundoNumero)
    {
        return primerNumero + segundoNumero;
    }

    public double Restar(double primerNumero, double segundoNumero)
    {
        return primerNumero - segundoNumero;
    }

    public double Multiplicar(double primerNumero, double segundoNumero)
    {
        return primerNumero * segundoNumero;
    }

    public double Dividir(double primerNumero, double segundoNumero)
    {
        if (segundoNumero == 0)
        {
            throw new Exception("No se puede dividir entre cero.");
        }

        return primerNumero / segundoNumero;
    }

    public string VerificarAprobacion(double nota)
    {
        if (nota >= 70)
        {
            return "El estudiante aprobó.";
        }

        return "El estudiante reprobó.";
    }
}