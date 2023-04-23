using System;
using System.Collections.Generic;

public class Kata
{
  public static int SquareDigits(int n)
  {
        int mutateNum = n;
        
        List<int> digits = new List<int>();
    
        if(mutateNum == 0){
            digits.Add(0);
        }
        
        while(mutateNum > 0){
            int digit = mutateNum % 10;
            digits.Add(digit);
            mutateNum /= 10;
        }
    
        digits.Reverse();
        
        int length = digits.Count;
        
        string append_string = "";
        
        for(int i = 0; i < length; i++){
           double temp_sum = Math.Pow(digits[i], 2);
           string temp_string = temp_sum.ToString();
           append_string += temp_string;
        }
        
        int result = int.Parse(append_string);
    
        return result;
    

  }
}