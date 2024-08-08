/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function(nums, k) {
    const ans = [];
    const numOfRotation = k % nums.length;

    for(let i = nums.length - numOfRotation; i < nums.length; i++) {
        ans.push(nums[i]);
    }

    for(let i = 0; i < nums.length - numOfRotation; i++) {
        ans.push(nums[i]);
    }

    for(let i = 0; i < nums.length; i++) {
        nums[i] = ans[i];
    }

    console.log(ans, nums);
};