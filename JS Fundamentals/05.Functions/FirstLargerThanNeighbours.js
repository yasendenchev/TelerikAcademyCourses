function solve(args) {
    let len = +args[0];
    let arr = args[1].split(' ');
    let result = FindFirstLargerThanNeighbours(arr, len);
    console.log(result);

    function FindFirstLargerThanNeighbours(array, length) {
        let result = 0;

        for (let i = 0; i < length; i++) {
            if (+array[i] > +array[i + 1] && +array[i] > +array[i - 1]) {
                return i;
                break;
            }
        }
    }
}
solve(['6', '-24 -25 -28 31 2 27'])