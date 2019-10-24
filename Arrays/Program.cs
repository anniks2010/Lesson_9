using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays - Massiiv on andmete kogum. Massiiv sisaldab ühte tüüpi andmeid. Massivil on üks kindel tüüp. Massiiv on muutujate kogum.
            int[] myFirtArray = new int[5] { 1, 2, 3, 4, 5 };//5 stekki paneb valmis

            /*for (int i =0; i < myFirtArray.Length; i++)
            {
                Console.WriteLine(myFirtArray[i]);

            }*/
            /* for (int i = myFirtArray.Length-1; i >= 0; i--) //nr 1 indeks on 0. Lenght on 5 elementi, aga me loeme nullist ning seepärast miinus 1. For loop vaatab indekseid
             {
                 Console.WriteLine(myFirtArray[i]);
             }*/

            // Overwriting array values

            /*myFirtArray[4] = myFirtArray[4] * 100;
            myFirtArray[0] = myFirtArray[0] * 100;
            for (int i = 0; i < myFirtArray.Length; i++)
            {
                Console.WriteLine(myFirtArray[i]);

            }*/
            
            for (int i =0; i< myFirtArray.Length; i++)
            {
                myFirtArray[i] = myFirtArray[i] * 100; //määrab uue väärtuse meie muutujatele ning salvestab. Kui kirjutada writeline sisse siis ta näitab seda väärtust hetkel ning ei salvesta.
                Console.WriteLine($"{myFirtArray[i]}");
            }

            for (int i = 0; i < myFirtArray.Length; i++)
            {
               
                Console.WriteLine(myFirtArray[i]); 
            }
        }
    }
}
