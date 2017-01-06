function solve(args) {
    let n = +args[0]
    let arr = [];
    arr[n] = true;
    let count = 0;
    arr.fill(true);

    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (arr[i] == true) {
            for(let j = i * i ; j <= n; j += i, count++) {
                 arr[j] = false;
            }
        }
    }

    console.log(arr.lastIndexOf(true));

}
solve([100000000]);