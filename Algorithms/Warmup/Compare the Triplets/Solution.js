// Problem: https://www.hackerrank.com/challenges/compare-the-triplets/problem
// JS

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
