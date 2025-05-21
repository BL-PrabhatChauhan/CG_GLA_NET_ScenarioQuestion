using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Analyzer
{
   public class TempAnalyzer
    {
        public static void AnalyzeTemperatures(float[,] temperatures)
        {
            int hottestDay = 0, coldestDay = 0;
            float maxTemp = float.MinValue, minTemp = float.MaxValue;
            float[] dailyAverages = new float[7];

            for (int day = 0; day < 7; day++)
            {
                float dailySum = 0;
                for (int hour = 0; hour < 24; hour++)
                {
                    float temp = temperatures[day, hour];
                    dailySum += temp;

                    if (temp > maxTemp)
                    {
                        maxTemp = temp;
                        hottestDay = day;
                    }
                    if (temp < minTemp)
                    {
                        minTemp = temp;
                        coldestDay = day;
                    }
                }
                dailyAverages[day] = dailySum / 24;
            }

            Console.WriteLine($"Hottest Day: Day {hottestDay + 1} with {maxTemp}°C");
            Console.WriteLine($"Coldest Day: Day {coldestDay + 1} with {minTemp}°C");
            Console.WriteLine("Average Temperature Per Day:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyAverages[i]:0.00}°C");
            }
        }
    }
}
