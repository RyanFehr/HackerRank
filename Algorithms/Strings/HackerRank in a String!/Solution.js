//Problem: https://www.hackerrank.com/challenges/hackerrank-in-a-string
//JavaScript
/*
Initial Thoughts:
We have an array of chars and
advance our position when we 
find a matching char in S and
if we reach the last index before
our string is done then we print YES
else we print NO

Time Complexity: O(n) //We have to iterate through the whole string
Space Complexity: O(1) //We just store the HackerRank array
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
    const HACKER_RANK = "hackerrank";
    var q = parseInt(readLine());
    for(var a0 = 0; a0 < q; a0++){
        let s = readLine(), i = 0;
        Array.prototype.map.call(s, function(x) {
            if (x === HACKER_RANK.charAt(i) && i < 10) i++;
        });
        console.log(i < 10 ? "NO" : "YES");
    }

}
