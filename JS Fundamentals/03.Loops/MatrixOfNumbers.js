function solve(args) {
    let n = +args[0];
    let line = "";
    for(let i = 1; i <= n; i += 1) {
        for(let j = i; j < n + i; j ++) {
            line = line + j + " ";
        }
        console.log(line);
        line = "";
    }
}
solve([4]);