//Problem: https://www.hackerrank.com/challenges/strange-advertising
//JavaScript
/*
Initial Thoughts:
This is a straightforward problem which can be 
solved using brute force. To solve it, we simply 
run a loop simulating the sequence of events.

Time complexity: O(n)  //Iterate n number of days 
Space complexity: O(1) 
*/
function processData(input) {
        let reached = 2, 
            sharing = 2;
        for(let day = 1; day < input; day++)
        {
            reached += Math.floor((sharing * 3) / 2);
            sharing = Math.floor((sharing * 3) / 2);
        }
    console.log(reached);
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
