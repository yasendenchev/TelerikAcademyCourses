function solve(args){

    let number = args[0];
    let position = 3;
    let mask = 1 << position;
    let nAndMask = number & mask;
    let result = nAndMask >> position;
    console.log(result & 1);
}
args(['0']);