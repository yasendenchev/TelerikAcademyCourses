function solve(args) {
    let input = args[0];
    let inBracketsLevel = 0;
    let openingCount = 0;
    let closingCount = 0;
    let firstIsClosing = false;
    for (let i = 0; i < input.length; i++) {

        if (input[i] === ")" && inBracketsLevel === 0) {
            firstIsClosing = true;
            break;
        }

        else if (input[i] === "(") {
            inBracketsLevel++;
            openingCount++;
        }

        else if (input[i] === ")" && inBracketsLevel > 0) {
            inBracketsLevel--;
            closingCount++;
        }
    }
    if (inBracketsLevel > 0 || firstIsClosing === true) {
        console.log("Incorrect");
    }

   else if (openingCount === closingCount && inBracketsLevel === 0) {
        console.log("Correct");
    }

    else {
        console.log("Incorrect");
    }
}
solve([ ')(a+b))' ]);