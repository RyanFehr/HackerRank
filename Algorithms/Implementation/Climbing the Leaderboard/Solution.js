//Problem: https://www.hackerrank.com/challenges/climbing-the-leaderboard
//JavaScript
/*
Initial Thoughts:
We want to build a dense ranking map based on the scores as 
we read them in

Using that and a pointer variables we can iterate 1 time
over the scores array, advancing  an unknown number of steps
for each score that Alice has.

Time Complexity: O(n) //We only iterate over the scores and alice's scores once
Space Complexity: O(n) //We store the ranking map
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
    scores = readLine().split(' ');
    scores = scores.map(Number);
    var m = parseInt(readLine());
    alice = readLine().split(' ');
    alice = alice.map(Number);

    let map = rankScores(scores),
        index = scores.length - 1;
    for (let score of alice) {
        if (scores.length === 0) {
            console.log("1");
        } else {
            for (let i = index; i >= 0; i--) {
                index = i;
                if (score < scores[i]) {
                    console.log(map.get(scores[i]) + 1);
                    break;
                } else if (score === scores[i]) {
                    console.log(map.get(scores[i]));
                    break;
                } else if (i === 0) {
                    console.log("1");
                } 
            } 
        }
    }
}

function rankScores (scores) {
    let map = new Map(),
        rank = 1;
    for (let leaderScore of scores) {
        if (!map.has(leaderScore)) {
            map.set(leaderScore, rank++);
        }
    }
    return map;
}
