//Problem: https://www.hackerrank.com/challenges/angry-professor
//JavaScript
/*
Initial Thoughts:
We need to count the number of students whose arrival
time is less than or equal to 0. If this count is less 
than k, then the class is cancelled. Otherwise, it is not.

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
    for(let a0 = 0; a0 < t; a0++) {
        let n_temp = readLine().split(' '),
            n = parseInt(n_temp[0]),
            k = parseInt(n_temp[1]),
            a = readLine().split(' ').map(Number),
            onTime = 0;
        for (let student of a) {
            if (student <= 0) {
                onTime++;
            }
        }
        console.log(onTime >= k ? "NO" : "YES");
    }
}
