function solve(args) {
    let arr = args[0].split(' ');
    let len = arr.length;
    arr = arr.map(Number);
    let peaks = FindPeaks(arr, len);
    let peak1 = 0;
    let index1 = 0;
    let peak2 = 0;
    let index2 = 0;
    let currentSum = 0;
    let maxSum = 0;

    for (let i = 0; i < peaks.length; i++) {
        peak1 = +peaks[i];
        index1 = +arr.indexOf(peak1);
        peak2 = +peaks[i + 1];
        index2 = arr.indexOf(peak2);
        
        for(let j = index1; j <= arr.indexOf(peak2, index1 + 2); j ++) {
             currentSum += arr[j];
        }

        if (+currentSum > +maxSum)
        {
            maxSum = currentSum;
        }
        currentSum = 0;
    }

    console.log(maxSum);


    function FindPeaks(array, length) {
        let peaks = [];

        for (let i = 0; i < length; i++) {

            if (i === 0 && +array[i] > +array[i + 1]) {
                peaks.push(array[i]);
            }

            if (+array[i] > +array[i + 1] && +array[i] > +array[i - 1]) {
                peaks.push(array[i])
            }

            if (i === length - 1 && +array[i] > +array[i - 1]) {
                peaks.push(array[i])
            }
        }
        return peaks
    }
}
// solve(["5 1 7 4 8"]);
solve(["5 1 7 6 5 6 4 2 3 8"]);