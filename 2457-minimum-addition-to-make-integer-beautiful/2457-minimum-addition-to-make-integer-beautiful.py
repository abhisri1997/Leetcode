class Solution:
    def makeIntegerBeautiful(self, n: int, target: int) -> int:

        #function for finding the sum of the digits of a number
        def digit_sum(n):
            return sum([int(c) for c in str(n)])
        
        lst = 1 # the number of zeros we want to leave at the end
        add = 0
        
        #A problem for one idea: 
        #if the sum of digits is greater than target, it is most optimal to make the last few digits equal to zero
        
        while digit_sum(n + add) > target:
            x = 10 ** lst
            add = x - n % x
            lst += 1
        
        return add
        #O(n *lg(n)) - Time
        #O(1) - Space
