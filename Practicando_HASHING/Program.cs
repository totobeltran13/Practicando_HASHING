using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicando_HASHING
{
    class Program
    {
        // Cantidad de celdad en la tabla
        private static int tamano = 10;
        private static CListaLigada[] tabla;

        static void Main(string[] args)
        {
            int n = 0;

            // Necesitamos in arreglo de lsitas ligadas para crsar la tabla
            tabla = new CListaLigada[tamano];

            // Inicializamos la tabla
            for (n = 0; n < tamano; n++)
                tabla[n] = new CListaLigada();

            Mostrar();
            Console.WriteLine("----");

            Insertar(57, "Hola");
            Insertar(45, "Manzana");
            Insertar(42, "Pera");
            Insertar(83, "Azul");
            Insertar(30, "Rojo");
            Insertar(94, "C#");
            Insertar(73, "C++");
            Insertar(97, "Saludos");

            Mostrar();
            Console.WriteLine("----");
        }

        public static void Mostrar()
        {
            int n = 0;

            for(n= 0; n < tamano;n++)
            {
                Console.WriteLine("{0}", n);
                tabla[n].Tranversa();
                Console.WriteLine();
            }
        }

        public static int HashF(int pLlave)
        {
            int indice = 0;

            // Funcion muy sencilla, no usar en el mundo real
            indice = pLlave % tamano;

            return indice;
        }

        public static void Insertar(int pLlave, string pValor)
        {
            int indice = HashF(pLlave);

            tabla[indice].Adicionar(pLlave, pValor);
        }
    }
}