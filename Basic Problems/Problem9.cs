using System;
using System.Collections.Generic;


public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
        int width = (nFloors * 2) - 1;
        
        int end = width / 2;
        int start = width / 2;
        
        List<string> list = new List<string>();
        
        string temp = "";
        
        for(int i = 0; i < nFloors; i++){
            for(int j = 0; j < width; j++){
                if(j >= start && j <= end){
                    temp += "*";
                }else{
                    temp += " ";
                }
            }
            list.Add(temp);
            temp = "";
            start -= 1;
            end += 1;
        }
    
        return list.ToArray();
  }
}