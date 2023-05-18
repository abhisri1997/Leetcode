//{ Driver Code Starts
//Initial Template for javascript

'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

class Node{
    constructor(data){
        this.data = data;
        this.left = null;
        this.right = null;
    }
}
function main() {
    let t = parseInt(readLine());
    let i = 0;
    for(;i<t;i++)
    {  
        let n = parseInt(readLine());
        let input = readLine().trim().split(" ");
        let root = null;
        let j=0;
        let q = [];
        while(n > 0){
            let a1 = parseInt(input[j]);
            let a2 = parseInt(input[j+1]);
            let lr = input[j+2];
            j+=3;
            
            if(root === null)
            {
                root = new Node(a1);
                q.push(root);
            }
            
            let pick = q[0];
            
            q.shift();
            
            if(lr=='L'){
                pick.left = new Node(a2);
                q.push(pick.left);
            }
            a1 = parseInt(input[j]);
            a2 = parseInt(input[j+1]);
            lr = input[j+2];
            j += 3;
            
            if(lr=='R'){
                pick.right = new Node(a2);
                q.push(pick.right);
            }
            
            n-=2;
        }

        let obj = new Solution();
        let res = obj.sumBT(root);
        console.log(res.toString());        
    }
}


// } Driver Code Ends


//User function Template for javascript

/*
class Node{
    constructor(data){
        this.data = data;
        this.left = null;
        this.right = null;
    }
}
*/

 /**
   * @param {Node} root
   * @return {number}
  */

class Solution
{
    sum = 0;
    sumBT(root){
        if(root === null) return 0;
        this.sum += root.data;
        this.sumBT(root.left);
        this.sumBT(root.right);
        return this.sum;
    }
}  