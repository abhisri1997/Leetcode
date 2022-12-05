public class Solution {
    public long DividePlayers(int[] skill) {
        int len = skill.Count() - 1;
        Array.Sort(skill, (a,b) => a-b);
        int reqSum = skill[0] + skill[len];
        int i = 0, j = len;
        long chem = 0;
        
        while(i < j)
        {
          int sum = skill[i] + skill[j];
          if(sum != reqSum) return -1;
          else chem = chem + (skill[i] * skill[j]);
          i++;
          j--;
        }
        return chem;
    }
}