public class Solution {
    public char BinarySearch(char[] arr, int start, int end, char x)
    {
      
      while(start < end)
      {
        int mid = start + ((end - start) >> 1);
        if(arr[mid] >  x) end = mid;
        else start = mid + 1;
      }
      return arr[start];
    }
    public char NextGreatestLetter(char[] letters, char target) {
        int len = letters.Length - 1;
        if(target == 'z' || target == letters[len] || target > letters[len]) return letters[0];
        return BinarySearch(letters, 0, len, target);
    }
}