using System;

namespace String_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String[] myFirstStringArray= myFirstStringArray = new string[5] { "one", "two", "three", "four", "five" };

            
            ///lugemine algusest lõpuni:
            for (int i =0; i< myFirstStringArray.Length; i++)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }

            
            ///lugemine lõpust algusesse:
            for(int i = myFirstStringArray.Length -1; i >= 0; i--)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }*/

            String[] fruits = new string[5];

            for( int i =0; i < 5; i++)
            {
                Console.WriteLine("Name some fruit: ");
                fruits[i] = Console.ReadLine();
            }

            foreach (string fruit in fruits)
            {
                Console.WriteLine("You have entered: " + fruit);
            }

            ////Luua massiv, kus on numbrid 1-100. Proovige leida nende elementide summat. uus muutuja summa
        }
    }
}
