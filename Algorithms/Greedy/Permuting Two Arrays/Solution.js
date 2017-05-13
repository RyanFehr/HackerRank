//Problem: https://www.hackerrank.com/challenges/two-arrays
//JavaScript
/*
Initial Thoughts: 
We can sort array A ascending and sort array B descending,
and then for every i we check if the condition A[i] + B[i] >= k
holds true (or not) for each index i. If the condition fails
on the sorted arrays, then there exists no permutation of 
A and B satisfying the inequality.
                  
Time Complexity: O(n log(n)) //We must sort the input arrays
Space Complexity: O(n) //We must store the input arrays 

*/
function processData(input) {
    let q = input[0], setup, n, k, a, b;
    for(let i = 0; i < q; i++) {
        setup = input[i * 3 + 1].split(' ').map(Number);
        n = setup[0];
        k = setup[1];
        a = input[i * 3 + 2].split(' ').map(Number);
        b = input[i * 3 + 3].split(' ').map(Number);
        console.log(Permutable(a,b, n, k) ? "YES" : "NO");
        
    } 
} 

function Permutable(a,b, n, k) {
    a.sort((a,b) => a - b);
    b.sort((a,b) => b - a);
    for (let i = 0; i < n; i++) {
        if (a[i] + b[i] < k) {
            return false;
        }
    }
    return true;
}

/////////////// ignore below this line ////////////////////

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input.split("\n"));
});
