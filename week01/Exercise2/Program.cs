using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("What is your grade percentage? ");
            string input = Console.ReadLine();
            double gradePercentage = double.Parse(input);

            string letterGrade = "";
            string signaGrade = "";
            if (gradePercentage >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePercentage >= 80)
            {
                letterGrade = "B";
            }
            else if (gradePercentage >= 70)
            {
                letterGrade = "C";
            }
            else if (gradePercentage >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            if (gradePercentage % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
            {
                signaGrade = "+";
            }
            else if (gradePercentage % 10 < 3 && letterGrade != "F")
            {
                signaGrade = "-";
            }

            Console.WriteLine($"Your letter grade is: {letterGrade}{signaGrade}");

            if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass the class.");
            }

            Console.Write("Do you want to enter another grade? (yes/no): ");
            string continueInput = Console.ReadLine().ToLower();
            if (continueInput != "yes")
            {
                break;
            }
        }
    }
}