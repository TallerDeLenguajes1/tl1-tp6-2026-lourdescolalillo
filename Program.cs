
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
            Console.WriteLine("\n-------------------------------------------");

            //EJERCICIO 2
            string continuar = "";
            do
            {
                Console.Clear();
                Console.WriteLine("====MENU DE CALCULADORA====");
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                string opcion = Console.ReadLine();

                //validamos la opcion del usuario
                if(opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                {
                    //pedimos y validamos el primer numero
                    Console.Write("Ingrese el primer numero: ");
                    if(double.TryParse(Console.ReadLine(), out double numero1))
                    {
                        Console.Write("Ingrese el segundo numero: ");
                        if(double.TryParse(Console.ReadLine(), out double numero2))
                        {
                            double resultado = 0;

                            switch(opcion)
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
                                if(numero2 != 0)
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
            }while(continuar == "S");
            Console.ReadKey();
            