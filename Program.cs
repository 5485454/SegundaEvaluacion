using System;

namespace Segundo_Proyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            string equis ="";
            int edad = 0;
            double altura = 0.0;
            
            Console.WriteLine("Hola amig@, ¿como estas? Bienvenido al parque Dunas");

            Console.WriteLine("Ahora podrias por favor decirme tu edad:");
            equis = Console.ReadLine();
            edad = Convert.ToInt32(equis);
            
            
            if(edad >= 18)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para entrar al parque acuatico.");
            }
            else
            {
                
                
                Console.WriteLine("Bienvenido");
                
                Console.WriteLine("cual es tu altura? En metros");
                equis = Console.ReadLine();
                altura = Convert.ToDouble(equis);
                
                if(edad < 12)
                {
                Console.WriteLine("Puedes ir a la Feria de Juegos, al Play ground, al Dino y el bosque encantado");    
                }
                else
                {
                    Console.WriteLine("Puedes ir a Flush, al Boomerango, al Play ground, al Dino, a Vertigo y al Duna Jump");
                
                }
                //
            }

                 Console.WriteLine ("pongame 20 profe andele: '( ");
            
            
            
            
            Console.ReadKey();
        
        }
    }
}   
