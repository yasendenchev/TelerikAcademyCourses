function solve(args) {
    let input = args[0];
    let result = "";

    for(let i = 0; i < input.length; i ++) {
         result += input[input.length - 1 - i];
    }
    console.log(result);
    
}
solve(['sample'])