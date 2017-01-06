function solve(args) {
    let len = +args[0];
    let currentNum;
    let currentOcc = 0;
    let mostOcc = 0;
    let mostOccNum = args[1];

    for (let i = 1; i <= len; i++) {
        currentOcc = 0;
        currentNum = +args[i];

        for (let j = i; j <= len; j++) {

            if (+currentNum === +args[j]) {

                currentOcc++;

                if (currentOcc > mostOcc) {

                    mostOcc = currentOcc;
                    mostOccNum = +args[j];

                }
            }
        }
    }
    console.log(mostOccNum + " (" + mostOcc + " times)");
}