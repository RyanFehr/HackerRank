//Problem: https://www.hackerrank.com/challenges/designer-pdf-viewer
//JavaScript
/*
Initial Thoughts:
We can iterate through each letter in the string
converting the char into its charCode. Because we 
know all characters will be lower case we can subtract
97 to get a base 0 (i.e. 'a' = 0, 'b' = 1, ...). We find 
the tallest height then multiply that by the length of 
the string which will give us our desired area.

Time complexity: O(n)  //Iterate over the String 
Space complexity: O(n) //Store the string
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
    let h = readLine().split(' ').map(Number),
        word = readLine(),
        maxHeight = 1;
    for (let letter of word) {
        maxHeight = Math.max(maxHeight, h[letter.charCodeAt(0) - 97]);
        if (maxHeight === 7) break;
    }
    console.log(maxHeight * word.length);
}
