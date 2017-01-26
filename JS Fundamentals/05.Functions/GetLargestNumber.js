function solve(args) {
    let arr = args[0].split(' ');
    let firstN = +arr[0];
    let secondN = +arr[1];
    let thirdN = +arr[2];
    let temp = +GetMax(firstN, secondN);
    let result = +GetMax(thirdN, temp);
    
     

    function GetMax(first, second) {
        if (first > second) {
            return first
        }

        else {
            return second;
        }
    }
    console.log(result);
    console.log(typeof result);
}
solve(['8 3 19']);