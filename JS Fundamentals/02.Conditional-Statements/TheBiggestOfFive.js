function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);
    let c = Number(args[2]);
    let d = Number(args[3]);
    let e = Number(args[4]);
    let max = Math.max(Math.max(Math.max(Math.max(a, b), c), d), e);
    console.log(max);
}
solve(['-2', '-22', '1', '0', '0']);