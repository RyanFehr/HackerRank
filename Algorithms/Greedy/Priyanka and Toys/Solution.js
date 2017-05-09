//Problem: https://www.hackerrank.com/challenges/priyanka-and-toys
//JavaScript
/*
Initial Thoughts: 
We can sort the toys ascending by weight,
then we just iterate over it not counting 
when we get the next 4 consecutive weight
toys for free
                 
Time Complexity: O(n log(n)) //We have to sort the toys by weight
Space Complexity: O(n) //We store the input in a dynamically allocated array
*/
function processData(input) {
    let weights = input.split("\n")[1].split(' ').map(Number),
        value = weights.sort((a, b) => a - b)[0],
        units = 1;
    for (let weight of weights) {
        if (weight > value + 4) {
            value = weight;
            units++;
        }
    }
    console.log(units);
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
