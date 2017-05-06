//Problem: https://www.hackerrank.com/challenges/apple-and-orange
//JavaScript
/*
Initial Thoughts:
We can iterate through both sets of fruit and calculate the position
of a fruit by adding its distance from its tree to the position of
the tree. Count the fruit only falls on Sam's house.
i.e. s <= fruit's position <= t 


Time complexity: O(n+m) //Iterate through both arrays
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
    var s_temp = readLine().split(' ');
    var s = parseInt(s_temp[0]);
    var t = parseInt(s_temp[1]);
    var a_temp = readLine().split(' ');
    var a = parseInt(a_temp[0]);
    var b = parseInt(a_temp[1]);
    var m_temp = readLine().split(' ');
    var m = parseInt(m_temp[0]);
    var n = parseInt(m_temp[1]);
    apple = readLine().split(' ');
    apple = apple.map(Number);
    orange = readLine().split(' ');
    orange = orange.map(Number);
    console.log(fruitsInHouse(apple, a, [s, t]));
    console.log(fruitsInHouse(orange, b, [s, t]));
}

function fruitsInHouse(fruits, start, house) {
    let totalFruit = 0;
    for (let fruit of fruits) {
        if (house[0] <= start + fruit && start + fruit <= house[1]) {
            totalFruit++;
        }
    }
    return totalFruit;
}