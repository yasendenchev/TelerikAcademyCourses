function solve(args) {
    let x = Number(args[0]);
    let y = Number(args[1]);
    let isInCircle;
    let isInRectangle;
    let distanceFromCenter = (Math.pow(x - 1, 2)) + (Math.pow(y - 1, 2));
    let radius = 1.5;

    if (distanceFromCenter <= Math.pow(radius, 2)) {

        isInCircle = "inside circle ";
    }

    else {
        isInCircle = "outside circle ";
    }

    if (x < -1 || x > 5 || y > 1 || y < -1) {
        isInRectangle = "outside rectangle";
    }

    else {
        isInRectangle = "inside rectangle";
    }
    console.log(isInCircle + isInRectangle);
}
solve(['2.5', '2']);