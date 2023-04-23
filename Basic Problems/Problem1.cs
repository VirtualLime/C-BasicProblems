using System;

public static class Kata
{
  public static string[] Last(string x)
  {
    
    string[] my_array = x.Split(" ");
    
    
    Array.Sort(my_array, (a,b) => a[a.Length-1].CompareTo(b[b.Length-1]));
    
    
    return my_array;
  }
}