namespace Actividad3;

class Program
{
    static void Main(string[] args)
    {
        string? cmd;
        Console.WriteLine("Bienvenido al programa de ejercicios de C#. ACTIVIDAD 3");
        Console.WriteLine("Salvador Robles Ruiz");
        Console.WriteLine("Víctor Robles Baraza");
        Menu();
        do
        {
            cmd = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cmd)) 
            continue;
            switch (cmd?.ToLower())
            {
                case "exit":
                    break;
                case "menu":
                    Menu();
                    break;
                default:
                    if (int.TryParse(cmd, out int num))
                    {
                        switch (num)
                        {
                            case 0:
                                Ejercicio0();
                                break;
                            case 1:
                                Ejercicio1();
                                break;
                            case 2:
                                Ejercicio2();
                                break;
                            case 3:
                                Ejercicio3();
                                break;
                            case 4:
                                Ejercicio4();
                                break;
                            case 5:
                                Ejercicio5();
                                break;
                            case 6:
                                Ejercicio6();
                                break;
                            case 7:
                                Ejercicio7();
                                break;
                            case 8:
                                Ejercicio8();
                                break;
                            case 9:
                                Ejercicio9();
                                break;
                            case 10:
                                Ejercicio10();
                                break;
                            default:
                                Console.WriteLine(
                                    "Comando no permitido.\nEscriba un nÚmero del 0 al 10, para ejecutar el ejercicio.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Comando no permitido.");
                        Console.WriteLine("Escriba un nÚmero del 0 al 10 para ejecutar el ejercicio.");
                        Console.WriteLine("Escriba EXIT para salir.");
                        Console.WriteLine("Escriba MENU para mostar el menu principal.");
                    }

                    break;
            }
        } while (cmd?.ToLower() != "exit");
        Console.WriteLine("Gracias por usar el programa.");
    }

    static void Menu()
    {
        Console.WriteLine("======== MENU PRINCIPAL ========");
        Console.WriteLine("0. Hola Mundo!");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Ejercicio 6");
        Console.WriteLine("7. Ejercicio 7");
        Console.WriteLine("8. Ejercicio 8");
        Console.WriteLine("9. Ejercicio 9");
        Console.WriteLine("10. Ejercicio 10");
        Console.WriteLine("Escriba EXIT para salir.");
        Console.WriteLine("Escriba MENU para mostrar el menu principal.");
        Console.WriteLine("================================");
    }

    static void Ejercicio0()
    {
        Console.WriteLine("Hola Mundo!");
    }

    static void Ejercicio1()
    {
        //Diseña un programa que pida un número al usuario, por teclado y a continuación lo muestre.

        //pedimos que se introduzca un número
        Console.WriteLine("Introduce un número");
    

        //declaramos la variable, la leemos por consola y convertimos a entero
        int nUmero = Convert.ToInt32(Console.ReadLine());

        //mostramos el numero que hayamos puesto anteriormente
        Console.WriteLine($"El número introducido es {nUmero}");

    }

    static void Ejercicio2()
    {
        /*Pedir al usuario su edad y mostrar la que tendrá el próximo año.*/
        
        Console.WriteLine("Escriba su edad:");
        string? ValorIntro = Console.ReadLine();
        int Edad;
        bool EdadValida = int.TryParse(ValorIntro, out Edad);
        
        //Creamos una condicional para que se indtroduzca una edad
        if (EdadValida)
        {
            int EdadProxAnio = Edad + 1;
            Console.WriteLine($"El próximo año tendrás {EdadProxAnio} años");
        }
        else
        {
            Console.WriteLine("No has introduccido una edad.");
        }


    }

    static void Ejercicio3()
    {
       /*Escribir una aplicación que pida el año actual y el de nacimiento del usuario. 
          Debe calcular su edad, suponiendo que el año en curso el usuario ya ha cumplido años.*/
        
        Console.WriteLine("Escriba el año actual:");
        string? AnioActInto = Console.ReadLine();
        
        Console.WriteLine("Escriba su año de nacimiento:");
        string? AnioNacInto = Console.ReadLine();
        
        int AnioActual;
        
        int AnioNac;
            
            bool AnioActualValido = int.TryParse(AnioActInto, out AnioActual);
        
            bool AnioNacValido = int.TryParse(AnioNacInto, out AnioNac);
        
        if (AnioActualValido && AnioNacValido)
        {
            //calcular edad
            int Edad = AnioActual - AnioNac;
            Console.WriteLine("La edad en el año actual es: " + Edad);
        }
        else
        {
            Console.WriteLine("No has introduccido un dato correctamente");
        }


    }

    static void Ejercicio4()
    {
        /*El tipo short permite almacene valores comprendidos entre -32768 y 32767. 
          Escribir un programa que compruebe que el rango de valores de un tipo se 
          comporte de forma cíclica, es decir, el valor siguiente al máximo es el valor 
          mínimo. */
        short maximo = short.MaxValue;
        short minimo = short.MinValue;
            Console.WriteLine("Valor máximo de short: " + maximo);
            Console.WriteLine("Valor mínimo de short: " + minimo);
        
        short valorCiclico = (short)(maximo + 1);

        Console.WriteLine("Valor cíclico (max + 1): " + valorCiclico);
        
        // Comprobamos si es ciclico comparandolo con el minimo
        bool esCiclico = valorCiclico == minimo; 
        
        string resultado = (esCiclico == true) ? "El tipo short se comporta de forma cíclica." : "El tipo short no se comporta de forma cíclica.";
            Console.WriteLine(resultado);

    }

    static void Ejercicio5()
    {
        /*Diseña una aplicación que calcule la longitud y el área de una circunferencia. Para
        ello, el usuario debe introducir el radio (que puede contener decimales).
        Recordamos: Longitud = 2*pi*radio y Área = pi * radio 2*/

        Console.WriteLine("Introduce el radio de la circunferencia");
        double radio = Convert.ToDouble(Console.ReadLine());

        //Calculamos la longitud y el área del círculo usando la librería Math
        double longitud = 2 * Math.PI * radio;

        double area = Math.PI * Math.Pow(radio, 2);

        /*mostramos la solucion de la longitud. Hemos añadido ToString("F2")
        para que ponga solo 2 decimales y no 15 como salia */
        Console.WriteLine("La longitud de la circunferencia es " + longitud.ToString("F2"));

        //Y aquí la solución para el área
        Console.WriteLine("El área de la circunferencia es de " + area.ToString("F2"));

    }

    static void Ejercicio6()
    {
        /*Realiza una aplicación que solicite al usuario su edad y le indique si es mayor de
        edad (mediante un literal booleano: true o false).*/

        
        Console.WriteLine("Introduce tu edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        //usamos Booleano y decimos que si es igual o mayor a 18 sea true
        bool mayorDeEdad = edad >= 18;

        Console.WriteLine("¿Mayor de edad? " + mayorDeEdad);
    }

    static void Ejercicio7()
    {
        /*Escribir un programa que pida un número al usuario e indique mediante un literal
        booleano (true o false) si el número es par.*/

        
        Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());

        //usamos booleano y ponemos si al dividirlo entre 2 el resto es 0, sería par
        bool par = numero % 2 == 0;

        Console.WriteLine("¿El número es par? " + par);
    }

    static void Ejercicio8()
    {
        /*Diseña un algoritmo que no indique si podemos salir a la calle. Existen aspecto
        que influirá en esta decisión: si está lloviendo y si hemos terminado nuestras
        tareas. Solo podremos salir a la calle si no está lloviendo y hemos finalizado
        nuestras tareas. Existe una opción en la que, indistintamente de lo anterior,
        podremos salir a la calle: el hecho de que tengamos que ir a la biblioteca (para
        realizar algún trabajo, entregar un libro, etc.) Solicitar al usuario (mediante un
        booleano) si llueve, si ha finalizado las taras y si necesita ir a la biblioteca. El
        algoritmo debe mostrar mediante un booleano (true o false) si es posible que se
        le otorgue permiso para ir a la calle.*/

    
        Console.WriteLine("¿Está lloviendo?");
        bool llueve = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("¿Has finalizado las tareas?");
        bool tareasFinalizadas = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("¿Necesitas ir a la biblioteca?");
        bool biblioteca = Convert.ToBoolean(Console.ReadLine());

        /*calculamos si puede salir a la calle segun las condiciones
        Usamos operadores lógicos (AND: &&, OR: ||, NOT: !).*/
        bool puedeSalir = (!llueve && tareasFinalizadas) || biblioteca;

        Console.WriteLine("¿Puedo salir a la calle? " + puedeSalir);
    }

    static void Ejercicio9()
    {
        /*Un frutero necesita calcular los beneficios anuales que obtiene de la venta de
        manzanas y peras. Por ese motivo, es necesario diseñar una aplicación que
        solicite las ventas (en kilos) de cada semestre para cada fruta. La aplicación
        mostrará el importe total sabiendo que el precio del kilo de manzanas está fijado
        en 2,35 € y el kilo de peras en 1,95 €.*/

        
        Console.WriteLine("Introduce los kilos de manzanas vendidos en el primer semestre");
        double manzanaSemestre = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce los kilos de manzanas vendidos en el segundo semestre");
        double manzana2semestre = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce los kilos de peras vendidos en el primer semestre:");
        double perasSemestre = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce los kilos de peras vendidos en el segundo semestre:");
        double peras2Semestre = Convert.ToDouble(Console.ReadLine());

        //usamos otra variable que sera el resultado de la venta de los 2 semestres
        double totalKilosManzana = manzanaSemestre + manzana2semestre;
        double totalKilosPeras = perasSemestre + peras2Semestre;

        //usamos variable que es el precio del kilo por todas las ventas de cada fruta
        double beneficioManzana = totalKilosManzana * 2.35;
        double beneficioPeras = totalKilosPeras * 1.95;

        //usamos una ultima variable que es para saber el beneficio total 
        double beneficioTotal = beneficioManzana + beneficioPeras;

        Console.WriteLine("El beneficio total anual es: " + beneficioTotal + " euros");

    }

    static void Ejercicio10()
    {
        /*Escribe un programa que pida un número al usuario y determines si es par o impar. */
        //Pedir un numero para saber si es par o impar
        
        Console.WriteLine("Escriba un número para comprobar si es par o impar:");
        string? texto = Console.ReadLine();
        
        int Numero;
        
        bool Valido = int.TryParse(texto, out Numero);
            
            if (Valido)
        {
                bool EsPar = Numero % 2 == 0;
                string resultado = ( EsPar == true) ? "El número es par." : "El número es impar.";
                Console.WriteLine(resultado);
        }
            else
        {
                Console.WriteLine("El valor introducido no es un número.");
        }

    }
}