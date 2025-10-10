using System.Collections.Generic;

namespace Map_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare a dictionary with string keys and int values
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();

            studentGrades["Ali"] = 66;
            studentGrades["Ahmed"] = 91;
            studentGrades["Fadi"] = 77;

            Console.WriteLine("\nPrinting all map values..\n");

            // Iterating over the dictionary
            foreach(var pair  in studentGrades)
            {
                Console.WriteLine($"Student: {pair.Key}, Grade: {pair.Value}");
            }

            Console.WriteLine("\nFinding Fadi's Grade in the Dictionary..");
            string studentName = "Fadi";
            int grade;

            // Try to get a value for a specific key
            if (studentGrades.TryGetValue(studentName, out grade))
            {
                Console.WriteLine($"{studentName}'s Grade: {grade}");
            }
            else
            {
                Console.WriteLine($"Grade not found for {studentName}");
            }

            Console.WriteLine("\nFinding Omar's Grade in the Dictionary..");
            studentName = "Omar";

            if(studentGrades.TryGetValue(studentName, out grade))
            {
                Console.WriteLine($"{studentName}'s Grade: {grade}");
            }
            else
            {
                Console.WriteLine($"Grade not found for {studentName}");
            }

            Console.ReadKey();

        }
    }
}