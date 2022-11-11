public class Solution {
    
    public int RemoveDuplicates(int[] nums) {
        int prev = nums[0];
        int count = 1;
        int max = int.MinValue;
        
        if(nums.Count() == 2 && nums[0] == nums[1]){
            return 1;
        }
        
        for(int i = 0; i < nums.Count(); i++){
            if(max < nums[i]){
                max = nums[i];
            }
        }
        
        for(int i = 1; i < nums.Count(); i++){
            int curr = nums[i];
            if(curr > prev){
                nums[count] = curr;
                prev = curr;
                count++;
                if(prev == max){
                    break;
                }
            }
        }

        return count;
    }
}