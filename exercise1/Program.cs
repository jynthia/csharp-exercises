using System;

namespace test
{
    class MainClass
    {

        public static int readInt () {
            return (int)Convert.ToUInt32(Console.ReadLine());
        }

        public static bool returnBigger (int x, int y) {
            return x >= y;
        }

        public static float readFloat () {
            return (float)Convert.ToDouble(Console.ReadLine());
        }
        public static void Main(string[] args)
        {
             
            /*  
            1 - Write a program and ask the user to enter a number. 
            The number should be between 1 to 10.
            If the user enters a valid number, display "Valid" on the console.
            Otherwise, display "Invalid".
            */
            Console.WriteLine("Enter a number: ");
            var number = readInt();
            Console.WriteLine(number <= 10 && number >= 1 ? "Valid" : "Invalid");


            /*
            2- Write a program which takes two numbers from the console and 
            displays the maximum of the two.
            */
            Console.WriteLine("Enter 2 numbers: ");
            var number1 = readInt();
            var number2 = readInt();
            Console.WriteLine(returnBigger(number1, number2) ? number1 : number2);

            /*
            3- Write a program and ask the user to enter the width and height of an image. 
            Then tell if the image is landscape or portrait.
            */
            Console.WriteLine("Enter width and height: ");
            var width = readInt();
            var height = readInt();
            Console.WriteLine(returnBigger(width, height) ? "Landscape" : "Portrait");

            /*
            4- Your job is to write a program for a speed camera. For simplicity, ignore the 
            details such as camera, sensors, etc and focus purely on the logic. Write a program that 
            asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
            If the user enters a value less than the speed limit, program should display Ok on the console. 
            If the value is above the speed limit, the program should calculate the number of demerit points. 
            For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            If the number of demerit points is above 12, the program should display License Suspended.
            */
            Console.WriteLine("Enter a speed limit: ");
            SpeedCamera speedCamera = new SpeedCamera(readFloat());

            Console.WriteLine("What is the car speed? ");
            speedCamera.IncreaseSpeed(readFloat());

        }


    }
}
