using System;
using System.Collections.Generic;


public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        int[] nums = args;
        
        List<string> result = new List<string>();
        
        int firstNum = 0;
        int lastNum = 0;
        
        int length = nums.Length;
        int count = 0;
        int rangeCount = 0;
        
        
         foreach(int num in nums){
            if(count == length - 1 && rangeCount >= 2){
                result.Add(firstNum + "-" + num);
                break;
            }
            else if(count == length - 1 && rangeCount == 1){
                result.Add(firstNum.ToString());
                result.Add(num.ToString());
                break;
            }
            else if(count == length - 1){
                //result.Add(firstNum.ToString());
                result.Add(num.ToString());
                break;
            }
            else if((nums[count+1] == (num + 1)) && rangeCount < 2){
                if(rangeCount == 0){
                    firstNum = nums[count];
                }
                rangeCount++;
            }
            else if((nums[count + 1] != (num + 1)) && rangeCount < 2){
                if(rangeCount == 1){
                    result.Add(firstNum.ToString());
                    result.Add(num.ToString());
                }else{
                    result.Add(num.ToString());
                }
                firstNum = 0;
                lastNum = 0;
                rangeCount = 0;
            }
            else if((nums[count+1] == (num + 1)) && rangeCount >= 2){
                rangeCount++;
            }
            else if((nums[count+1] != (num + 1)) && rangeCount >= 2){
                lastNum = num;
                result.Add(firstNum + "-" + lastNum);
                firstNum = 0;
                lastNum = 0;
                rangeCount = 0;
            }
            else{
                result.Add(num.ToString());
            }
            count++;
            
        }
      
        string combinedString = string.Join( ",", result.ToArray() );
      
        return combinedString;
      
    }
}