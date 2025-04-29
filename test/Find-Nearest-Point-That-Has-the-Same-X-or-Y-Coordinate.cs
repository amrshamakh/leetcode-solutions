public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        /*
        idea: find the nearest point that has the same coordinates x or y with the smallest manahattan distance from x,y
        edgecase:if there is no points valid x !=x2 and y!=y2 return -1;
        approach: iterate over the points and check every point if x=x2 or y=y2 then calc the the mana distance from x,y 
        and compare it with the minimum distance if it less than it updata the min with it then search for the nearest 
        point have the min distance 
        */
        int manhaDistance=int.MaxValue;
        int resultindex=-1;
        for(int i=0;i<points.Length;i++){
            int x2=points[i][0],y2=points[i][1];
            if(x==x2||y==y2){
           int Distance= Math.Abs(x-x2)+Math.Abs(y-y2);
             if(Distance<manhaDistance){
                manhaDistance=Distance;
                resultindex=i;
             }
            }
        }
        return resultindex;
    }
}