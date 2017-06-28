//Problem: https://www.hackerrank.com/challenges/utopian-tree
//JavaScript
/*
Initial Thoughts:
If the current season is summer, height will increase 
by one unit, i.e. tree++. Else, season will be spring
and height will double, i.e. tree = 2 * tree. 
The two seasons then alternate.

Time complexity: O(n)  //Iterate over each test case 
Space complexity: O(1) 
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
    let t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        let n = parseInt(readLine()),
            tree = 1;
        for (let i = 1; i <= n; i++) {
            if (i % 2 === 0) {
                tree++;
            } else {
                tree *= 2;
            }
        }
        console.log(tree);
    }

}
