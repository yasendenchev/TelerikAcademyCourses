function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = args[2];
    let sign = 0;

    if (a > 0) {

        if (b > 0) {

            if (c > 0) {

                sign = "+";
            }

            else if (c < 0) {
                sign = "-";
            }
        }

        else if (b < 0) {

            if (c > 0) {
                sign = "-";
            }

            else if (c < 0) {
                sign = "+";
            }
        }
    }

    else if (a < 0) {

        if (b > 0) {

            if (c > 0) {

                sign = "-";
            }

            else if (c < 0) {
                sign = "+";
            }
        }

        else if (b < 0) {

            if (c > 0) {
                sign = "+";
            }

            else if (c < 0) {
                sign = "-";
            }
        }
    }

    console.log(sign);
}
solve(['0', '4', '3']);