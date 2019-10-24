using System;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaasta, funktsioon tagastab vanuse
            int yearOfBirth;
            int age;
            int ageNextYear;
           

            Console.WriteLine("Please enter your birth year:");
            yearOfBirth= int.Parse(Console.ReadLine());

            age = GetAge(yearOfBirth, 2019);
            Console.WriteLine($"You are {age} years old");

            ageNextYear = GetAgeNextYear(age);
            Console.WriteLine($"Next year you are {ageNextYear}");

            GetAgeDifference(yearOfBirth);
         
            
        }
        public static int GetAge(int yearOfBirth, int currentYear)
        {
            /* int result = currentYear - yearOfBirth;
             return result;*/
            return currentYear - yearOfBirth; //nii võib ka teha ning on lühem
        } 
        public static int GetAgeNextYear (int age)
        {
            return age + 1; 
        } 
        public static void GetAgeDifference (int yearOfBirth)
        {
            if (yearOfBirth > 1926)
            {
                Console.WriteLine($"You are {yearOfBirth- 1926} year(s) younger than the Queen.");
            }
            else if(yearOfBirth == 1926)
            {
                Console.WriteLine($"Are you the Queen?");
            }
            else
            {
                Console.WriteLine($"You are {1926 - yearOfBirth} year(s) older than the Queen.");
            }
            
        }
    }
}
