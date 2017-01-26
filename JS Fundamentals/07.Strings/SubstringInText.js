function solve(args) {
    let subString = args[0];
    let text = args[1];
    let lastIndex = 0;
    let counter = 0;


    while (true) {

        if (text.indexOf(subString, ++lastIndex) >= 0) {
            counter++;
            lastIndex = text.indexOf(subString, lastIndex);
        }
        else {
            break;
        }

    }
    console.log(counter);
}
solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);