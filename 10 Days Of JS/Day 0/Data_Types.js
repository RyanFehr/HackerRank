function performOperation(secondInteger, secondDecimal, secondString) {
    // Declare a variable named 'firstInteger' and initialize with integer value 4.
    const firstInteger = 4;
    var secondIntegerr = parseInt(secondInteger, 10);
    console.log(firstInteger + secondIntegerr);
    
    // Declare a variable named 'firstDecimal' and initialize with floating-point value 4.0.
    const firstDecimal = 4.0;
    var secondDecimall = parseFloat(secondDecimal);
    console.log(firstDecimal + secondDecimall);
    
    // Declare a variable named 'firstString' and initialize with the string "HackerRank".
    const firstString = 'HackerRank ';
    console.log(firstString.concat(secondString));
}