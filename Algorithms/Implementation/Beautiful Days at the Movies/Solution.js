//Problem: https://www.hackerrank.com/challenges/beautiful-days-at-the-movies
//JavaScript
/*
Initial Thoughts:
Simple brute-force is enough to solve this problem. 
Run a loop from i to j and for each number x check if 
abs(x - reverseOfX) % k === 0; if it does it's a 
Beautiful day

Time complexity: O(n)  //Iterate over each test case 
Space complexity: O(1) 
*/
function processData(input) {
    let setup = input.split(" "),
        i = parseInt(setup[0]),
        j = parseInt(setup[1]),
        k = parseInt(setup[2]),
        beautifulDays = 0;
    for (i; i <= j; i++) {
        let reverse = parseInt(i.toString().split("").reverse().join(""), 10);
        if (Math.abs(i - reverse) % k === 0) {
            beautifulDays++;
        }
    }
    console.log(beautifulDays);
} 

/////////////// ignore below this line ////////////////////

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
