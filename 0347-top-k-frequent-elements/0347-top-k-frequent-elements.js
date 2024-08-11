/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function(nums, k) {
    const dict = {};
    const arrLen = nums.length;

    for(let i = 0; i < arrLen; i++) {
        const num = nums[i];

        if(!dict[num]) {
            dict[num] = 1;
        } else {
            dict[num] += 1;
        }
    }
    
    const helperArr = [];

    for(let key in dict) {
        helperArr.push([key, dict[key]]);
    }

    helperArr.sort((a,b) => b[1] - a[1]);

    const ans = [];

    for(let i = 0; i < k; i++) {
        ans.push(helperArr[i][0]);
    }

    return ans;
};


/*

let highestFreq = 0;
const highFreqSet = new Set();

for(let key in dict) {
    const currElFreq = dict[key];

    if(currElFreq > highestFreq) {

        if(ans.length > )
        ans.push(key);
        highestFreq = currElFreq;
        highFreqSet.add(highestFreq);
    }
}

*/