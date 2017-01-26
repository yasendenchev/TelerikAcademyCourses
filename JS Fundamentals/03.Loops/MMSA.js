function solve(args) {
    let max = -1000;
    let min = 1000;
    let avg;
    let sum = 0;
    let as = args.Le

    for (let i = 0; i < args.length; i ++) {
        if (+args[i] > max) {
            max = +args[i];
        }
        if (+args[i] < min) {
            min = +args[i];
        }
        sum += Number(args[i]);
    }
    
avg = sum / args.length;

console.log("min=" + min.toFixed(2));
console.log("max=" + max.toFixed(2));
console.log("sum=" + sum.toFixed(2));
console.log("avg=" + avg.toFixed(2));
}

solve(['-3', '-1', '-2']);