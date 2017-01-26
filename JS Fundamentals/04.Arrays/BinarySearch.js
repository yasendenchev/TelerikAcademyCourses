function solve(args) {
    let x = +args[args.length - 1];
    let n = +args[0];
    let arr = args.slice(1, args.length - 1);
    let l = +arr[0];
    let r = +arr[arr.length - 1];
    let m = 0;
    let result = 0;

    while (l <= r) {
        m = (l + r) / 2;
        m = Math.floor(m);
        if (m < x) {
            l = m + 1;
        }

        else if (m > x) {
            r = m - 1;
        }

        else if (m === x) {
            result = arr.indexOf(x.toString());
            console.log(result);
            break;
        }
    }
}
solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '2']);