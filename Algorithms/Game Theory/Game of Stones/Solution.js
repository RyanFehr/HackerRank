//Problem: https://www.hackerrank.com/challenges/game-of-stones-1
//JavaScript
/*
Initial Thoughts: 
From the explanation given it can be determined that 
if the number of stones mod 7 is equal to or less than 1
player two will win else player one will win.


Time Complexity: O(n) //Iterate over inputs
Space Complexity: O(1)
*/
function processData(input) {
    for (let stones of input.split("\n").slice(1)) {
        console.log((stones % 7 <= 1) ? "Second" : "First");
    }
} 

/////////////// ignore below this line \\\\\\\\\\\\\\\

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});

