/**
 * @param {string} s
 * @param {number[]} indices
 * @return {string}
 */
var restoreString = function(s, indices) {
    let len = s.length;
    let ans = [];
    for(let i = 0; i < len; i++)
    {
        ans[indices[i]] = s[i];
    }
    console.log(ans);
    return ans.join("").toString();
};