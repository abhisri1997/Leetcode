/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    const len = strs.length;
    const mapWord = {};
    const ans = [];

    for(let i = 0; i < len; i++) {
        const currWord = strs[i];
        // const sortedWord = currWord.split("").sort().join("");
        const uniqueKey = getCharFreqArr(currWord);
        if(!mapWord[uniqueKey]) {
            mapWord[uniqueKey] = [currWord]
        } else {
            mapWord[uniqueKey].push(currWord);
        }
    }

    for(let key in mapWord) {
        ans.push(mapWord[key]);
    }
    return ans;
};

function getCharFreqArr (word) {
    const freqArr = new Array(26).fill(0);
    const wordLen = word.length;

    for(let i = 0; i < wordLen; i++) {
        const currChar = word[i];
        const currCharASCII = currChar.charCodeAt(0) - 'a'.charCodeAt(0);

        freqArr[currCharASCII]++;
    }

    return freqArr;
}