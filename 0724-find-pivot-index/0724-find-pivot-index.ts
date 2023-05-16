function pivotIndex(A: number[]): number {
  const arrLenght = A.length;
  let leftSum, rightSum;
  let totalSum = 0;

  for(let num of A) {
    totalSum += num;
  }

  for(let i = 0; i < arrLenght; i++) {
    if(i === 0) {
        leftSum = 0;
    } else if(i === arrLenght - 1) {
        rightSum = 0;
    }
    rightSum = totalSum - A[i] - leftSum;
    if(leftSum === rightSum) return i;
    leftSum += A[i];

  }
        
  return -1;
};