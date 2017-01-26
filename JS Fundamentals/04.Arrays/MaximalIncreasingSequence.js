function solve(args) {
    let array = args;
    let n = array[0];
    let counter = 1;
    let maxSeq = 0;

    for (let i = 1; i < args.length; i++) {

        if (+array[i] < array[i + 1]) {
            counter++;
        }

        else {
            counter = 1;
        }

        if (maxSeq < counter) {
            maxSeq = counter;
        }
    }

    console.log(maxSeq);
}