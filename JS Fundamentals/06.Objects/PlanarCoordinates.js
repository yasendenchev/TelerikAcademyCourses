function solve(args) {
    let arr = args.map(Number)
    let a = newLine(arr.slice(0, 4));
    let b = newLine(arr.slice(4, 8));
    let c = newLine(arr.slice(8, 12));

    if (a + b > c && a + c > b && b + c > a) {
        console.log(a.toFixed(2));
        console.log(b.toFixed(2));
        console.log(c.toFixed(2));
        console.log("Triangle can be built");
    }
    else {
        console.log(a.toFixed(2));
        console.log(b.toFixed(2));
        console.log(c.toFixed(2));
        console.log("Triangle can not be built");
    }

    function newLine(array) {

        let pointOneX = array[0];
        let pointOneY = array[1];
        let pointTwoX = array[2];
        let pointTwoY = array[3];


        return lineLength(pointOneX, pointOneY, pointTwoX, pointTwoY);

        function lineLength(x1, y1, x2, y2) {
            return Math.sqrt(Math.pow(x1 - x2, 2) + Math.pow(y1 - y2, 2));
        }
    }
}
solve([
    '7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123'
]);