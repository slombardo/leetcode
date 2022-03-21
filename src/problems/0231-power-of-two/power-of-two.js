/**
 * @param {number} n
 * @return {boolean}
 */
const checkOnesInBinaryUsingToString = function (n) {
    if(n < 1) return false

    const binary = (n).toString(2);
    return (binary.match(/1/g) ||[]).length === 1;
};

/**
 * @param {number} n
 * @return {boolean}
 */
const checkForMoreThanOneOneWhileLooping = function (n) {
    if(n < 1) return false

    let oneFound = n % 2 === 1;
    while (n > 1) {
        n = n / 2;
        const isOne = n % 2 === 1;
        if(oneFound && isOne) return false;
        oneFound ||= isOne;
    }

    return oneFound && n === 1;
};

module.exports = {
    checkOnesInBinaryUsingToString: checkOnesInBinaryUsingToString,
    checkForMoreThanOneOneWhileLooping: checkForMoreThanOneOneWhileLooping
};