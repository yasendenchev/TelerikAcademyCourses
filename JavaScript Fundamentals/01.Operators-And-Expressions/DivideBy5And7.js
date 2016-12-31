function solve(args) {
    let input = args[0];
    if (input % 5 === 0 && input % 7 === 0) {
        console.log("true " + input);
    }
    else {
        console.log("false " + input);
    }
}
