//Problem: https://www.hackerrank.com/challenges/migratory-birds
//JavaScript
/*
Initial Thoughts: 
We can create an array of size 6. Indexes 1 - 5 
represent each type of bird. Now we read in
each bird and increment that birds index by one.
Finally print out the index with the largest value.

Time Complexity: O(n)   
Space Complexity: O(1) 
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
    types = readLine().split(' ');
    arrOftype = types.map(Number);
    let birds = [-1, 0, 0, 0, 0, 0];
    for (let type of arrOftype) {
        birds[type]++;
    }
    console.log(birds.indexOf(Math.max(...birds))); //Print the index with the highest value
}
