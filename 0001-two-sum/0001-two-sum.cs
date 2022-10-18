public class Solution {
    public int[] TwoSum(int[] A, int B) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i<A.Count(); i++) {
            if(!map.ContainsKey(A[i]))
            {
                map.Add(A[i],i);
            }
            else
            {
                map[A[i]] = i;
            }
  }
        for(int i = 0; i < A.Count(); i++){
            int diff = B - A[i];
            if(map.ContainsKey(diff) && map[diff] != i){
                return new int[] {i,map[diff]};
            }
        }
        return null;
    }
}