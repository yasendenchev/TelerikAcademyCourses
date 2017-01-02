function solve(args) {
    let hex = args[0];
    let dec;
    let currentDigit;
    let result = 0;

    for (let i = 0; i < hex.length; i++) {
        currentDigit = hex[hex.length - 1 - i];
        if (currentDigit.charCodeAt(0) > 57) {
            switch (currentDigit) {
                case "A":
                    result += 10 * Math.pow(16, i);
                    break;
                case "B":
                    result += 11 * Math.pow(16, i);
                    break;
                case "C":
                    result += 12 * Math.pow(16, i);
                    break;
                case "D":
                    result += 13 * Math.pow(16, i);
                    break;
                case "E":
                    result += 14 * Math.pow(16, i);
                    break;
                case "F":
                    result += + 15 * Math.pow(16, i);
                    break;
            }
        }

        else {
            result += +currentDigit * Math.pow(16, i);
        }
    }

        console.log(result);
}
solve(['4ED528CBB4']);