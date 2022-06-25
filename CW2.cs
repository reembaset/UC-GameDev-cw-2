using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // The Hero information 
            String HeroName = "00H";
            int HeroPower = 100;

            // The Villain information 
            String VillainName = "00X";
            int VillainPower = 800;


            // The compersen 
            if (HeroPower < VillainPower)
            {
                Console.WriteLine("Villain is stronger");
            }
            else if (HeroPower > VillainPower)
            {
                Console.WriteLine(" Hero is stronger");
            }
            else {
                Console.WriteLine(" Hero and Villain are equal power");
            }

            Double palayerspeed = 3.5 ;
            Double z = 2.5;
            Setspeed(z);


            // function that change the power and print 
            void Setspeed(Double R) {

                Double oldplayerspeed = palayerspeed;
                palayerspeed = R;

                Console.WriteLine("The old speed : " + oldplayerspeed);
                Console.WriteLine("The new speed : " + palayerspeed);

                CompareSpeed(oldplayerspeed, palayerspeed);

            } // End of the set palyer function 

            // function compare speeds 
            void CompareSpeed(Double oldplayerspeed, double palayerspeed1) {
                if (oldplayerspeed > palayerspeed1) {
                    Console.WriteLine("The greter power is the older one  " + oldplayerspeed);
                }
                else if(oldplayerspeed < palayerspeed1)
                {
                    Console.WriteLine("The Greter power is the new one  " + palayerspeed1);
                }

                else {
                    Console.WriteLine("Both of power are equal : The old one  " + oldplayerspeed + "The new one " + palayerspeed1);
                }
               
            }





        }
    }
}
