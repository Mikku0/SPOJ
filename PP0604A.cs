using System;

// task: https://pl.spoj.com/problems/PP0604A/

public class PP0604A
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string nums = Console.ReadLine();
            string[] strNums = nums.Split(' ');

            int numCount = int.Parse(strNums[0]);

            int sum = 0;
            for (int j = 1; j <= numCount; j++)
            {
                sum += int.Parse(strNums[j]);
            }

            double avg = (double)sum / numCount;

            float closestNum = float.Parse(strNums[1]);
            double minDifference = Math.Abs(closestNum - avg);

            for (int j = 2; j <= numCount; j++)
            {
                float currentNum = float.Parse(strNums[j]);
                double difference = Math.Abs(currentNum - avg);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestNum = currentNum;
                }
            }

            Console.WriteLine(closestNum);
        }
    }
}
