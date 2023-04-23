using System;
using System.Collections.Generic;

public class Kata
{
  public static bool Narcissistic(int value)
  {

        int narcNumber = value;
    
        int mutateNum = narcNumber;
        
        List<int> digits = new List<int>();
        
        while(mutateNum > 0){
            int digit = mutateNum % 10;
            digits.Add(digit);
            mutateNum /= 10;
        }
        
        
        digits.Reverse();
        
        
        
        int length = digits.Count;
        
        double sum = 0;
        
        for(int i = 0; i < length; i++){
           double temp_sum = Math.Pow(digits[i], length);
           sum += temp_sum;
        }
    
        if(sum == narcNumber){
          return true;
        }else{
          return false;
        }
    
  }
}