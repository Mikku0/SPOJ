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
            int nums = int.Parse(numbers[0].ToString());
            int[] list = new int[nums];
            string[] numsArray = numbers.Split(' ');
            int index = nums - 1;
            for (int j = 1; j < nums; j++){
                list[j] = int.Parse(numsArray[index]);
                index--;
            }
            foreach(var item in list)
            {
                Console.Write(item.ToString() + ' ');
            }
        }
    }
}