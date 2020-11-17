/* Patrick Galán Rodriguez
66. Crea un array que permita almacenar hasta 1000 números reales de doble precisión.
 Muestra un menú que le permita: Añadir un nuevo dato al final,
  insertar un dato en una cierta posición, borrar el dato que hay 
  en una cierta posición, ver todos los datos en su orden original,
   ver todos los datos en orden inverso, mostrar el máximo de los datos,
    mostrar el mínimo de los datos, buscar un cierto dato, salir.
     La opción de Buscar preguntará el dato que se quiere localizar 
     y responderá si ese dato era parte de los 10 iniciales o no.*/
    
using System;

class Ejer_66
{
    enum menu {salir, anyadirDato, insertarDato, borrarDato, mostrarDato, datosReves, maximo, minimo, buscar}
    static void Main()
    {
        double[] datos = new double [1000];
        double dato, maximo, minimo, buscar;
        int input, ultimaPosicion = 0, contador = 0;
        bool encontrado = false;
        
        do
        {
            Console.WriteLine((int) menu.anyadirDato + ". Añadir dato");
            Console.WriteLine((int) menu.insertarDato + ". Insertar dato");
            Console.WriteLine((int) menu.borrarDato + ". Borrar dato");
            Console.WriteLine((int) menu.mostrarDato + ". Mostrar datos en orden ascendente");
            Console.WriteLine((int) menu.datosReves + ". Mostrar datos en orden inverso");
            Console.WriteLine((int) menu.maximo + ". Mostrar dato maximo");
            Console.WriteLine((int) menu.minimo + ". Mostrar dato minimo");
            Console.WriteLine((int) menu.buscar + ". Buscar dato");
            Console.WriteLine((int) menu.salir + ". Salir");
            Console.WriteLine();
            Console.Write("Elija una opcion: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            switch (input)
            {
                case (int) menu.anyadirDato: 
                {
                        Console.WriteLine("Introduzca nuevo dato: ");
                        dato = Convert.ToDouble(Console.ReadLine());
                        datos[ultimaPosicion] = dato;
                        ultimaPosicion++;
                        Console.WriteLine();
                }
                break;
                
                case (int) menu.insertarDato: int posicionInsertar = 0;
                {
                    Console.Write("Introduzca dato a insertar: ");
                    dato = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduzca posicion para insertar: ");
                    posicionInsertar = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = ultimaPosicion; i > posicionInsertar; i--)
                    {
                        datos[i] = datos[i - 1];
                    }
                datos[posicionInsertar] = (double) dato;
                ultimaPosicion++;
                }
                break;
                
                case (int) menu.borrarDato:
                case (int) menu.mostrarDato:
                {
                    for (int i = 0; i < ultimaPosicion; i++)
                    {
                        Console.WriteLine(datos[i]);
                    }
                }
                break;
                
                case (int) menu.datosReves:
                {
                    for (int i = ultimaPosicion; i > 0; i--)
                    {
                        Console.WriteLine(datos[i]);
                    }
                }
                break;
                
                case (int) menu.maximo: maximo = datos[0];
                {
                    for (int i = 0; i <= ultimaPosicion; i++)
                    {
                        if (datos[i] > maximo)
                            maximo = datos[i];
                    }
                    Console.WriteLine("El dato maximo es {0}",maximo);
                    Console.WriteLine();
                }
                break;
                
                case (int) menu.minimo: minimo = datos[0];
                {
                    for (int i = 0; i <=ultimaPosicion; i++)
                    {
                        if (datos[i] < minimo)
                            minimo = datos[i];
                    }
                    Console.WriteLine("El dato minimo es {0}",minimo);
                    Console.WriteLine();
                }
                break;
                
                case (int) menu.buscar:
                {
                    Console.Write("Introduzca dato a buscar: ");
                    dato = Convert.ToDouble(Console.ReadLine());
                    int i = 0;
                    while (i < ultimaPosicion && ! encontrado)
                    {
                        if (datos[i] == dato)
                        Console.WriteLine("Dato {0} encontrado", dato);
                        encontrado = true;
                        i++;
                    }  
                        
                }
                break;
            }
        }
        while (input != 0);
    }
}
