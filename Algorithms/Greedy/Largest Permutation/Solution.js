//Problem: https://www.hackerrank.com/challenges/largest-permutation
//JavaScript
/*
Initial Thoughts: 
We traverse the array making sure each index (i) is equal to N - i.  
When we find an index that does not equal N - i we swap it with the 
index that has the value N - i. We do this K number of times.

Optimization:
Traverse the array storing the index of each value in an auxiliary 
index array. This will allow us to know the index of N - i right 
away instead of having to look for it each time array[i] != N - i

Time Complexity: O(n) //we have to traverse the entire array to get each values index
Space Complexity: O(n) //We allocate two array to store the input and indexes
*/
function processData(input) {
    let setup = input.split("\n"),
        params = setup[0].split(' ').map(Number),
        n = params[0],
        sweeps = params[1],
        index = [],
        arr = setup[1].split(' ').map(Number);
    for (let int in arr) {
        index[arr[int]] = int;
    }
    for (let i = 0; i < n && sweeps > 0; i++) {
        if (arr[i] === n - i) {
            continue;
        }
        arr[index[n - i]] = arr[i];
        index[arr[i]] = index[n - i];
        arr[i] = n - i;
        index[n - i] = i;
        sweeps--; 
    }
    console.log(arr.join(" ").trim());
} 

/////////////// ignore below code \\\\\\\\\\\\\\\

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
    processData(_input);
});

