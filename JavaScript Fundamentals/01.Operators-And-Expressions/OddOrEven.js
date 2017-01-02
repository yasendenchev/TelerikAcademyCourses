function solve(args) {
    let input = args[0];
    if (input % 2 === 0) {
        console.log("even " + input);
    }
    else {
        console.log("odd " + input);
    }
}
solve(['5']);
solve(['10']);
