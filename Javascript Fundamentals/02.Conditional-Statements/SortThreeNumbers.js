function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = Number(args[2]);

    if (a > b && a > c) {

        if (b > c) {
            console.log(a + " " + b + " " + c);
        }
        else {
            console.log(a + " " + c + " " + b);
        }
    }

    else if (b > a && b > c) {
        if (a > c) {
            console.log(b + " " + a + " " + c);
        }
        else {
            console.log(b + " " + c + " " + a);
        }
    }

    else if (c > a) {
        if (a > b) {
            console.log(c + " " + a + " " + b);
        }
        else {
            console.log(c + " " + b + " " + a);
        }
    }
}
solve(['2', '1', '20']);