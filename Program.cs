
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
Console.WriteLine("-------------------------------------------");

//EJERCICIO 1
//solicitar numero
Console.Write("Ingrese un numero entero para invertir: ");
string entrada = Console.ReadLine();
int numero;

//verificar si lo ingresado es un numero entero
if (int.TryParse(entrada, out numero))
{
    if (numero > 0)
    {
        int numeroInvertido = 0;
        int auxiliar = numero;

        //invertir el numero
        while (auxiliar > 0)
        {
            int ultimoDigito = auxiliar % 10;
            numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
            auxiliar = auxiliar / 10;
        }
        //mostrar resultado por pantalla
        Console.WriteLine($"El numero invertido es: {numeroInvertido}");
    }
    else
    {
        Console.WriteLine("El numero ingresado de ser mayor que cero");
    }
}
else
{
    Console.WriteLine("Error. Lo ingresado no es un numero entero");
}

Console.WriteLine("\n-------------------------------------------");

//EJERCICIO 2
string continuar = "";
do
{
    Console.WriteLine("====MENU DE CALCULADORA====");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    string opcion = Console.ReadLine();

    //validamos la opcion del usuario
    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
    {
        //pedimos y validamos el primer numero
        Console.Write("Ingrese el primer numero: ");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Ingrese el segundo numero: ");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                double resultado = 0;

                switch (opcion)
                {
                    case "1":
                        resultado = numero1 + numero2;
                        Console.WriteLine($"Resultado de la suma {resultado}");
                        break;

                    case "2":
                        resultado = numero1 - numero2;
                        Console.WriteLine($"Resultado de la resta {resultado}");
                        break;

                    case "3":
                        resultado = numero1 * numero2;
                        Console.WriteLine($"Resultado de la multiplicacion {resultado}");
                        break;

                    case "4":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"Resultado de la division {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error.No se puede realizar la division en cero");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error.Lo ingresado no es un numero");
            }
        }
        else
        {
            Console.WriteLine("Error. Lo ingresado no es un numero");
        }
    }
    else
    {
        Console.WriteLine("No es una opcion valida de menu");
    }
    Console.Write("\n Desea hacer otro calculo? (S:Si/N:No): ");
    continuar = Console.ReadLine().ToUpper();
} while (continuar == "S");

/*EJERCICIO 4*/
Console.Clear();
/*pedir la cedena de texto*/
Console.Write("Ingrese un texto: ");
string cadenaPrincipal = Console.ReadLine();

/*tener la longitud de la cadena */
int longitud = cadenaPrincipal.Length;
Console.WriteLine($"La longitud de la cadena es: {longitud}");

/*pedir segunda cadena de texto*/
Console.Write("Ingrese otro texto: ");
string segundaCadena = Console.ReadLine();

/*concatenar ambas cadenas*/
string cadenaConcatenada = $"{cadenaPrincipal}{segundaCadena}";
Console.WriteLine($"cadena concatenada: {cadenaConcatenada}");

/*extraer una subcadena*/
if (cadenaPrincipal.Length >= 7)
{
    string subCadena = cadenaPrincipal.Substring(2);
    Console.WriteLine($"subcadena extraida: {subCadena}");
}
else
{
    Console.WriteLine("Error. No es posible obtener unasubcadena");
}
/*SEGUNDA PARTE DEL EJERCICIO*/
Console.WriteLine("====MENU DE CALCULADORA====");
Console.WriteLine("1.Sumar");
Console.WriteLine("2.Restar");
Console.WriteLine("3.Multiplicar");
Console.WriteLine("4.Dividir");
string opciones = Console.ReadLine();

//validamos la opcion del usuario
if (opciones == "1" || opciones == "2" || opciones == "3" || opciones == "4")
{
    //pedimos y validamos el primer numero
    Console.Write("Ingrese el primer numero: ");
    if (double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.Write("Ingrese el segundo numero: ");
        if (double.TryParse(Console.ReadLine(), out double num2))
        {
            double resultados = 0;

            switch (opciones)
            {
                case "1":
                    resultados = num1 + num2;
                    Console.WriteLine($"La suma entre {num1.ToString()} y {num2.ToString()} es igual a {resultados.ToString()}");
                    break;

                case "2":
                    resultados = num1 - num2;
                    Console.WriteLine($"La resta entre {num1.ToString()} y {num2.ToString()} es igual a {resultados.ToString()}");
                    break;

                case "3":
                    resultados = num1 * num2;
                    Console.WriteLine($"La multiplicacion entre {num1.ToString()} y {num2.ToString()} es igual a {resultados.ToString()}");
                    break;

                case "4":
                    if (num2 != 0)
                    {
                        resultados = num1 / num2;
                        Console.WriteLine($"La division entre {num1.ToString()} y {num2.ToString()} es igual a {resultados.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine("Error.No se puede realizar la division en cero");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error.Lo ingresado no es un numero");
        }
    }
    else
    {
        Console.WriteLine("Error. Lo ingresado no es un numero");
    }
}
else
{
    Console.WriteLine("No es una opcion valida de menu");
}

/*recorrer cadena*/
foreach (char letra in cadenaPrincipal)
{
    Console.Write($"[{letra}] ");
}
Console.WriteLine();

/*buscar la ocurrencia de una palabra*/
Console.Write("Ingrese la palabra que desea buscar: ");
string palabraBuscada = Console.ReadLine();
if (cadenaPrincipal.Contains(palabraBuscada))
{
    Console.WriteLine($"la palabra {palabraBuscada} si se encuentra en el texto");
}
else
{
    Console.WriteLine($"la palabra {palabraBuscada} no se encuentra en el texto");
}

/*convertir la cadena a mayusculas y minusculas*/
Console.WriteLine($"texto en mayusculas: {cadenaPrincipal.ToUpper()}");
Console.WriteLine($"texto en minusculas: {cadenaPrincipal.ToLower()}");

/*cadena separada por un determinado elemento*/
Console.Write("Ingrese una serie de palabras separadas por comas(,): ");
string cadenaSeparada = Console.ReadLine();
string[] palabrasSeparadas = cadenaSeparada.Split(',');
foreach (string elemento in palabrasSeparadas)
{
    Console.Write($" - {elemento.Trim()}");
}
Console.WriteLine();

/*resolver ecuacion simple*/
Console.Write("Ingrese una ecuacion simple: ");
string ecuacion = Console.ReadLine();
char operador = ' ';
if (ecuacion.Contains("+"))
{
    operador = '+';
}
else if (ecuacion.Contains("-"))
{
    operador = '-';
}
else if (ecuacion.Contains("/"))
{
    operador = '/';
}
else if (ecuacion.Contains("*"))
{
    operador = '*';
}
if (operador != ' ')
{
    string[] numeros = ecuacion.Split(operador);
    if (double.TryParse(numeros[0], out double numA) && double.TryParse(numeros[1], out double numB))
    {
        double res = 0;
        switch (operador)
        {
            case '+':
                res = numA + numB;
                break;

            case '-':
                res = numA - numB;
                break;

            case '*':
                res = numA * numB;
                break;

            case '/':
                if (numB != 0)
                {
                    res = numA / numB;
                }
                else
                {
                    Console.WriteLine("Error. No se puede realizar la division por cero");
                }
                break;
        }
        Console.WriteLine($"El resultado de la ecuacion es: {res}");
    }
}
Console.WriteLine("Error. No se encontro un operador valido");
Console.ReadKey();
