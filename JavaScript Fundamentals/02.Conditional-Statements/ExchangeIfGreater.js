function solve(args) {
    let a = args[0];
    let b = args[1];

    if (a > b) {
        a = args[1];
        b = args[0];
    }

    console.log(a + " " + b);

}
solve(['5', '4']);