function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = Number(args[2]);
    let biggest;
    if (a >= b && a >= c) {
        biggest = a;
    }

    else if (b >= a && b >= c) {
        biggest = b;
    }

    else if (c >= a && c >= b) {
        biggest = c;
    }
    console.log(biggest);
}
solve(['-2', '-2', '1']);