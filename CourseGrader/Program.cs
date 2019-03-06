using System;

namespace CourseGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = 50;
            int[] testScores = new int[numberOfGrades];
            for (int i = 0; i < testScores.Length; i++)
            {
                Console.Write("Please enter a grade:");
                int gradeInput = Convert.ToInt32(Console.ReadLine());
                if (i == 0) 
                {
                    numberOfGrades = i;
                    break;
                }
                testScores[i] = gradeInput;
                

                Console.ReadKey();
            }

            // create a method named GradeTestScores that takes an array of test scores as its parameter and returns a string
            // GradeTestScores will add up these test scores and calculate an average score. 
            // It should then return a message of "pass" or "fail" depending on these two conditions:
            // If the average score is greater than or equal to 70 and no single test score is below 50, then return a message of "pass".
            // If the average score is lower than 70 or at least one test score is below 50, then return a message of "fail".
        }

        static void GradeTestScores(int gradeInput, int testscores.Length)
        {
            foreach (var gradeInput in testScores)
            {

            }
            if () && ();

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
