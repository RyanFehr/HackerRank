//Problem: https://www.hackerrank.com/challenges/electronics-shop
//JavaScript
/*
Initial Thoughts: 
We can sort and compare all pairs. If a pair is > max and <= s
then we set it as the new max. Then we eturn  max after 
checking all pairs.

Time Complexity: O(n * m) //Iterate over both arrays  
Space Complexity: O(1) //No additional memory used
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

function getMoneySpent(keyboards, drives, s){
    drives.sort((a, b) => a - b);
    keyboards.sort((a, b) => a - b);
    let max = -1;
    for (let d of drives) {
        for (let k of keyboards) {
            if (d + k <= s) {
                max = (d + k > max) ? d + k : max;
            }
        }
    }
    return max;
}

function main() {
    var s_temp = readLine().split(' ');
    var s = parseInt(s_temp[0]);
    var n = parseInt(s_temp[1]);
    var m = parseInt(s_temp[2]);
    keyboards = readLine().split(' ');
    keyboards = keyboards.map(Number);
    drives = readLine().split(' ');
    drives = drives.map(Number);
    //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
    var moneySpent = getMoneySpent(keyboards, drives, s);
    process.stdout.write(""+moneySpent+"\n");

}

