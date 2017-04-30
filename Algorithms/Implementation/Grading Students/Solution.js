//Problem: https://www.hackerrank.com/challenges/grading
//JavaScript
/*
Initial Thoughts:
We can use division and multiplication
to find the next factor of 5 then
just check our conditions and
return the proper grade

Time Complexity: O(n) //the number of grades
Space Complexity: O(1)  //increment grades in place

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

function solve(grades){
    return grades.map(function(grade)  {
        return (grade >= 38 && grade % 5 >= 3) ? grade + 5 - (grade % 5) : grade;
    });
}

function main() {
    var n = parseInt(readLine());
    var grades = [];
    for(var grades_i = 0; grades_i < n; grades_i++){
       grades[grades_i] = parseInt(readLine());
    }
    var result = solve(grades);
    console.log(result.join("\n"));
}
