function solve(args) {
    let array = args;
    let n = array[0];
    let counter = 1;
    let maxSeq = 0;

    for (let i = 1; i <= args.length; i++) {

        if (maxSeq < counter) {
            maxSeq = counter;
        }

        if (i != 1 && array[i - 1] === array[i]) {
            counter++;
        }

        else {
            counter = 1;
        }
    }

    console.log(maxSeq);
}