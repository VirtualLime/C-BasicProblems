using System;
using System.Collections.Generic;
public class Kata
{
  public static string DuplicateEncode(string word)
  {
        string output = "";
        
        Dictionary<char, int> counts = new Dictionary<char, int>();
        
        foreach (char c in word)
        {
                char lowerC = char.ToLower(c);
                if (!counts.ContainsKey(lowerC))
                {
                    counts[lowerC] = 1;
                }
                else
                {
                    counts[lowerC]++;
                }
        }
        
        foreach (char c in word)
        {
                char lowerC = char.ToLower(c);
                if (counts[lowerC] == 1)
                {
                    output += "(";
                }
                else
                {
                    output += ")";
                }
        }
    
    return output;
  }
}