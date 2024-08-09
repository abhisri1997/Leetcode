/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    const dict = {};
    const ans = [];
    const strLen = strs.length;

    for(let i = 0; i < strLen; i++) {
        const word = strs[i];
        const key = word.split('').sort().join('');

        if(!dict[key]) {
            dict[key] = [word]
        } else {
            dict[key] = [...dict[key], word]
        }
    }

    for(let key in dict) {
        ans.push(dict[key]);
    }

    return ans;
};