public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
        int east = 0;
        int west = 0;
        int north = 0;
        int south = 0;
        
        int totWalked = 0;
        
        foreach(string dir in walk){
            if(dir == "n"){
                north++;
            }else if(dir == "s"){
                south++;
            }else if(dir == "e"){
                east++;
            }else if(dir == "w"){
                west++;
            }
            totWalked++;
        }
        
        
        
        if(north == south && west == east && totWalked == 10){
            return true;
        }else{
            return false;
        }
  }
}