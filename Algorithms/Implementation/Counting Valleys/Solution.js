//Problem: https://www.hackerrank.com/challenges/counting-valleys
//JavaScript
/*
Initial Thoughts:
Iterate over the ups and downs keeping track of 
your distance from sea level and whenever you make
the transition to below increase a value and repeat
that for each time you make the transition

Time Complexity: O(n) //We need to iterate over the whole hike
Space Complexity: O(1) //We do no use any dynamically sized variables
*/


function processData(input) {
    var level = 0, vallies = 0;
    var slopes = input.split("\n", 2)[1];
    for (var i in slopes) {
        level = (slopes.charAt(i) == 'U') ? level + 1 : level - 1;  //Increase/decrease sea level 
        if (level === 0 && slopes.charAt(i) === 'U') {              //Check for transition of sea level
            vallies++;                                  
        }
    }
    console.log(vallies);
} 
////////// BOILERPLATE PLATE CODE \\\\\\\\\\
process.stdin.resume();
process.stdin.setEncoding("ascii");
var _input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
