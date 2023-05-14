function groupAnagrams(strs: string[]): string[][] {
    const groupMap = {};
    const answer = [];
    const strArrLen = strs.length;

    for(let i = 0; i < strArrLen; i++) {
        const currWord = strs[i];
        const sortedCurrWord = sortWord(currWord);

        if(groupMap.hasOwnProperty(sortedCurrWord)) {
            groupMap[sortedCurrWord].push(currWord);
        }
        else {
            groupMap[sortedCurrWord] = [];
            groupMap[sortedCurrWord].push(currWord);
        }
    }

    for(let key in groupMap) {
        answer.push(groupMap[key]);
    }

    return answer;

};

function sortWord(word: string) {
    return [...word].sort((a, b) => a.localeCompare(b)).join("");
}
