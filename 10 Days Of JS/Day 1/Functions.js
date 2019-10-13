/*
 * Create the function factorial here
 */
function factorial(n) {
    let fact = 1;
    for (var i = 1; i <= n; i++){
        fact = fact * i;
    }
    return fact;
}