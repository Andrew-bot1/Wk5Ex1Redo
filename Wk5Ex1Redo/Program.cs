using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex1Redo
{
    internal class Program
    {
        //declare list to store grades
        public static List<double> grades = new List<double> {};
        static void Main(string[] args)
        {
            //enter loop until user exits
            while (true)
            {
                //diplay menu
                Console.WriteLine("1: Add Grade\n2. Remove Grade\n3. Display Grade\n4. Calculate Average\n5. Find Highest and Lowest Grade\n6. Exit");
                //get input from user
                int choice = Convert.ToInt32(Console.ReadLine());

                //enter switch from input
                switch (choice)
                {
                    case 1:
                        //enter method to add grade
                        AddGrade();
                        break;
                    case 2:
                        //enter method to remove grade
                        RemoveGrade();
                        break;
                    case 3:
                        //enter method to display all grades
                        DisplayGrades();
                        break;
                    case 4:
                        //enter method to calculate average grade
                        Console.WriteLine($"Average grade: {AverageGrade()}");
                        break;
                    case 5:
                        //enter method to find highest and lowest grade
                        MaxMinGrades();
                        break;
                    case 6:
                        //exit program
                        Console.WriteLine("Exiting");
                        return;
                    default:
                        //display error message
                        Console.WriteLine("Invalid Input");
                            break;
                }
                
            }
        }

        //method to add grade
        static void AddGrade()
        {
            //ask user for grade
            Console.WriteLine("Enter grade: ");

            //get user input for grade
            double grade = Convert.ToDouble(Console.ReadLine());

            //cheack to see if grade is between 0 and 100
            if ((grade < 0) || (grade > 100)) {
                //display error
                Console.WriteLine("Grade must be between 0 and 100");
             
            }
            else
            {
                //insert grade into list
                grades.Add(grade);
            }

        }

        //method to remove grade
        static void RemoveGrade()
        {
            //ask user for grade
            Console.WriteLine("Enter grade: ");

            //get user input for grade
            double grade = Convert.ToDouble(Console.ReadLine());

            //remove grade from list
            grades.Remove(grade);
        }

        //method to display all grades
        static void DisplayGrades()
        {
            //loop through all grades in list
            foreach (var grade in grades)
            {
                //display grades
                Console.WriteLine(grade);
            }

        }


        //method to calculate average grade
        static double AverageGrade()
        {
            //declare return value
            double avg = 0;

            //declare counter
            int count = 0;

            //loop through list
            foreach (var grade in grades)
            {
                //add grade to return variable
                avg += grade;

                //increase counter
                count++;
            }

            //return average grade
            return avg/count;
        }

        //method to find highest and lowest grade
        static void MaxMinGrades()
        {
            //display highest and lowest grade
            Console.WriteLine($"Highest grade: {grades.Max()}, Lowest grade: {grades.Min()}");
        }
    }


}
