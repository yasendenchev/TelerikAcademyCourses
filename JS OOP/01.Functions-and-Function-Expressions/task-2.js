/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/
function solve() {

	return function findPrimes(start, end) {
		if (start == null || end == null) {
			throw Error;
		}

		let arr = [];
		for (let i = Number(start); i <= Number(end); i++) {
			if (isPrime(i) === true) {
				arr.push(Number(i));
			}
			return arr;
		}

		function isPrime(num) {
			let start = 2;
			if (num < 2) {
				return false;
			}
			while (start <= Math.sqrt(num)) {
				if (num % start++ < 1) {
					return false
				}
			}
			return true;
		}
	}
	module.exports = solve;