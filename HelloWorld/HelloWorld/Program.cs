using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld{
    class MainClass{
        public static void Main(string[] args){
            //declare and initialize variables
            int myInt = 2;
            byte myAge = 35; //can only be between 0 and 255
            double numberOfHours = 523.5; //no letter needed after
            float hourlyRate = 15.75f; //float needs an f after
            decimal income = 30000.76m; //decimal needs an m
            char grade = 'A';
            bool myBool = false;

            //print to console
            Console.WriteLine("My integer is " + myInt);
            Console.WriteLine("My byte is " + myAge);
            Console.WriteLine("My double is " + numberOfHours);
            Console.WriteLine("My float is " + hourlyRate);
            Console.WriteLine("My decimal is " + income);
            Console.WriteLine("My grade is " + grade);
            Console.WriteLine("My boolean is " + myBool);
            Console.WriteLine(); //print a blank line

            //casting
            double castedDouble = (double)myInt;//type casting
			Console.WriteLine("I type casted my int to a double and now it is " + castedDouble); //now print the new number

			//arrays
			int [] userAge = {21, 22, 23, 24, 25}; //create an array and initialize with specific values
            int[] userAge2; //create an empty array
            userAge2 = new int [] {21, 22, 23, 24, 25}; //fill the array
            int[] userAge3 = new int[5]; //make an array of size 5 with default values
            Console.WriteLine("The length of my arry is " + userAge.Length); //show the length of the array
			Array.Copy(userAge, userAge3, 5); //copy an array... first arguement is the source, the second is the destination
			int[] unsortedArray = {5, 4, 3, 2, 1}; //unsorted array
            Array.Sort(unsortedArray); //command to sort
            int resultOfSort = Array.IndexOf(unsortedArray, 1); //check the index of the one of the elements to see if it worked
            Console.WriteLine("1 was in the index 4, but now it is in " + resultOfSort); //now print to esnure it worked
            Console.WriteLine(); //print a blank line

			//strings in C# are assigned a little different than Java
			string newString = "my new string is this text"; //lowercase not uppercase for the word string
            Console.WriteLine(newString);
            Console.WriteLine(newString.Substring(5, 10)); //look at just a substring of entire string
            //other functions that can be used are Split(), Length(), and Equals()
            Console.WriteLine(); //print a blank line
            Console.WriteLine("End of test program, please hit any key to terminate");

			//will allow the console to close
			Console.Read();

        }//end of Main method
    }//end of MainClass
}//end of HelloWorld