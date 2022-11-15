using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1_MarioVillanueva_11482222
{
    class PruebaVector11
    {
        private string[] nivel;
        private float[] personas;

        public void Cargar()
        {
            nivel = new string[5];
            personas = new float[5];
            for (int f = 0; f < nivel.Length; f++)
            {
                Console.Write("Ingrese el nivel del edificio:");
                nivel[f] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de personas en ese nivel:");
                string linea;
                linea = Console.ReadLine();
                personas[f] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = personas[0];
            pos = 0;
            for (int f = 1; f < nivel.Length; f++)
            {
                if (personas[f] > mayor)
                {
                    mayor = personas[f];
                    pos = f;
                }
            }
            Console.WriteLine("El numero de nivel con mayor cantidad de personas es el numero " + nivel[pos]);
            Console.WriteLine("Numero de personas en ese nivel:" + mayor);
            Console.ReadKey();
        }
        public void SumaDePersonas()
        {
            float suma = 0;
            float suma1= 0;
            for (int f = 0; f < nivel.Length; f++)
            {
                Console.WriteLine(nivel[f] + "");
                suma = Int32.Parse(nivel[f]);
                suma1 += personas[f];
               
            }
            Console.WriteLine("Los suma de todas las personas en el edificio es : " + suma1);
            Console.WriteLine("Informacion general: ");
            for (int f = 0; f < nivel.Length; f++)
            {
                Console.WriteLine(" numero de  nivel: "+ nivel[f] + "");
                Console.WriteLine("Numero de personas en el nivel: "+ personas[f] + "");

            }
            Console.ReadKey();


        }

            static void Main(string[] args)
        {
            PruebaVector11 pv = new PruebaVector11();
            pv.Cargar();
            pv.MayorSueldo();
            pv.SumaDePersonas();


        }
    }
}



