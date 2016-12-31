function solve(args) {
    let number = args[0];

    for(let i = 0; i < 2;i += 1) {
        number =Math.floor(number / 10);
        
    }

    if (number % 10 === 7) {

        console.log(true);
    }

    else {

        console.log("false " + Math.floor(number % 10));
    }
}
solve(['770']);