//Problem: https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array
//JavaScript
/*
Initial Thoughts: 
We can sort this array and then find the minimum
absolute value of the elements to the right of each 
element, because they will always be smaller than 
something further away, thus reducing the number 
of comparisons we need to do
                  
Time Complexity: O(n log n) //We only iterated n times, but it took n log n to sort the array
Space Complexity: O(1) //We can treat the input array as given, and we did our sort in place, so no addition space
*/
process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function main() {
    var n = parseInt(readLine());
    a = readLine().split(' ');
    a = a.map(Number).sort(function(a, b) { return a - b });
    let val, diff = Number.MAX_VALUE;
    for (let num of a) {
        if (val !== undefined) {
            diff = Math.min(diff, Math.abs(val - num));
        }
        val = num;
    }
    console.log(diff);
}
