We know that maximum window size can be of max length of the array.
​
Therefore, we will do a binary search on all the window size from 1 to n (max length of an array).
​
Whenever we get a window where the sub-array sum >= target we will decreament our window size (end = mid - 1) as we have to find a window with least size.
​
Else we will increase the window size (start = mid + 1).