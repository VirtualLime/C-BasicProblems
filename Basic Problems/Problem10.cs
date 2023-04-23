using System;
using System.Linq;
using System.Collections.Generic;


public class Kata
{
  public static int[] SortArray(int[] array)
  {
        List<int> odd_numbers = new List<int>();
        
        string[] temp_array = array.Select(x=>x.ToString()).ToArray();
        
        int count = 0;
        
        foreach(string num in temp_array){
            int tempNum = int.Parse(num);
            if(tempNum % 2 != 0){
                odd_numbers.Add(tempNum);
                temp_array[count] = "X";
            }
            count++;
        }
        
        odd_numbers.Sort();
        
        count = 0;
        int oddCount = 0;
        
        foreach(string num in temp_array){
            if(num == "X"){
                array[count] = odd_numbers[oddCount];
                oddCount++;
            }
            count++;
        }
    
        return array;
  }
}