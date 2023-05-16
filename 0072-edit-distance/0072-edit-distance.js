/**
 * @param {string} word1
 * @param {string} word2
 * @return {number}
 */
function minDistance(word1, word2) {
    const m = word1.length;
    const n = word2.length;
    
    // Initialize a 2D array to store the edit distances
    const dp = new Array(m+1).fill(null).map(() => new Array(n+1).fill(0));
    
    // Initialize the first row and column with incremental values
    for (let i = 0; i <= m; i++) {
        dp[i][0] = i;
    }
    for (let j = 0; j <= n; j++) {
        dp[0][j] = j;
    }
    
    // Fill in the rest of the dp array using the recurrence relation
    for (let i = 1; i <= m; i++) {
        for (let j = 1; j <= n; j++) {
            if (word1[i-1] === word2[j-1]) {
                dp[i][j] = dp[i-1][j-1];
            } else {
                dp[i][j] = Math.min(
                    dp[i-1][j], // deletion
                    dp[i][j-1], // insertion
                    dp[i-1][j-1] // replacement
                ) + 1;
            }
        }
    }
    
    // The final answer is in the bottom right corner of the dp array
    return dp[m][n];
}