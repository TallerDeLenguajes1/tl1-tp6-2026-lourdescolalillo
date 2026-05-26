
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
            Console.ReadKey();
        }
    }
}