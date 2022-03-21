/**
 * @param {number} n
 * @return {boolean}
 */
const isHappy = function (n) {

    const processed = new Set();
    let current = n;

    let failsafe = 100;
    while (current !== 1 && --failsafe !== 0){
        const stringValue = current.toString();

        const processedCount = processed.size;
        processed.add(current);

        if (processedCount === processed.size) return false;

        current = 0;

        for (let i = 0; i < stringValue.length; i++) {
            current += Math.pow(+stringValue[i], 2);
        }

        // console.log(`current is: ${current}`);
    }

    return failsafe !== 0;
};

module.exports = {
    isHappy: isHappy
};