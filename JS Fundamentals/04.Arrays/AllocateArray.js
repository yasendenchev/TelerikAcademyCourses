function solve(args) {
    let n = +args[0];
    let array = [];

    for (let i = 0; i < n; i++) {
        array.push(i * 5);
        console.log(array[i]);
    }
}