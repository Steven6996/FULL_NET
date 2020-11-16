using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MENU_LOGICA
    {
        static void Main(string[] args)
        {

            int opc = 1;
            while (opc != 0)
            {


                Console.WriteLine("|********** MENÚ **********| \n" +
                                  "| **** Ejercicio #1 **** | \n" +
                                  "| **** Ejercicio #2 **** | \n" +
                                  "| **** Ejercicio #3 **** | \n" +
                                  "| **** Ejercicio #4 **** | \n" +
                                  "| **** Ejercicio #5 **** | \n" +
                                  "| **** Ejercicio #6 **** | \n" +
                                  "| **** Ejercicio #7 **** | \n" +
                                  "| **** Ejercicio #8 **** | \n" +
                                  "| ****Presione 0 Salir**** | \n" +
                                  "|**************************| \n");
                Console.WriteLine("Por favor elija una opcion del Menú: \n");

                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        {
                            //Leer un número por teclado y definir si es par o impar

                            int Num;
                            Console.WriteLine("Por favor ingrese un numero: \n");
                            Num = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < 10; i++)
                            {

                                if (Num % 2 == 0)
                                {
                                    Console.WriteLine("{0}" + " Par");

                                }
                                else if (Num % 2 != 0)
                                {
                                    Console.WriteLine("{0}" + " Impar");

                                }
                            }

                        }
                        break;


                    case 2:
                        {
                            //Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10 

                            int Tabla;
                            Console.WriteLine("Elige una tabla que quiere ver tiene rangos de del 1-INFINITO: \n");
                            Tabla = Convert.ToInt32(Console.ReadLine());

                            for (int Num = 1; Num < 10; Num++)
                            {
                                Console.WriteLine(Tabla + " x " + Num + " = " + Tabla * Num);
                            }
                        }
                        break;


                    case 3:
                        {
                            //Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10 

                            //int Tablas;
                            Console.WriteLine("Mostrar tabla; \n");
                            //Tablas = Convert.ToInt32(Console.ReadLine());

                            for (int i = 2; i <= 9; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    Console.WriteLine(i + " x " + j + " = " + i * j);
                                }

                            }

                        }
                        break;

                    case 4:
                        {
                            //Leer un número por teclado y definir si es primo o no
                            int Num, Cont = 0;
                            Console.WriteLine("Por favor ingrese un Numero: ");
                            Num = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= Num; i++)
                            {
                                if (Num % i == 0)
                                {
                                    Cont++;

                                }

                            }

                            if (Cont <= 2)
                            {
                                Console.WriteLine("El numero ingresado es: " + Num + "Es Primo");
                            }
                            else if (Cont > 2)
                            {
                                Console.WriteLine("El numero ingresado es: " + Num + " No es Primo");
                            }

                        }
                        break;

                    case 5:
                        {
                            //Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente

                            int[] Edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            int Temp;
                            Console.WriteLine("Mostrar Vector: \n");

                            for (int i = 1; i <= Edad.Length; i++)
                            {
                                for (int j = 0; j < j - i; j++)
                                {
                                    if (Edad[i] >= Edad[i + 1])
                                    {
                                        Temp = Edad[i];
                                        Edad[i] = Edad[i + 1];
                                        Edad[i + 1] = Temp;
                                    }

                                }
                            }
                            foreach (int Numero in Edad)
                            {
                                Console.Write(Numero + " | ");
                            }
                            Console.WriteLine("");


                        }
                        break;

                    case 6:
                        {
                            /*Datos los vectores
                            edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45]
                            nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                            Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                            que el nombre no existe*/

                            int[] Edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            string[] Nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                            Boolean Existe = false;
                            int Indice = 0;
                            Console.Write("Por favor ingrese un nombre: ");
                            String NomBuscar = Convert.ToString(Console.ReadLine().Trim());

                            foreach (string nombre in Nombres)
                            {
                                Console.WriteLine(nombre + " - ");


                            }
                            for (int n = 0; n <= Nombres.Length; n++)
                            {


                                if (NomBuscar == Nombres[n])
                                {
                                    Existe = true;
                                    Indice = n;
                                }
                                if (Existe)
                                {

                                    Console.WriteLine("Nombre: " + NomBuscar + "Edad" + Edad[Indice]);

                                }
                                else
                                {
                                    Console.Write("El nombre ingresado no existe");
                                }

                                //for (int n = 0; n <= Nombre.Length; n++)
                                //{
                                //    if (N == Nombre[n])
                                //    {
                                //        Console.WriteLine("El nombre ingresado es:  " + Nombre[n] + "\nEdad:  " + Edad[n]);

                                //    }
                                //    else
                                //    {
                                //        Console.Write("El nombre ingresado no existe");
                                //    }
                                //}

                            }
                        }
                        break;

                    case 7:
                        {
                            //Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres
                            //con su edad.

                            int[] Edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            int EdadMenor = 0;
                            string[] Nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                            Console.Write("Por favor ingrese un nombre: ");
                            String NomBuscar = Convert.ToString(Console.ReadLine().Trim());


                            foreach (int Edad in Edades)
                            {
                                Console.WriteLine(Edad + " - ");


                            }
                            for (int n = 0; n <= Edades.Length; n++)
                            {


                                if (Edades[n] <= EdadMenor)
                                {
                                    Console.WriteLine("Su nombre es: " + Nombres[n] + "Su edad es: " + Edades[n]);


                                    if (Edades[n] < EdadMenor)
                                    {
                                        Console.WriteLine("Su nombre es: " + Nombres[n] + "Su edad es: " + Edades[n]);

                                    }
                                    else
                                    {
                                        Console.Write("El nombre ingresado no existe" + NomBuscar);
                                    }


                                }

                            }

                        }
                        break;

                    case 8:
                        {
                            //Dado una palabra definir si es palíndromo o no.

                            string Palabras;
                            string invertida = "";
                            String Palindromo = "";
                            Console.WriteLine("por favor ingrese una palabra: ");
                            Palabras = Convert.ToString(Console.ReadLine());

                            foreach (char letra in Palabras)
                            {
                                invertida = letra + invertida;
                            }
                            if (Palabras == Palindromo)
                            {
                                Console.WriteLine(Palabras + " La palabra ingresada es Palindromo");
                            }
                            else
                            {
                                Console.WriteLine(Palabras + " La palabra ingresada es Palindromo");
                            }
                        }
                        break;

                    case 0:
                        {
                            return;
                        }
                        break;
                }

                Console.ReadKey();


            }   }
    }
}
