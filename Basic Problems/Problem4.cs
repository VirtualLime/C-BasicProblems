public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
        int length = cc.Length;
        char[] charArray = cc.ToCharArray();
        
        int count = 0;
        foreach (char c in charArray)
        {
           if(count < length - 4){
               charArray[count] = '#';
           }
           count++;
        }
    
       string result = new string(charArray);
       return result;
    
  }
}