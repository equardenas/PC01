#region Menú Principal

bool salir = false;

while (!salir)                                                      
{
    Console.WriteLine("");
    Console.WriteLine("*****************************************************");
    Console.WriteLine("==> MENÚ PRINCIPAL ======");
    Console.WriteLine("*****************************************************");
    Console.WriteLine("1. Números Positivos o Negativos");
    Console.WriteLine("2. Día de la Semana");
    Console.WriteLine("3. Suma de los primeros 100 números naturales");
    Console.WriteLine("4. Números desde 1 hasta número 'N'");
    Console.WriteLine("5. Área de un Círculo");
    Console.WriteLine("6. Arreglo Unidimensional");
    Console.WriteLine("7. Nombres de personas en Listas");
    Console.WriteLine("8. Salir");
    Console.WriteLine("*****************************************************");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            OpcionNumerosPositivosONegativos();
            break;
        case "2":
            OpcionDiaDeLaSemana();
            break;
        case "3":
            OpcionSumaPrimeros100Numeros();
            break;
        case "4":
            OpcionNumerosHastaN();
            break;
        case "5":
            OpcionAreaDeCirculo();
            break;
        case "6":
            OpcionArregloUnidimensional();
            break;
        case "7":
            OpcionListaDeNombres();
            break;
        case "8":
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }

    Console.WriteLine();
}

#endregion


#region Opción 1: Números Positivos o Negativos

void OpcionNumerosPositivosONegativos()
{
    Console.Write("Ingrese un número: ");
    if (float.TryParse(Console.ReadLine(), out float numero))
    {
        string resultado = DeterminarSigno(numero);
        Console.WriteLine(resultado);
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor ingrese un número válido.");
    }
}

string DeterminarSigno(float numero)
{
    if (numero > 0)
    {
        return $"El número {numero} es positivo.";
    }
    else if (numero < 0)
    {
        return $"El número {numero} es negativo.";
    }
    else
    {
        return "El número es cero.";
    }
}

#endregion

#region Opción 2: Día de la Semana

 void OpcionDiaDeLaSemana()
{
    Console.Write("Ingrese un número del 1 al 7 (1 = Lunes, 7 = Domingo): ");
    if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 7)
    {
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        Console.WriteLine($"El día correspondiente es: {dias[dia - 1]}");
    }
    else
    {
        Console.WriteLine("Número no válido. Debe ingresar un número entre 1 y 7.");
    }
}

#endregion

#region Opción 3: Suma de los primeros 100 números naturales

void OpcionSumaPrimeros100Numeros()
{
    int suma = CalcularSumaPrimeros100();
    Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");
}

int CalcularSumaPrimeros100()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma += i;
    }
    return suma;
}

#endregion

#region Opción 4: Números desde 1 hasta número 'N'

void OpcionNumerosHastaN()
{
    Console.Write("Ingrese un número 'N': ");
    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Número no válido. Debe ingresar un número mayor que 0.");
    }
}

#endregion

#region Opción 5: Área de un Círculo

void OpcionAreaDeCirculo()
{
    Console.Write("Ingrese el radio del círculo: ");
    if (float.TryParse(Console.ReadLine(), out float radio) && radio > 0)
    {
        float area = CalcularAreaDeCirculo(radio);
        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor ingrese un número positivo.");
    }
}

float CalcularAreaDeCirculo(float radio)
{
    return (float)(Math.PI * Math.Pow(radio, 2));
}


#endregion

#region Opción 6: Arreglo Unidimensional

void OpcionArregloUnidimensional()
{
    Console.Write("Ingrese el tamaño del arreglo: ");
    if (int.TryParse(Console.ReadLine(), out int tamano) && tamano > 0)
    {
        int[] arreglo = new int[tamano];
        for (int i = 0; i < tamano; i++)
        {
            Console.Write($"Ingrese un número para la posición {i + 1}: ");
            string entrada = Console.ReadLine();

            // Validar la entrada para evitar errores de formato
            if (int.TryParse(entrada, out int numero))
            {
                arreglo[i] = numero;
            }
            else
            {
                Console.WriteLine($"'{entrada}' no es un número válido. Se asignará 0 en su lugar.");
                arreglo[i] = 0;
            }
        }

        Console.WriteLine("El arreglo ingresado es:");
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Tamaño no válido. Debe ser un número entero positivo.");
    }
}

#endregion

#region Opción 7: Nombres de personas en Listas
                                                                                                                                                                                
void OpcionListaDeNombres()
{
    List<string> nombres = new List<string>();
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Ingrese el nombre {i + 1}: ");
        nombres.Add(Console.ReadLine());
    }

    Console.WriteLine("Los nombres ingresados son:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}

#endregion