/**
 * @param {number[]} nums
 * @return {number}
 */
const bruteForce = function (nums) {
    const actualSum = nums.reduce((partialSum, a) => partialSum + a, 0);

    // get expected sum of range
    let expectedSum = 0;

    for (let i = 0; i <= nums.length; i++) {
        expectedSum += i;
    }

    return expectedSum - actualSum;
};

module.exports = {
    bruteForce: bruteForce,
};