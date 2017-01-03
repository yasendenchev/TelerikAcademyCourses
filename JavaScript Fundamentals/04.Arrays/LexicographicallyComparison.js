function solve(args) {
    let word1 = args[0];
    let word2 = args[1];

    if (word1 > word2) {
        console.log(">");
    }

    else if (word1 === word2) {
        console.log("=");

    }

    else {
        console.log("<");
    }
}