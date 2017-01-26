function solve(args) {
    let x = Number(args[0]);
    let y = Number(args[1]);
    let distance = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2)).toFixed(2);

    if (distance > 2 || distance < -2) {

        console.log("no " + distance);
    }
    else {
        console.log("yes " + distance);
    }
}
solve(['1.5', '-1']);