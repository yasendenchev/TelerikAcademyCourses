function solve(args) {
    let number = Number(args[0]);
    let units = number % 10;
    let tens = Math.floor(number / 10) % 10;
    let hundreds = Math.floor(number / 100);
    let unit = "";
    let ten = "";
    let hundred = "";
    let result;
    if (units === 0 && tens === 0 && hundreds === 0)
    {
        unit = "zero";
    }

    switch (units) {
        case 1:
            unit = "one";
            break;
        case 2:
            unit = "two";
            break;
        case 3:
            unit = "three";
            break;
        case 4:
            unit = "four";
            break;
        case 5:
            unit = "five";
            break;
        case 6:
            unit = "six";
            break;
        case 7:
            unit = "seven";
            break;
        case 8:
            unit = "eight";
            break;
        case 9:
            unit = "nine";
            break;
    }

    if (tens === 1 && units > 0) {
        switch (units) {
            case 1:
                unit = "eleven";
                break;
            case 2:
                unit = "twelve";
                break;
            case 3:
                unit = "thirteen";
                break;
            case 5:
                unit = "fifteen";
                break;
            case 8:
                unit = "eighteen";
                break;
            default:
                unit += "teen";
        }

    }

    if (tens > 0) {
        if (tens === 1 && units === 0) {
            ten = "ten";
        }

        switch (tens) {
            case 2:
                ten = "twenty ";
                break;
            case 3:
                ten = "thirty ";
                break;
            case 4:
                ten = "forty ";
                break;
            case 5:
                ten = "fifty ";
                break;
            case 6:
                ten = "sixty ";
                break;
            case 7:
                ten = "seventy ";
                break;
            case 8:
                ten = "eighty ";
                break;
            case 9:
                ten = "ninety ";
                break;

        }
    }
    switch (hundreds) {
        case 1:
            hundred = "one hundred ";
            break;
        case 2:
            hundred = "two hundred ";
            break;
        case 3:
            hundred = "three hundred ";
            break;
        case 4:
            hundred = "four hundred ";
            break;
        case 5:
            hundred = "five hundred ";
            break;
        case 6:
            hundred = "six hundred ";
            break;
        case 7:
            hundred = "seven hundred ";
            break;
        case 8:
            hundred = "eight hundred ";
            break;
        case 9:
            hundred = "nine hundred ";
            break;
    }

    if (hundreds > 0 && (tens > 0 || units > 0)) {
        hundred += "and "
    }
    result = hundred + ten + unit;
    result = result.trim();
    result = result[0].toUpperCase() + result.substr(1);
    console.log(result);

}
solve([999]);


