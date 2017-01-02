function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = Number(args[2]);
    let discriminant = Math.pow(b, 2) - (4 * a * c);
    let x1, x2;


    if (discriminant < 0) {
        console.log("no real roots");
    }

    if (discriminant === 0) {
        x1 = (-b) / (2 * a);
        console.log("x1=x2=" + x1.toFixed(2));
    }

    else if (discriminant > 0) {
        x2 = ((-b) + Math.sqrt(discriminant)) / (2 * a);
        x1 = ((-b) - Math.sqrt(discriminant)) / (2 * a);
        console.log("x1=" + x1.toFixed(2) + "; x2=" + x2.toFixed(2));

    }
}
solve(['5', '2', '8']);