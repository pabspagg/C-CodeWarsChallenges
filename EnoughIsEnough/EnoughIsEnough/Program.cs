using System;
using System.Collections.Generic;
using System.Linq;

Kata.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);
public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (result.Count(i => i == item) < x)
                    result.Add(item);
            }
            return result.ToArray();
        }
 }

