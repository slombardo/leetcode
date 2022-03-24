/**
 * Definition for isBadVersion()
 *
 * @param {integer} version number
 * @return {boolean} whether the version is bad
 * isBadVersion = function(version) {
 *     ...
 * };
 */

/**
 * @param {function} isBadVersion()
 * @return {function}
 */
const binarySearch = function (isBadVersion) {
    /**
     * @param {integer} n Total versions
     * @return {integer} The first bad version
     */
    return function (n) {
        let left = 0;
        let right = n + 1;

        while (true){
            const mid = Math.ceil((right - left) / 2) + left;

            // if middle is a bad version, then look left
            if(!isBadVersion(mid)){
                left = mid;
                continue;
            }

            if(left === mid - 1) return mid;

            right = mid;
        }
    };
};

module.exports = {
    binarySearch: binarySearch,
};