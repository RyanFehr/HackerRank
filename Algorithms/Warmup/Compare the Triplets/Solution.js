// Problem: https://www.hackerrank.com/challenges/compare-the-triplets/problem
// JS
/*
Initial Thoughts:
We receive 2 arrays (a for Alice and b for Bob) of exactly 3 elements each
We have to compare each of the 3 elements in one array to its counterpart in the other array
Based on the comparison we have to add points to either Alice or Bob and return both individuals' points in one array where item 0 is Alice's points and item 1 is Bob's
We initialize an array [0,0] and increment it based on the comparisons

Time Complexity: O(1);
Space Complexity: O(1);
*/

'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

// Complete the compareTriplets function below.
function compareTriplets(a, b) {
    const r = [0,0];
    a[0] === b[0] ? null : a[0] > b[0] ? r[0]++ : r[1]++;
    a[1] === b[1] ? null : a[1] > b[1] ? r[0]++ : r[1]++;
    a[2] === b[2] ? null : a[2] > b[2] ? r[0]++ : r[1]++;
    return r;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const a = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));

    const b = readLine().replace(/\s+$/g, '').split(' ').map(bTemp => parseInt(bTemp, 10));

    const result = compareTriplets(a, b);

    ws.write(result.join(' ') + '\n');

    ws.end();
}
