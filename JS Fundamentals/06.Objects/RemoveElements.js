function solve(args) {
    Array.prototype.remove = function Remove(target) {
        for (let i = 0; i < Array.length; i++) {
            if (Array[0] === Array[i]) {
                Array.prototype.splice(i);
            }
        }
    }
    let result = args.prototype.remove(args[0]);

    for(let i = 0; i < result.length; i ++) {
         result[i]
    }
}
solve([ '1', '2', '3', '2', '1', '2', '3', '2' ]);