//Problem: https://www.hackerrank.com/challenges/greedy-florist
//JavaScript
/*
Initial Thoughts: 
If we have more friends than flowers we can just add up all the
flowers and return the total, else we can to sort the flowers 
in descending order and add up the total recognizing that we will 
by less of the most expensive flowers and more of the cheaper 
flowers

Time Complexity: O(N log N) //we sort the array in descending order
Space Complexity: O(n) //We have to store the input
*/
function processData(input) {
    let setup = input.split("\n"),
        params = setup[0].split(' ').map(Number),
        flowers = setup[1].split(' ').map(Number).sort((a,b) => b - a),
        N = params[0],
        K = params[1], 
        total = 0;
    if (K >= N) {
        console.log(flowers.reduce( (prev, curr) => prev + curr ));    
    } else {
        for (let i = 0; i < N; i++) {
            total += Math.floor(i / K + 1) * flowers[i];
        }    
        console.log(total);
    }
} 

/////////////// ignore below code \\\\\\\\\\\\\\

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
