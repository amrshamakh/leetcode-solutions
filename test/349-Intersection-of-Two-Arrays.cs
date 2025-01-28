public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
         List<int> result = new List<int>();
 
 Hashtable hashtable = new Hashtable();
 for (int i = 0; i < nums1.Length; i++) {
     if (!hashtable.ContainsKey(nums1[i]))
     hashtable.Add(nums1[i], i);
 }
 for (int i = 0; i < nums2.Length; i++) {
     if (hashtable.ContainsKey(nums2[i]))
     {
         if (!result.Contains(nums2[i]))
         {
             result.Add(nums2[i]);
         }

     }
 }
 return result.ToArray();
    }
}