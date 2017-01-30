/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve() {
	return function sum(arr) {
		let result = 0;
		if (arr.length == 0) {
			return null;
		}

		if (arr == null) {
			throw Error;
		}

		for (let i = 0; i < arr.length; i++) {
			if (isNaN(arr[i])) {
				throw Error;
			}
			result += Number(arr[i]);
		}

		return result;
	}
}

module.exports = solve;
