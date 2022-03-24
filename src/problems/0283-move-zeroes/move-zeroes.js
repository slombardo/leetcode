/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
const onePass = function (nums) {
    let totalZeros = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] === 0) {
            totalZeros++;
            continue;
        }

        if (totalZeros === 0) continue;
        nums[i - totalZeros] = nums[i];
    }

    for (let i = 1; i <= totalZeros; i++) {
        nums[nums.length - i] = 0;
    }
};

module.exports = {
    onePass: onePass
};