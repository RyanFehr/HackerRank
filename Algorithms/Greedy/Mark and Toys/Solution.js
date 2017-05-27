//Problem: https://www.hackerrank.com/challenges/mark-and-toys
//JavaScript
/*
Initial Thoughts: 
We can sort the toy  prices ascending then
substract their prices from our total money
until we can no longer buy any more toys, 
and since they are sorted in ascending order
we know that if we can't buy the current toy
then we can't buy any others either

Time Complexity: O(n log(n)) //It takes n log n time to sort the array
Space Complexity: O(n) //We allocate an array to store the input
*/
function processData(input) {
    let setup = input.split("\n"),
        params = setup[0].split(' ').map(Number),
        toys = setup[1].split(' ').map(Number).sort((a,b) => a - b),
        toyNum = params[0],
        money = params[1],
        total = 0;
    while (money > 0 && total < toyNum) {
        money -= toys[total];
        total++;
    }
    console.log((total === toyNum) ? toyNum : total - 1);
} 

/////////////// ignore below code \\\\\\\\\\\\\\\

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
