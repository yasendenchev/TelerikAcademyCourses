function solve(args) {
    let len = +args[0];
    let iNum, minNum, indexMin;
    for (let i = 1; i <= len; i++) {
        iNum = +args[i];

        for (let j = i + 1; j <= len; j++) {

            if (iNum > +args[j]) {
                minNum = +args[j];
                iNum = minNum;
                indexMin = j;
            }
        }
        if (iNum != +args[i]) {
            temp = minNum;
            args[indexMin] = +args[i];
            args[i] = minNum;
        }

        console.log(args[i]);
    }
}
solve(['6', '3', '4', '1', '5', '2', '6'])