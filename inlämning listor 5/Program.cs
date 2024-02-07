using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> salaries = new List<double>();

        Console.WriteLine("Enter your salaries for the last months (enter 0 to finish):");

        double salary;
        do
        {
            string input = Console.ReadLine();
            if (!double.TryParse(input, out salary))
            {
                Console.WriteLine("Invalid input. Please enter a valid salary or 0 to finish.");
                continue;
            }

            if (salary != 0)
            {
                salaries.Add(salary);
            }
        } while (salary != 0);

        if (salaries.Count == 0)
        {
            Console.WriteLine("No salaries entered.");
            return;
        }

        double averageSalary = salaries.Average();
        Console.WriteLine($"Average salary: {averageSalary:C}");

        double medianSalary = CalculateMedian(salaries);
        Console.WriteLine($"Median salary: {medianSalary:C}");
    }

    static double CalculateMedian(List<double> numbers)
    {
        int count = numbers.Count;
        numbers.Sort();

        if (count % 2 == 0)
        {
            int middleIndex1 = count / 2 - 1;
            int middleIndex2 = count / 2;
            return (numbers[middleIndex1] + numbers[middleIndex2]) / 2;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}