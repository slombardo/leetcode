    /*
        4 X
        1(3): X
        2(2): X
        3(1): X

        * get him to 4 and he will never win *

        5 /
        1(4): /

        6 /
        2(4): /

        7 /
        3(4): /

        8 X
        1(7): X
        2(6): X
        3(5): X

        * get him to 8 and he will never win *

        9 /
        1(8): /

        10 /
        2(8): /

        11 /
        3(8): /

        12 X
        1(11): X
        2(10): X
        3(9):  X

        * get him to 12 and he will never win *

        13 /
        1(12): /

        14 /
        2(12): /

        15 /
        3(12): /

        16 X
        1(15): X
        2(14): X
        3(13): X
     */

/**
 * @param {number} n
 * @return {boolean}
 */
const canWinNim = function (n) {
    return n % 4 !== 0;
};

module.exports = {
    canWinNim: canWinNim
};