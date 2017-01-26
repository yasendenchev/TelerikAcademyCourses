function solve(args) {
    let len = args[0];
    let arr = args[1].split(' ');
    let x = args[2];

    console.log(countAppearanceOf(x, arr));

    function countAppearanceOf(x, array) {

        let count = 0;
        for (let i = 0; i < len; i++) {
            if (arr[i] === x) {
                count++;
            }
        }

        return count;
    }
}
solve(['8', '28 6 21 6 -7856 73 73 -56', '73']);