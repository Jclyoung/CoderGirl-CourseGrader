using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            int numberOfGrades = 50;
            int[] testScores = new int[numberOfGrades];
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.Write("Please enter a grade:");
                string userInput = Console.ReadLine();
                if (userInput == "" 
                || userInput == " "
                || userInput == null) 
                {
                    numberOfGrades = i;
                    break;
                }   
                
                int.TryParse(userInput, out int gradeInput);
               testScores[i] = gradeInput;
                   
            }         
                Console.WriteLine(GradeTestScores(testScores));
                Console.ReadLine();
                
            // create a method named GradeTestScores that takes an array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a message of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }

        public static string GradeTestScores(int[] testScores)
        {
            int sum = 0;
            foreach (int grade in testScores)
            {   
                if (grade < 50)
                    return "fail";
                else
                    sum += grade;
            }
            if (sum == 0)
                return "fail";
            int averageTestScore = sum / testScores.Length;
            if (averageTestScore >= 70)
                return "pass";
            else
                return "fail";            
        }
        //{
        //    int avgTestScore = sum / length;

        //    if (50 >= )
        //    {
        //        Console.WriteLine("Fail");

        //    }

        //    if else (avgTestScore >= 70);
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else
        //        Console.WriteLine("Fail");




    }
}   
