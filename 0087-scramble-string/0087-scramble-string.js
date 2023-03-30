/**
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
const isScramble = (s1, s2, memo = new Map()) => {
  if (s1 === s2) {
    return true;
  }
  if (s1.length !== s2.length || [...s1].sort().join("") !== [...s2].sort().join("")) {
    return false;
  }
  const key = `${s1},${s2}`;
  if (memo.has(key)) {
    return memo.get(key);
  }
  const n = s1.length;
  for (let i = 1; i < n; i++) {
    const s11 = s1.slice(0, i);
    const s12 = s1.slice(i);
    const s21 = s2.slice(0, i);
    const s22 = s2.slice(i);
    if (isScramble(s11, s21, memo) && isScramble(s12, s22, memo)) {
      memo.set(key, true);
      return true;
    }
    const s23 = s2.slice(0, n - i);
    const s24 = s2.slice(n - i);
    if (isScramble(s11, s24, memo) && isScramble(s12, s23, memo)) {
      memo.set(key, true);
      return true;
    }
  }
  memo.set(key, false);
  return false;
};
