/**
 * @param {number[]} cardPoints
 * @param {number} k
 * @return {number}
 */

const prefixSum = (arr,n) => {
    for(let i = 1; i <= n; i++){
        arr[i] = arr[i-1] + arr[i];
    }
    return arr;
}

const maxSelectionSum = (arr,n,b) => {
    let start = 0;
    let end = b;
    let maxSum = Number.NEGATIVE_INFINITY;
    let maxSelection = 0;
    let lSelection = 0;
    let rSelection = 0;

    while(start <= end){
        if(start === 0) {
            lSelection = arr[end-1];
            rSelection = arr[n] - arr[n-end];
        } else {
            lSelection = arr[start -1] + arr[n] - arr[n-end];
            rSelection = arr[end -1] + arr[n] - arr[n-start];
        }
        maxSelection = Math.max(lSelection,rSelection);
        if(maxSelection>maxSum){
            maxSum = maxSelection;
        }
        start++;
        end--;
    }
    return maxSum;
}


var maxScore = function(A, k) {
    let n = A.length - 1;
    
    prefixSum(A,n);

    return maxSelectionSum(A,n,k);
};