function solve(args) {
    let number = Number(args[0]);
    for (let i = 2; i < 10; i += 1) {
        if(i === number)
        {
            continue;
        }
        if (number < 0 || number % i === 0) {
            console.log("false");
            break;
        }
        if (number > 0 && i === 9) {
            console.log("true");
            break;
        }
    }
}
solve(['3']);