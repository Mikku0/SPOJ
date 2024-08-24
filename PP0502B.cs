using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class PP0502B
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string numbers = Console.ReadLine();
            int nums = int.Parse(numbers.Split(' ')[0]);
            int[] list = new int[nums];
            string[] numsArray = numbers.Split(' ');
            int index = nums;

            for (int j = 0; j < nums; j++){
                list[j] = int.Parse(numsArray[index]);
                index--;
            }
            foreach(var item in list)
            {
                Console.Write(item.ToString() + ' ');
            }
            Console.WriteLine();
        }
    }
}