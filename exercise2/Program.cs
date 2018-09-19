using System;

namespace exercicio2
{
    class MainClass
    {
        public static int recursiveForMod3(int start, int end, int count)
        {
            if (start == end)
            {
                return count;
            }
            if (Utilities.isModX(start, 3))
            {
                count++;
            }
            return recursiveForMod3(start+1, end, count);
        }

        public static int recursiveUntilOk(int sum) {

            Console.WriteLine("Enter a number or type OK if you're done");

            var userEntry = Console.ReadLine();

            if (userEntry == "OK")
                return sum;

            return recursiveUntilOk(sum + Int32.Parse(userEntry)); 

        }

        public static int recursiveFactorial(int start) {

            if (start >= 1)
                return start * recursiveFactorial(start - 1);
            return 1;

        }

        public static bool recursiveChancesRandom(int random, int chancesTaken, int chances) {

            if (chancesTaken == chances)
                return false;
            if (Utilities.readInt() == random)
                return true;
            return recursiveChancesRandom(random, chancesTaken + 1, chances);
            
        }

        public static int recursiveBiggerFromArr(int bigger, string[] arr, int start, int length) {
            if (start >= length)
                return bigger;
            if ( Utilities.returnBigger(Convert.ToInt32(arr[start]), bigger) ) {
                bigger = Convert.ToInt32(arr[start]);
            }
            return recursiveBiggerFromArr(bigger, arr, start + 1, length);

        }

        public static void Main(string[] args)
        {

            /*
             1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 
             with no remainder.Display the count on the console.
            */
            var count = recursiveForMod3(1, 100, 0);
            Console.WriteLine(count);

            /*
             2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
             Calculate the sum of all the previously entered numbers and display it on the console.
            */
            var sum = recursiveUntilOk(0);
            Console.WriteLine(sum);

            /*
             3- Write a program and ask the user to enter a number. Compute the factorial of the 
             number and print it on the console.
            */
            Console.WriteLine("Enter the number");
            Console.WriteLine(recursiveFactorial(Utilities.readInt()));

            /*
             4 - Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess 
             the number.If the user guesses the number, display “You won"; otherwise, display “You lost". 
            */
            Random rnd = new Random();
            var randomNumber = rnd.Next();
            Console.WriteLine("Dev Only :" + randomNumber);
            Console.WriteLine(recursiveChancesRandom(randomNumber, 0, 4) ? "You won!" : "You lost!");

            /*
             5- Write a program and ask the user to enter a series of numbers separated by comma. 
             Find the maximum of the numbers and display it on the console. For example, if the user enters 
             “5, 3, 8, 1, 4", the program should display 8.
            */
            Console.WriteLine("Enter numbers comma separated");
            var arr = (Console.ReadLine()).Split(',');
            Console.WriteLine(recursiveBiggerFromArr(0, arr, 0, arr.Length));


        }
    }
}
 
 
