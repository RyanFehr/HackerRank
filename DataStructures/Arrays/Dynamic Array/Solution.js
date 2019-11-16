/*
         Problem: https://www.hackerrank.com/challenges/dynamic-array/problem
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
         - Straight-forward question. Just follow the instructions in the problem statement to reach to solution.
         - No optimization possible as such.
        Gotchas:
        <None>
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
 * Complete the 'dynamicArray' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. 2D_INTEGER_ARRAY queries
 */

function dynamicArray(n, queries) {
    // Write your code here
    const S = [];
    let lastAnwer = 0;

    let result = [];

    for (let i = 0; i < n; i++) {
        S[i] = []
    }

    for(let arr of queries) {
        const [q, x, y] = arr;
        const seq = ((x ^ lastAnwer) % n)

        switch(q) {
            case 1:
            S[seq].push(y);
            break;
            case 2:
            const size = S[seq].length;
            const index = y % size;
            lastAnwer = S[seq][index];
            result.push(lastAnwer);
            console.log(lastAnwer)
            break;
            default:
        }
    }

    return result


}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const firstMultipleInput = readLine().replace(/\s+$/g, '').split(' ');

    const n = parseInt(firstMultipleInput[0], 10);

    const q = parseInt(firstMultipleInput[1], 10);

    let queries = Array(q);

    for (let i = 0; i < q; i++) {
        queries[i] = readLine().replace(/\s+$/g, '').split(' ').map(queriesTemp => parseInt(queriesTemp, 10));
    }

    const result = dynamicArray(n, queries);

    ws.write(result.join('\n') + '\n');

    ws.end();
}
