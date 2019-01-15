// Problem: https://www.hackerrank.com/challenges/picking-numbers/problem
// JS
/*
Initial Thoughts:
Since 0 < a[i] < 100 we can use an Array(100) to store the frequencies of the numbers
Then we run over our frequency array and extract the two adjancent elements that create the highest result
This solution isn't ideal for situations when a[i] increases dramatically, especially when n stays relatively small.
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

/*
 * Complete the 'pickingNumbers' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY a as parameter.
 */

function pickingNumbers(a) {
    let r = 0;
    const freq = new Array(100).fill(0);
    for (let i of a) {
        freq[i]++;
    }
    for (let i = 1; i < 100; i++)
        r = Math.max(freq[i - 1] + freq[i], r);
    return r;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    const a = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));

    const result = pickingNumbers(a);

    ws.write(result + '\n');

    ws.end();
}
