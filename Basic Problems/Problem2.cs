public class LandPerimeter
{
    public static string Calculate(string[] map)
    {
        int sumPerimeter = 0;
        
        int length = map.Length;
        int subsetLength = map[0].Length;
        
        
        for(int row = 0; row < map.Length; row++){

            for(int col = 0; col < map[row].Length; col++){
                int maxPerim = 4;
                if(map[row][col] != 'X'){
                    continue;
                }
                
                //Up
                if(row-1 >= 0){
                    if(map[row][col] == map[row-1][col]){
                        maxPerim -= 1;
                    }
                }
                //Down
                if(row+1 < length){
                    if(map[row][col] == map[row+1][col]){
                        maxPerim -= 1;
                    }
                }
                //Left
                if(col-1 >= 0){
                    if(map[row][col] == map[row][col-1]){
                        maxPerim -= 1;
                    }
                }
                //Right
                if(col + 1 < subsetLength){
                    if(map[row][col] == map[row][col+1]){
                        maxPerim -= 1;
                    }
                }

                sumPerimeter += maxPerim;
            }
        }
        return "Total land perimeter: " + sumPerimeter.ToString();
    }
}