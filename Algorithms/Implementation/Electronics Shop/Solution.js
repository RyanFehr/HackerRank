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

function getMoneySpent(keyboards, drives, b) {
    let r = -1;
    keyboards.sort((a, b) => b - a);    //Desc
    drives.sort((a, b) => a - b);       //Asc
    for (let i = 0, j = 0; i < keyboards.length; i++)
        for (; j < drives.length; j++) {
            const tmp = keyboards[i] + drives[j];
            if (tmp > b)
                break;
            if (tmp > r)
                r = tmp;
        }
    return r;
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

