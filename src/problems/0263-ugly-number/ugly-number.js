/**
 * @param {number} n
 * @return {boolean}
 */
const wayTooBruteForce = function (n) {
    if (n <= 0) return false;
    for (let i = 7; i <= n; i++) {

        // see if the current number is a prime number
        let isPrime = true;
        for (let j = 2; j < i; j++) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (!isPrime) continue;

        if (n % i === 0) return false;
    }
    return true;
};

/* Abandoned.  Sad trombone */
const primeShortcuts = function (n) {
    if (n < 0) return false;
    const endCheck = /[024568]/;
    for (let i = 7; i <= n; i++) {

        // first see if we can determine non-primeness by last digit.
        const stringValue = i.toString()
        if (endCheck.test(stringValue[-1])) continue;

        // use sum is multiple of 3 rule to determine non-primeness
        const sum = stringValue.split("").reduce((partialSum, next) => partialSum + parseInt(next), 0);
        if (sum % 3 === 0) continue;

        // manually see if the current number is a prime number
        let isPrime = true;
        for (let j = 2; j < i / 2; j++) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (!isPrime) continue;

        if (n % i === 0) return false;
    }
    return true;
};

// solution after relearning high school math rules :(
/**
 * @param {number} n
 * @return {boolean}
 */
const bruteForce = function (n) {
    if (n < 0) return false;
    const uglyPrimes = [5, 3, 2];

    for (const uglyPrime of uglyPrimes) {
        while (n % uglyPrime === 0) n = n / uglyPrime;
    }

    return n === 1;
};

module.exports = {
    bruteForce: bruteForce,
    wayTooBruteForce: wayTooBruteForce,
    primeShortcuts: primeShortcuts
};