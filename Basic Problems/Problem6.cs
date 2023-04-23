using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
        string my_string = str;
        
        
        string[] words = my_string.Split(" ");
        
        string result = "";
        
        foreach(string word in words){
            string temp_result = word.Substring(1) + word[0];
            bool hasLetters = temp_result.Any(char.IsLetter);
            if(hasLetters){
                temp_result += "ay";
            }
            result += temp_result + " ";
        }
    
        
        
        return result.TrimEnd();
  }
}