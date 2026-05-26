
            Console.WriteLine("Hello, World!");
                int a;
                int b;
                a = 10;
                b=a;
                Console.WriteLine("valor de a:"+a);
                Console.WriteLine("valor de b:"+b);
            Console.WriteLine("-------------------------------------------");

            //EJERCICIO 1
            //solicitar numero
            Console.Write("Ingrese un numero entero para invertir: ");
            string entrada = Console.ReadLine();
            int numero;

            //verificar si lo ingresado es un numero entero
            if(int.TryParse(entrada, out numero))
            {
                if(numero > 0)
                {
                    int numeroInvertido = 0;
                    int auxiliar = numero;

                    //invertir el numero
                    while(auxiliar > 0)
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

            Console.WriteLine("-------------------------------------------");
            //EJERCICIO 3
            Console.WriteLine("====MEJORAS DE CALCULADORA====");
            Console.Write("Ingrese un numero real: ");
            if(double.TryParse(Console.ReadLine(), out double numero))
            {
                Console.WriteLine($"\nRESULTADOS DEL NUMERO INGRESADO");
                Console.WriteLine($"El valor absoluto: {Math.Abs(numero)}");
                Console.WriteLine($"El cuadrado: {Math.Pow(numero)}");
                if(numero >= 0)
                {
                Console.WriteLine($"La raiz cuadrada: {Math.Sqrt(numero)}");
                }
                else
                {
                    Console.WriteLine($"Error.No existe raiz cuadrada real para el numero ingresado");
                }
                Console.WriteLine($"El seno: {Math.Sin(numero)}");
                Console.WriteLine($"El coseno: {Math.Cos(numero)}");
                float numeroEnFloat = (float)numero;
                Console.WriteLine($"La parte entera: {Math.Truncate(numeroEnFloat)}");

            }
            else
            {
                Console.WriteLine("Error.Lo ingresado no es un numero");
            }

            Console.ReadKey();
            