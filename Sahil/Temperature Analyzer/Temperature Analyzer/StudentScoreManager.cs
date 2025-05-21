using System;
using System.Collections.Generic;

class StudentScoreManager
{
    public static void ManageScores()
    {
        Console.Write("Enter number of students: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Enter a positive integer.");
        }

        float[] scores = new float[n];
        for (int i = 0; i < n; i++)
        {
            float score;
            Console.Write($"Enter score for student {i + 1}: ");
            while (!float.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Enter a valid score between 0 and 100.");
            }
            scores[i] = score;
        }

        float sum = 0, max = float.MinValue, min = float.MaxValue;
        foreach (float score in scores)
        {
            sum += score;
            if (score > max) max = score;
            if (score < min) min = score;
        }

        float average = sum / n;

        Console.WriteLine($"\nAverage Score: {average:0.00}");
        Console.WriteLine($"Highest Score: {max}");
        Console.WriteLine($"Lowest Score: {min}");
        Console.WriteLine("Scores above average:");
        foreach (float score in scores)
        {
            if (score > average)
            {
                Console.WriteLine(score);
            }
        }
    }
}
