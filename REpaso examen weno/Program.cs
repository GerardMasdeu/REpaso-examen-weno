using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REpaso_examen_weno
{
    class Program
    {

        
        static void Main(string[] args)
        {
            FileStream fichero = new FileStream("ejercicio1.txt", FileMode.Open, FileAcces.Read);
            StreamReader fs = new StramReader(fichero);
            String linea = "";
            int contadorLineas = 0, contador = 0, contadorA = 0, contadorLineasA = 0;
            while ((lineas = fs.ReadLine()) != null)
            {
                contadorLineas++;
                if (linea.Length < 50)
                {
                    contador++;
                }
                for (int i = 0; i < linea.Length; i++)
                {
                    if (linea[i] == 'A')
                    {
                        contadorA++;
                    }

                }
                if (contadorA >= 1)
                {
                    contadorLineasA++;
                    contadorA = 0;
                }


                fs.Close();
                fichero.Close();
                Console.WriteLine("Tienes{0}", contadorLineas);
                Console.WriteLine("Tiene {0} lineas con menos de 50 caracteres", contador);
                Console.WriteLine("Tiene {0} lineas con la letra  A", contadorLineasA);
            }
            }
        }
   
    }
}
