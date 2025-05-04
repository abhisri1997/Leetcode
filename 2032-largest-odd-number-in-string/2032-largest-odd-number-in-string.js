/**
 * @param {string} num
 * @return {string}
 */
var largestOddNumber = function(num) {
    let index = -1;
    const strNoZero = removeZeroPrefixes(num);
    const strLength = strNoZero.length;

    for (let i = strLength - 1; i >= 0; i--) {
      const currNum = +strNoZero[i];
      const isOdd = currNum % 2 !== 0;

      if (isOdd) {
        index = i;
        break;
      }
    }

    if (+strNoZero === 0) return "";
    if (index === -1) return "";

    const requiredNum = strNoZero.substring(0, index + 1);

    return requiredNum;
};

function removeZeroPrefixes(s) {
    const strLength = s.length;
    let firstNonZeroIndex = -1;

    for (let i = 0; i < strLength; i++) {
      if (s[i] !== "0") {
        firstNonZeroIndex = i;
        break;
      }
    }

    return firstNonZeroIndex === 0 || firstNonZeroIndex === -1
      ? s
      : s.substring(firstNonZeroIndex);
  }