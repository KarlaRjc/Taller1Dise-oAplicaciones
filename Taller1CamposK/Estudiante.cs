using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1CamposK
{
    class Estudiante : ICalculo
    {
        static string[] nombre;
        static int[] nota;
        static int acumuladorNotas = 0;

        

        public static void InfoEstudiante()
        {
            nombre = new string[18];

            for (int j = 0; j < nombre.Length; j++)
            {
                Console.Write("Por favor digite el nombre del alumno.");
                 string guardaNombre = Console.ReadLine();
                nombre[j] = guardaNombre;
            }


        }
        public void NotasEstudiante()
        {
            nota= new int[18];
            InfoEstudiante();
            

            for (int i = 0; i < nota.Length; i++)
            {   
                
                Console.WriteLine("Por favor digite la nota");
                string preguntaNota = Console.ReadLine();
                int guardaNota = int.Parse(preguntaNota);

                acumuladorNotas+=guardaNota;
               

                if (guardaNota == 0 || guardaNota < 9)
                {
       
                    nota[0]++;
                    Console.WriteLine("Hola");
                    
                }
                if (guardaNota > 10 && guardaNota < 19)
                {
                    nota[1]++;
                
                   
                }
                if(guardaNota >20 && guardaNota < 29)
                {
                    nota[2]++;
                  
                }
                if (guardaNota > 30 && guardaNota < 39)
                {
                    nota[3]++;
                  
                }
                if (guardaNota > 40 && guardaNota < 49)
                {
                    nota[4]++;
                  
                }
                if (guardaNota > 50 && guardaNota < 59)
                {
                    nota[5]++;
                 
                }
                if (guardaNota > 60 && guardaNota < 69)
                {
                    nota[6]++;
            
                }
                if (guardaNota > 70 && guardaNota < 79)
                {
                    nota[7]++;
                
                }
                if (guardaNota > 80 && guardaNota < 89)
                {
                    nota[8]++;
               
                }
                if (guardaNota > 90 && guardaNota < 99)
                {
                    nota[9]++;
                   
                }
                if (guardaNota==100)
                {
                    nota[10]++;
                   
                }
                
               
            }
            RangoNotas();
            SumaTotalNotas();
           
            Console.Read();
        }

        public void RangoNotas() {
            int rango1 = 0;
            int rango2 = 0;
            int rango3 = 0;
            int rango4 = 0;
            int rango5 = 0;
            int rango6 = 0;
            int rango7 = 0;
            int rango8 = 0;
            int rango9 = 0;
            int rango10 = 0;
            int rango11 = 0;
            int rango12 = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                 rango1 = nota[0];
                rango2 = nota[1];
                rango3 = nota[2];
                rango4 = nota[3];
                rango5 = nota[4];
                rango6 = nota[5];
                rango7 = nota[6];
                rango8 = nota[7];
                rango9 = nota[8];
                rango10 = nota[9];
                rango11 = nota[10];
                rango12 = nota[11];
                
            }
            Console.WriteLine("rango de estudiantes entre 0-9" + rango1);
            Console.WriteLine("rango de estudiantes entre 10-19" + rango2);
            Console.WriteLine("rango de estudiantes entre 20-29" + rango3);
            Console.WriteLine("rango de estudiantes entre 30-39" + rango4);
            Console.WriteLine("rango de estudiantes entre 40-49" + rango5);
            Console.WriteLine("rango de estudiantes entre 50-59" + rango6);
            Console.WriteLine("rango de estudiantes entre 6-69" + rango7);
            Console.WriteLine("rango de estudiantes entre 70-79" + rango8);
            Console.WriteLine("rango de estudiantes entre 80-89" + rango9);
            Console.WriteLine("rango de estudiantes entre 90-99" + rango10);
            Console.WriteLine("rango de estudiantes entre 100" + rango11);


        }
        public void SumaTotalNotas()

        {
            var promedio = 0;
            var total = 0;

            for (int i = 0; i < nota.Length; i++)
            {
                total = total + nota[i];

            }
            promedio = acumuladorNotas / total;
            Console.WriteLine("El promedio de las notas son" + promedio);
            Console.Read();
        }



    }

}
